using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Acess_Management.Models
{
    public class manager
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public manager(int manId, string manName) {
            this.Id = manId;
            this.Name = manName;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
