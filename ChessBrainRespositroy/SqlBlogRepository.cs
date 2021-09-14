using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBrainBackEnd.Pocos;
using ChessBrainBackEnd;

namespace ChessBrainRespository
{
    public class SqlBlogRepository : IBlogRepository
    {
        ChessBrainModel context;

        public SqlBlogRepository()
        {
            context = new ChessBrainModel();
        }
        // This is using your ACTUAL database, filled with real data

        public SqlBlogRepository(ChessBrainModel _context)
        {
            context = _context;
        }
        // This one is used later to mock/effort and inject a database. Used later

        public List<Blog> GetAllBlogs()
        {
            return context.Blogs.ToList();
        }

        public Blog GetIndividualBlogsByBlogId(int blogId)
        {
            throw new NotImplementedException();
        }
    }
}
