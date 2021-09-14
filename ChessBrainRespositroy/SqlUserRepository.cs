using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBrainBackEnd.Pocos;
using ChessBrainBackEnd;

namespace ChessBrainRespository
{
    public class SqlUserRepository : IUserRepository
    {
        ChessBrainModel context;

        public SqlUserRepository()
        {
            context = new ChessBrainModel();
        }
        // This is using your ACTUAL database, filled with real data

        public SqlUserRepository(ChessBrainModel _context)
        {
            context = _context;
        }
        // This one is used later to mock/effort and inject a database. Used later

        public List<User> GetAllUsers()
        {
            return context.Users.ToList();
        }

        public ChessBrainBackEnd.Pocos.User GetUserById(int userId)
        {
            return context.Users.Find(userId);
        }

        public void AddUser(User newUser)
        {
            context.Users.Add(newUser);
            context.SaveChanges();
        }

        public void UpdateUser(User UserToUpdate)
        {
            User user = context.Users.Find(UserToUpdate.UserId);

            user.FirstName = UserToUpdate.FirstName;
            user.LastName = UserToUpdate.LastName;

            context.SaveChanges();
        }

        public void DeleteUser(User UserToDelete)
        {
            User user = context.Users.Find(UserToDelete.UserId);

            context.Users.Remove(user);
            context.SaveChanges();
        }

        public List<User> GetUsersByFirstName(string FirstName)
        {
            return context.Users.Where(u => u.FirstName == FirstName).ToList();
        }

        public List<User> GetUsersBySurname(string Surname)
        {
            return context.Users.Where(u => u.LastName == Surname).ToList();
        }
    }
}
