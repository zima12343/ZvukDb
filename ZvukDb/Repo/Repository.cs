using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using ZvukDb.Models;

namespace ZvukDb.Repo
{
    public static class Repository
    {
        public static SoundEquipmentContext db;
        
        public static bool UserExist(string login)
        {
            return db.Users.Where(x => x.Login == login).Count() > 0;
        }

        /// <summary>
        /// Поиск пользователя
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        public static bool FindUser(string login, string password)
        {
            return db.Users.Where(x => x.Login == login && x.Password == Password.GetHashCode(password)).Count() > 0;
        }
        /// <summary>
        /// добавление пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public static void AddUser(string login, string password)
        {
            if (UserExist(login))
            {
                throw new Exception("Такой пользователь уже существует");
            }
            db.Users.Add(new User { Login = login, Password = Password.GetHashCode(password) });
            db.SaveChanges();
        }
    }
}
