using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBrainBackEnd.Pocos;
using ChessBrainBackEnd;

namespace ChessBrainRespository
{
    public class SqlPostRepository : IPostRepository
    {
        ChessBrainModel context;

        public SqlPostRepository()
        {
            context = new ChessBrainModel();
        }
        // This is using your ACTUAL database, filled with real data

        public SqlPostRepository(ChessBrainModel _context)
        {
            context = _context;
        }
        // This one is used later to mock/effort and inject a database. Used later

        public ChessBrainBackEnd.Pocos.Post GetPostsById(int PostId)
        {
            return context.Posts.Find(PostId);
        }

        public ChessBrainBackEnd.Pocos.Post GetTitleById(int PostId)
        {
            return context.Posts.Find(PostId);
        }

        public ChessBrainBackEnd.Pocos.Post GetContentById(int PostId)
        {
            return context.Posts.Find(PostId);
        }

        public List<Post> GetAllPostsByUserId(int userIdArguement)
        {
            return context.Posts.Where(u => u.UserId==userIdArguement).ToList();
        }
    }
}
