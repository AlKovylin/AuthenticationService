using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationService
{
    public class UserRepository : IUserRepository
    {
        private List<User> UserList = new List<User>();

        public UserRepository()
        {
            UserList.Add(new User
            {
                FirstName = "Иван",
                LastName = "Иванов",
                Id = Guid.NewGuid(),
                Email = "ivanov@ya.ru",
                Login = "ivanov",
                Password = "11111",
                Role = new Role() { 
                    Id = 1, 
                    Name = "Пользователь"
                }
            });

            UserList.Add(new User
            {
                FirstName = "Пётр",
                LastName = "Петров",
                Id = Guid.NewGuid(),
                Email = "petrov@mail.ru",
                Login = "petrov",
                Password = "22222",
                Role = new Role()
                {
                    Id = 2,
                    Name = "Администратор"
                }
            });

            UserList.Add(new User
            {
                FirstName = "Сидор",
                LastName = "Сидоров",
                Id = Guid.NewGuid(),
                Email = "sidorov@gmail.com",
                Login = "sidorov",
                Password = "33333",
                Role = new Role()
                {
                    Id = 1,
                    Name = "Пользователь"
                }
            });
        }

        public IEnumerable<User> GetAll()
        {
            return UserList;
        }

        public User GetByLogin(string login)
        {
            return UserList.FirstOrDefault(v => v.Login == login);
        }
    }
}
