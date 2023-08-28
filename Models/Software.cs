using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Acess_Management.Models
{
    public class Software
    {
        public int Id { get; set; }
        public string SoftName { get; set; }
        public Software(int id, string softName) {
            Id = id;
            SoftName = softName;
        }

    }
}
