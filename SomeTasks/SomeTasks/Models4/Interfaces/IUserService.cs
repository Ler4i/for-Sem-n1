using SomeTasks.Models4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models4.Interfaces
{
    public interface IUserService
    {
        Task<UserInformation> RegisterWithPhone(string numberPrefix, string number, string password);//регистрация в ()-запрос
        Task<UserInformation> AuthWithPhone(string numberPrefix, string number, string password);//авторизация через телефон
        Task<UserInformation> AuthWithEmail(string email, string password);//авторизация через мыло
        Task<UserInformation> AuthWithLogin(string login, string password);
        Task<UserInformation> Get(int userId);
        Task<UserInformation> Update(UserUpdate userUpdate);//put
        Task<bool> DoesExist(string numberPrefix, string number);//занят ли номер телефона
    }
}
