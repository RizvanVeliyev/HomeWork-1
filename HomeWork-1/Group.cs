using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    internal class Group
    {
        public int stLimit;
        public string[] arr = { };
        public static void AddStudent()
        {
            Student student = new Student();
            Console.Write("adi daxil edin:");
            student.Name = Console.ReadLine();
            Console.Write("soyadi daxil edin:");
            student.Surname = Console.ReadLine();
            Console.Write("ortalamani daxil edin: ");
            student.Avg = int.Parse(Console.ReadLine());
            arr.Resize()
            arr[no] += student.Name;
        }

        public int No { get; set; }

        public int StLimit { 
            get
            {
                return stLimit;
            } 
            set 
            {
                if(value >5 && value<18) this.stLimit= value;
            } 
        }
    }
}
