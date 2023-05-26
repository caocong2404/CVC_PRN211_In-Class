using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinFormsApp3
{
    public class Student
    {
        public Student() 
        {
            Id = Guid.NewGuid();
            Date = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Date{ get; set; }
    }
}
