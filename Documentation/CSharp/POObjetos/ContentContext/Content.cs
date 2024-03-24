using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POObjetos.ContentContext
{
    public class Content
    {

        public Content()
        {
            Id = Guid.NewGuid(); // 
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }





    }
}
