﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Diet.Util;

namespace Diet.Models
{
    public class UserRepository
    {
        SQLiteConnection database;

        public UserRepository(string filename)
        {
            string databasePath = DependencyService.Get<IFileHelper>().GetLocalFilePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<User>();
        }

        public IEnumerable<User> GetItems()
        {
            return (from i in database.Table<User>() select i).ToList();

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

        public bool checkUser(string login, string password)
        {
            bool check = true;
            IEnumerable<User> users = GetItems();
            foreach (var item in users)
            {
                if (item.UserName == login & item.Password == password)
                {
                    check = true;
                    break;
                }
                else
                    check = false;
            }
            return check;
        }
    }
}