using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsChat.Models;

namespace WinformsChat.Repositories
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        void Create(User user);
    }
}
