using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//comment
namespace TimeLogger.Model
{
    public class Project
    {
        public Int32 ProjectId { get; set; }

        public String Name { get; set; }

        public DateTime Start { get; set; }

        public DateTime? End { get; set; }


        public override String ToString()
        {
            return (this.Name);
        }
    }
}
