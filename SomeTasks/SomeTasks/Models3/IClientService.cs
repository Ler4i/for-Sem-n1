using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models3
{
    public interface IClientService
    {       
        Task<Orders> WatchOrders(string name);
        Task<Orders> AddOrders(string name, int count);
        Task<Orders> WatchStatusOfOrders(string name, string status);//нужен ли статус?
    }
}

/* пример  Task<Client> RegisterWithPhone(string numberPrefix, string number, string password);//регистрация в ()-запрос
        Task<Client> AuthWithPhone(string numberPrefix, string number, string password);//авторизация через телефон
        Task<Client> AuthWithEmail(string email, string password);//авторизация через мыло
        Task<Client> AuthWithLogin(string login, string password);
        //Task<UserInformationBlo> Get(int userId); из изначального проекта                      
        //Task<UserInformationBlo> Update(UserUpdateBlo userUpdateBlo);//put
        Task<bool> DoesExist(string numberPrefix, string number);//занят ли номер телефона*/