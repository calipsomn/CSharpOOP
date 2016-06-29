using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Method | System.AttributeTargets.Interface |
                       System.AttributeTargets.Enum | System.AttributeTargets.Struct)]
    public class Version:System.Attribute
    {
        private int major;
        private int minor;

        public int Major
        {
            get { return major; }
            set { major = value; }
        }

        public int Minor
        {
            get { return minor; }
            set { minor = value; }
        }

        public Version(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }
    }
}
