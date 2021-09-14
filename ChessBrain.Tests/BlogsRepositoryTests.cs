using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBrainRespository;
using NUnit.Framework;
using ChessBrainBackEnd.Pocos;

namespace ChessBrain.Tests
{
    [TestFixture]
    class BlogsRepositoryTests : SqlBlogRepository
    {
        [Test]
        public void Test_GetAllBlogs_GetsAllPostsInDatabase_WhenCalled()
        {
            // At this point. I don't think expected will have anything inside it at all. If this ever returns a blog, they will now be different, and test fails because one will be full.
            // one empty

            // Arrange
            SqlBlogRepository sqlBlog = new SqlBlogRepository();
            List<Blog> actual = new List<Blog>();
            List<Blog> expected = new List<Blog>();

            // Act
            actual = sqlBlog.GetAllBlogs();

            // Assert
            Assert.AreNotEqual(expected, actual);
            // NOT EQUAL BECAUSE ACTUAL SHOULD BE FILLED WITH POSTS
        }

        [Test]
        public void Test_GetIndividualBlogsByBlogId_GetsAllPostsOnBlogId1_WhenGivenBlogIdOf1()
        {
            // Arrange
            SqlBlogRepository sqlBlog = new SqlBlogRepository();
            Blog actual = new Blog();
            Blog expected = new Blog();
            expected.BlogId = 1;

            // Act
            actual = sqlBlog.GetIndividualBlogsByBlogId(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Exact same test as above, but the BlogId given now is 2.
        [Test]
        public void Test_GetIndividualBlogsByBlogId_GetsAllPostsOnBlogId2_WhenGivenBlogIdOf2()
        {
            // Arrange
            SqlBlogRepository sqlBlog = new SqlBlogRepository();
            Blog actual = new Blog();
            Blog expected = new Blog();
            expected.BlogId = 2;

            // Act
            actual = sqlBlog.GetIndividualBlogsByBlogId(2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Exact same test as above, but the BlogId given now is 3.
        [Test]
        public void Test_GetIndividualBlogsByBlogId_GetsAllPostsOnBlogId3_WhenGivenBlogIdOf3()
        {
            // Arrange
            SqlBlogRepository sqlBlog = new SqlBlogRepository();
            Blog actual = new Blog();
            Blog expected = new Blog();
            expected.BlogId = 3;

            // Act
            actual = sqlBlog.GetIndividualBlogsByBlogId(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
