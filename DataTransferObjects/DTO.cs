using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects
{
    public class DTO
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptGroupName { get; set; }
        public DateTime DeptModifiedDate { get; set; }
    }
}
