using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBrainBackEnd.Pocos;

namespace ChessBrainRespository
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();

        User GetUserById(int Userid);

        void AddUser(User newUser);

        void UpdateUser(User UserToUpdate);

        void DeleteUser(User UserToDelete);

        List<User> GetUsersByFirstName(string FirstName);

        List<User> GetUsersBySurname(string Surname);
    }
}
