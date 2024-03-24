using POObjetos.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POObjetos.ContentContext
{
    public class Course : Content
    {

        
        public Course()
        {

            Modules = new List<Module>();

        }

 
        public string Tag { get; set; }
        
        public IList<Module> Modules { get; set; }

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }




    }
}
