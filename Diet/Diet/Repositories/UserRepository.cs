using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.Models;
using Diet.Util;
using SQLite;
using Xamarin.Forms;

namespace Diet.Repositories
{
    public class UserRepository: IUserRepository
    {
        SQLiteConnection database;

        public UserRepository()
        {
            string filename = "localDb";
            string databasePath = DependencyService.Get<IFileHelper>().GetLocalFilePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<User>();
        }

        public IEnumerable<User> GetItems()
        {
            return (from i in database.Table<User>() select i).ToList();

        }

        public User GetUser(string username)
        {
            User user = GetItems().First(t => t.UserName == username);
            return user;
        }

        public User GetItem(int id)
        {
            return database.Get<User>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<User>(id);
        }

        public int SaveItem(User item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }

        public int CheckUser(string login, string password)
        {
            int i = GetItems().Count(t => t.UserName == login & t.Password == password);
            return i;
        }

        public void AddUser(User item)
        {
            try
            {
                database.Insert(item);               
            }
            catch (Exception e)
            {
                throw;                
            }
        }
    }
}