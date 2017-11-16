using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.Models;

namespace Diet.Util
{
    public interface IUserRepository
    {
        User GetUser(string username);
        User GetItem(int id);
        int DeleteItem(int id);
        int SaveItem(User item);
        bool CheckUser(string login, string password);
        void AddUser(User item);
    }
}
