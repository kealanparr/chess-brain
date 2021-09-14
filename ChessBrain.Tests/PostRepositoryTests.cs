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
    [TestFixture]
    class PostRepositoryTests  : SqlPostRepository
    {
        [Test]
        public void Test_GetPostsById_GetPostsById1_WhenGivenPostId1()
        {
            // Arrange
            SqlPostRepository sqlBlog = new SqlPostRepository();
            Post actual = new Post();
            Post expected = new Post();
            expected.PostId = 1;

            // Act
            actual = sqlBlog.GetPostsById(1);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_GetPostsById_GetPostsById2_WhenGivenPostId2()
        {
            // Arrange
            SqlPostRepository sqlBlog = new SqlPostRepository();
            Post actual = new Post();
            Post expected = new Post();
            expected.PostId = 2;

            // Act
            actual = sqlBlog.GetPostsById(2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_GetPostsById_GetPostsById3_WhenGivenPostId3()
        {
            // Arrange
            SqlPostRepository sqlBlog = new SqlPostRepository();
            Post actual = new Post();
            Post expected = new Post();
            expected.PostId = 3;

            // Act
            actual = sqlBlog.GetPostsById(3);

            // Assert
            Assert.AreEqual(expected, actual);

        }


        // New method being tested

        [Test]
        public void Test_GetTitleById_GetsTitleId1_WhenGivenPostId1()
        {
            // Arrange
            SqlPostRepository sqlBlog = new SqlPostRepository();
            Post actual = new Post();
            List<Post> expected = new List<Post>();

            // Act
            actual = sqlBlog.GetTitleById(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_GetTitleById_GetsTitleId2_WhenGivenPostId2()
        {
            // Arrange
            SqlPostRepository sqlBlog = new SqlPostRepository();
            Post actual = new Post();
            List<Post> expected = new List<Post>();

            // Act
            actual = sqlBlog.GetTitleById(2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_GetTitleById_GetsTitleId3_WhenGivenPostId3()
        {
            // Arrange
            SqlPostRepository sqlBlog = new SqlPostRepository();
            Post actual = new Post();
            List<Post> expected = new List<Post>();

            // Act
            actual = sqlBlog.GetTitleById(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        // New method being tested

        [Test]
        public void Test_GetContentById_GetsContentOfId1_WhenGivenPostId1()
        {
            // Arrange
            SqlPostRepository sqlBlog = new SqlPostRepository();
            Post actual = new Post();
            List<Post> expected = new List<Post>();

            // Act
            actual = sqlBlog.GetTitleById(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_GetContentById_GetsContentOfId2_WhenGivenPostId2()
        {
            // Arrange
            SqlPostRepository sqlBlog = new SqlPostRepository();
            Post actual = new Post(); 
            List<Post> expected = new List<Post>();

            // Act
            actual = sqlBlog.GetTitleById(2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_GetContentById_GetsContentOfId3_WhenGivenPostId3()
        {
            // Arrange
            SqlPostRepository sqlBlog = new SqlPostRepository();
           Post actual = new Post();
            List<Post> expected = new List<Post>();

            // Act
            actual = sqlBlog.GetTitleById(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // New method being tested

        [Test]
        public void Test_GetAllPostsByUserId_GetsAllPostsOfUserId1_WhenGivenUserId1()
        {
            // Arrange
            SqlPostRepository sqlBlog = new SqlPostRepository();
            List<Post> actual = new List<Post>();
            List<Post> expected = new List<Post>();

            // Act
            actual = sqlBlog.GetAllPostsByUserId (1);

            // Assert
            Assert.AreEqual(expected, actual);                                                    
                                                                            
        }                                                                   
                                                                            
        [Test]                                                              
        public void Test_GetAllPostsByUserId_GetsAllPostsOfUserId2_WhenGivenUserId2()
        {
            // Arrange
            SqlPostRepository sqlBlog = new SqlPostRepository();
            List<Post> actual = new List<Post>();
            List<Post> expected = new List<Post>();

            // Act
            actual = sqlBlog.GetAllPostsByUserId(2);

            // Assert
            Assert.AreEqual(expected, actual);                                        
                                                                            
        }                                                                   
                                                                            
        [Test]                                                              
        public void Test_GetAllPostsByUserId_GetsAllPostsOfUserId3_WhenGivenUserId3()
        {
            // Arrange
            SqlPostRepository sqlBlog = new SqlPostRepository();
            List<Post> actual = new List<Post>();
            List<Post> expected = new List<Post>();

            // Act
            actual = sqlBlog.GetAllPostsByUserId(3);

            // Assert
            Assert.AreEqual(expected, actual); 

        }

        
    }
}

/*
 public string GetPostsById(int PostId)
        {
            throw new NotImplementedException();
        }

        public string GetTitleById(int PostId)
        {
            throw new NotImplementedException();
        }

        public string GetContentById(int PostId)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAllPostsByUserId(int UserId)
        {
            throw new NotImplementedException();
        }
*/