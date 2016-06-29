using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolroject
{
    public class StudentsClass
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public StudentsClass(string id)
        {
            this.id = id;
        }
    }
}
