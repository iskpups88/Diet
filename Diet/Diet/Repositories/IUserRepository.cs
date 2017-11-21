using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.Models;

namespace Diet.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetItems();
        User GetUser(string username);
        User GetItem(int id);
        int DeleteItem(int id);
        int SaveItem(User item);
        int CheckUser(string login, string password);
        void AddUser(User item);
    }
}
