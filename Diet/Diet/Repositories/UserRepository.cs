using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Diet.Util;

namespace Diet.Models
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
            User user = (User)GetItems().Where(t => t.UserName == username).First();
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

        public bool CheckUser(string login, string password)
        {
            return (GetItems().Where(t => t.UserName == login & t.Password == password)
                    .Count()) == 1;
            
        }

        public void AddUser(User item)
        {
            try
            {
                database.Insert(item);               
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);                
            }
        }
    }
}