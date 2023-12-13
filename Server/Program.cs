using System.Net;
using System.Net.Sockets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WinformsChat.Repositories;

ServerObject server = new ServerObject();// создаем сервер
await server.ListenAsync(); // запускаем сервер

class ServerObject
{
    public static IServiceProvider ServiceProvider { get; private set; }
    TcpListener tcpListener = new TcpListener(IPAddress.Any, 8888); // сервер для прослушивания
    public Dictionary<ClientObject, string> clients = new Dictionary<ClientObject, string>(); // все подключения
    protected internal void RemoveConnection(string id)
    {
        // получаем по id закрытое подключение
        ClientObject? client = clients.FirstOrDefault(c => c.Key.Id == id).Key;
        // и удаляем его из списка подключений
        if (client != null) clients.Remove(client);
        client?.Close();
    }
    // прослушивание входящих подключений
    protected internal async Task ListenAsync()
    {
        try
        {
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            tcpListener.Start();
            Console.WriteLine("Server online. Waiting for clients...");

            while (true)
            {
                TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();

                ClientObject clientObject = new ClientObject(tcpClient, this);
                clients.Add(clientObject, "");
                Task.Run(clientObject.ProcessAsync);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Disconnect();
        }
    }

    // трансляция сообщения подключенным клиентам
    protected internal async Task BroadcastMessageAsync(string message, string id)
    {
        foreach (var client in clients.Keys)
        {
            if (client.Id != id) // если id клиента не равно id отправителя
            {
                await client.Writer.WriteLineAsync(message); //передача данных
                await client.Writer.FlushAsync();
            }
        }
    }


    protected internal async Task BroadcastMessageSpecificAsync(string message, string id)
    {
        foreach (var client in clients.Keys)
        {
            if (client.Id == id) // если id клиента равно id отправителя
            {
                await client.Writer.WriteLineAsync(message); //передача данных
                await client.Writer.FlushAsync();
            }
        }
    }
    // отключение всех клиентов
    protected internal void Disconnect()
    {
        foreach (var client in clients.Keys)
        {
            client.Close(); //отключение клиента
        }
        tcpListener.Stop(); //остановка сервера
    }
    public IHostBuilder CreateHostBuilder()
    {
        string connectionString = "Data Source=sqlsrv;Initial Catalog=Dest;User ID=admin;Password=123;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) => {
                services.AddTransient<IUserRepository, UserRepository>(provider => new UserRepository(connectionString));
                //services.AddTransient<IShopRepository, ShopRepository>(provider => new ShopRepository(connectionString));
                //services.AddTransient<InputWindow>();
                //services.AddTransient<RegistrationForm>();
                //services.AddTransient<AuthorizeForm>();
                //services.AddTransient<MainWindow>();
            });
    }
}

class ClientObject
{
    protected internal string Id { get; } = Guid.NewGuid().ToString();
    protected internal StreamWriter Writer { get; }
    protected internal StreamReader Reader { get; }

    TcpClient client;
    ServerObject server; // объект сервера

    public ClientObject(TcpClient tcpClient, ServerObject serverObject)
    {
        client = tcpClient;
        server = serverObject;
        // получаем NetworkStream для взаимодействия с сервером
        var stream = client.GetStream();
        // создаем StreamReader для чтения данных
        Reader = new StreamReader(stream);
        // создаем StreamWriter для отправки данных
        Writer = new StreamWriter(stream);
    }

    public async Task ProcessAsync()
    {
        try
        {
            // получаем имя пользователя
            string? userName = await Reader.ReadLineAsync();
            if (userName == "")
            {
                userName = "Anonymous";
            }
            server.clients[this] = userName;
            await server.BroadcastMessageSpecificAsync($"Welcome, {userName}", Id);
            string? message = $"{userName} entered chat";

            // посылаем сообщение о входе в чат всем подключенным пользователям
            await server.BroadcastMessageAsync(message, Id);
            Console.WriteLine(message);
            // в бесконечном цикле получаем сообщения от клиента
            while (true)
            {
                try
                {

                    message = await Reader.ReadLineAsync();
                    if (message == null) continue;
                    message = $"{userName}: {message}";
                    try
                    {
                        while (true)
                        {
                            await server.BroadcastMessageSpecificAsync("\nSend message to (type a number to select):\n1- All\n2- One User", Id);
                            string choice = "";
                            choice = await Reader.ReadLineAsync();
                            if (choice == "1")
                            {
                                await server.BroadcastMessageAsync(message, Id);
                                break;
                            }

                            else
                            {
                                int i = 0;
                                foreach (var x in server.clients)
                                {
                                    i++;
                                    await server.BroadcastMessageSpecificAsync($"{i}- {x.Value} \t\t ({x.Key.Id.ToString()})", Id);
                                }
                                await server.BroadcastMessageSpecificAsync("Enter number to choose: ", Id);
                                string c = await Reader.ReadLineAsync();
                                if (Convert.ToInt16(c) <= server.clients.Count)
                                {
                                    ClientObject tempClient = server.clients.ElementAt(Convert.ToInt16(c) - 1).Key;
                                    await server.BroadcastMessageSpecificAsync(message, tempClient.Id);
                                    break;
                                }
                                await server.BroadcastMessageSpecificAsync($"Error in input, try again", Id);

                            }
                        }


                    }
                    catch
                    {

                        Console.WriteLine("Error in sending message");
                    }
                    Console.WriteLine(message);


                }
                catch
                {
                    message = $"{userName} left chat";
                    Console.WriteLine(message);
                    await server.BroadcastMessageAsync(message, Id);
                    break;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            // в случае выхода из цикла закрываем ресурсы
            server.RemoveConnection(Id);
        }
    }
    // закрытие подключения
    protected internal void Close()
    {
        Writer.Close();
        Reader.Close();
        client.Close();
    }
}