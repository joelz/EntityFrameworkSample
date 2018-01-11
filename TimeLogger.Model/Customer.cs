using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLogger.Model
{
    public class Customer
    {
        public Customer()
        {
            this.Projects = new HashSet<Project>();
        }

        public Int32 CustomerId
        {
            get;
            set;
        }

        [Required]
        [MaxLength(50)]
        public String Name
        {
            get;
            set;
        }

        public virtual ICollection<Project> Projects
        {
            get;
            protected set;
        }

        public override String ToString()
        {
            return (this.Name);
        }
    }
}
