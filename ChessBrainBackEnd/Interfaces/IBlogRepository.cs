using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBrainBackEnd.Pocos;


namespace ChessBrainBackEnd.Interfaces
{
    public interface IBlogRepository
    {
        void GetAllPostsByBlogId(int blogId);

        void GetIndividualPostsByBlogId(int blogId);

        

    }
}


