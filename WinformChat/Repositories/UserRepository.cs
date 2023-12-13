using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using WinformsChat.Models;

namespace WinformsChat.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;
        public UserRepository(string conn)
        {
            _connectionString = conn;
        }

        public static List<User> Users = new List<User>()
        {
            new User()
            {
                Login = "admin",
                Password = "admin"
            },
        };

        public List<User> GetUsers()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<User>("SELECT * FROM [dbo].[User]").ToList();
            }
        }

        public void Create(User user)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "INSERT INTO [dbo].[User] (Login, Password) VALUES(@Login, @Password)";
                db.Execute(sqlQuery, user);

                // если мы хотим получить id добавленного пользователя
                //var sqlQuery = "INSERT INTO Users (Name, Age) VALUES(@Name, @Age); SELECT CAST(SCOPE_IDENTITY() as int)";
                //int? userId = db.Query<int>(sqlQuery, user).FirstOrDefault();
                //user.Id = userId.Value;
            }
        }
    }
}
