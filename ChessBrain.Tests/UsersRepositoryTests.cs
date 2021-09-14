using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBrainBackEnd.Pocos;
using ChessBrainRespository;
using NUnit.Framework;

namespace ChessBrain.Tests
{
    // This is the main method with most of the methods to test

    [TestFixture]
    class UsersRepositoryTests : SqlUserRepository
    {
        [Test]
        public void Test_GetAllUsers_GetsAllUsersInDatabase_WhenCalled()
        {
            // At this point. I don't think expected will have anything inside it at all. If this ever returns a blog, they will now be different, and test fails because one will be full.
            // one empty

            // Arrange
            SqlUserRepository sqlUser = new SqlUserRepository();
            List<User> actual = new List<User>();
            List<User> expected = new List<User>();

            // Act
            actual = sqlUser.GetAllUsers();

            // Assert
            Assert.AreNotEqual(expected, actual);
            // NOT EQUAL BECAUSE ACTUAL SHOULD BE FILLED WITH USERS
        }

        // New method being tested

        // CHANGE JIM FOR A NAME THAT WILL ACTUALLY RETURN SOMETHING FROM YOUR DB
        // CHANGE JIM FOR A NAME THAT WILL ACTUALLY RETURN SOMETHING FROM YOUR DB
        // CHANGE JIM FOR A NAME THAT WILL ACTUALLY RETURN SOMETHING FROM YOUR DB
        // CHANGE JIM FOR A NAME THAT WILL ACTUALLY RETURN SOMETHING FROM YOUR DB
        // CHANGE JIM FOR A NAME THAT WILL ACTUALLY RETURN SOMETHING FROM YOUR DB
        // CHANGE JIM FOR A NAME THAT WILL ACTUALLY RETURN SOMETHING FROM YOUR DB

        [Test] // Test 1
        public void Test_GetUsersByFirstName_GetsAllUsersOfFirstNameJim_WhenGivenJim()
        { 
            // Arrange
            SqlUserRepository sqlUser = new SqlUserRepository();
            List<User> actual = new List<User>();
            List<User> expected = new List<User>();
            // expected = first.name = jim

            //Act 
            actual = sqlUser.GetUsersByFirstName("Jim");

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [Test] // Test 2
        public void Test_GetUsersByFirstName_GetsAllUsersOfFirstNameJoe_WhenGivenJoe()
        {
            // Arrange
            SqlUserRepository sqlUser = new SqlUserRepository();
            List<User> actual = new List<User>();
            List<User> expected = new List<User>();
            // expected = first.name = joe

            //Act 
            actual = sqlUser.GetUsersByFirstName("Joe");

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [Test] // Test 3
        public void Test_GetUsersByFirstName_GetsAllUsersOfFirstNameJam_WhenGivenJam()
        {
            // Arrange
            SqlUserRepository sqlUser = new SqlUserRepository();
            List<User> actual = new List<User>();
            List<User> expected = new List<User>();
            // expected = first.name = jam

            //Act 
            actual = sqlUser.GetUsersByFirstName("Jam");

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        // New method being tested. Surnames 
        // New method being tested. Surnames 
        // New method being tested. Surnames 
        // New method being tested. Surnames 

        [Test] // Test 1
        public void Test_GetUsersBySurname_GetsAllUsersOfSurnameJim_WhenGivenJim()
        {
            // Arrange
            SqlUserRepository sqlUser = new SqlUserRepository();
            List<User> actual = new List<User>();
            List<User> expected = new List<User>();
            // expected = surname = jim

            //Act 
            actual = sqlUser.GetUsersBySurname("Jim");

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [Test] // Test 2
        public void Test_GetUsersBySurname_GetsAllUsersOfSurnameJoe_WhenGivenJoe()
        {
            // Arrange
            SqlUserRepository sqlUser = new SqlUserRepository();
            List<User> actual = new List<User>();
            List<User> expected = new List<User>();
            // expected = surname = Joe

            //Act 
            actual = sqlUser.GetUsersBySurname("Joe");

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [Test] // Test 3
        public void Test_GetUsersBySurname_GetsAllUsersOfSurnameJam_WhenGivenJam()
        {
            // Arrange
            SqlUserRepository sqlUser = new SqlUserRepository();
            List<User> actual = new List<User>();
            List<User> expected = new List<User>();
            // expected = surname = Jam

            //Act 
            actual = sqlUser.GetUsersBySurname("Jam");

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        // New method being tested. Id 
        // New method being tested. Id 
        // New method being tested. Id 
        // New method being tested. Id 

        [Test] // Test 1
        public void Test_GetUserById_GetsTheUserWithId1_WhenGiven1()
        {
            // Arrange
            SqlUserRepository sqlUser = new SqlUserRepository();
            User actual = new User();
            User expected = new User();
            expected.UserId = 1;
           
            //Act 
            actual = sqlUser.GetUserById(1);

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [Test] // Test 2
        public void Test_GetUserById_GetsTheUserWithId2_WhenGiven2()
        {
            // Arrange
            SqlUserRepository sqlUser = new SqlUserRepository();
            User actual = new User();
            User expected = new User();
            expected.UserId = 2;

            //Act 
            actual = sqlUser.GetUserById(2);

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [Test] // Test 3
        public void Test_GetUserById_GetsTheUserWithId3_WhenGiven3()
        {
            // Arrange
            SqlUserRepository sqlUser = new SqlUserRepository();
            User actual = new User();
            User expected = new User();
            expected.UserId = 3;

            //Act 
            actual = sqlUser.GetUserById(3);

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        











       
    }
}

/*

 
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
            // You will have to use Effort or Moq, for the below methods! ! ! !
        

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


*/