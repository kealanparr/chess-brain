using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ChessBrainBackEnd.Pocos
{
        public class Post
        {
            public int PostId { get; set; }

            public string Title { get; set; }

            public string Content { get; set; }

            // You are not only telling it with foreign ket UserID, but the second line is telling it where
            // to look, as well. In User User.

            public int BlogId { get; set; }

            public virtual Blog Blog { get; set; }

            // You are not only telling it with foreign ket UserID, but the second line is telling it where
                // to look, as well. In User User.

            public int UserId { get; set; }

            public virtual User User { get; set; }

        }


    
}
