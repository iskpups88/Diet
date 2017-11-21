using System;
using Diet.Models;
using Diet.Repositories;
using Diet.Util;
using Diet.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;


namespace DietUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AuthWhithInvalidData()
        {
            var myMoq = new Mock<IUserRepository>();
            myMoq.Setup(x => x.AddUser(new User()));
            MvxSimpleIoCContainer.Initialize();
            Mvx.RegisterSingleton<IUserRepository>(() => myMoq.Object);

            //var view = new RegistrationViewModel()
            //{
            //    Age = 14,
            //    Weight = 30,
            //    UserName = "SSSSSS",
            //    Password = "2222",
            //    PasswordConfirmation = "sssss"
            //};
            //view.CanRegister();
            //Assert.AreEqual(false, view.IsEnabled);
        }

        [TestMethod]
        public void AuthWhithValidData()
        {
            var view = new RegistrationViewModel()
            {
                Age = 15,
                Weight = 31,
                UserName = "SSSSSS",
                Password = "2222",
                PasswordConfirmation = "2222",

            };
            view.CanRegister();
            Assert.AreEqual(true, view.IsEnabled);
        }
        //[TestMethod]
        //public void CheckUserInDataBase()
        //{
        //    UserRepository userRepo = new UserRepository("TestDb");
        //    User user = new User();
        //    user.Id = 1;
        //    user.UserName = "Iskan";
        //    user.Password = "qwerty";
        //    user.Age = 20;
        //    user.Sex = true;
        //    user.Weight = 70;
        //    userRepo.AddUser(user);

        //}
    }
}
