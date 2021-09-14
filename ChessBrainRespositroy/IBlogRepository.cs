using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBrainBackEnd.Pocos;

namespace ChessBrainRespository
{
       public interface IBlogRepository
        {
            List<Blog> GetAllBlogs();

            Blog GetIndividualBlogsByBlogId(int blogId);

        }
    
}
    

