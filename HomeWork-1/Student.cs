using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    internal class Student
    {
        public string name;
        public string surname;
        public int avg;
        public string Name { 
            get
            {
                return name;
            }
            set
            {
                if(char.IsUpper(value[0])) name= value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (char.IsUpper(value[0])) surname = value;
            }
        }

        public int Avg
        {
            get
            {
                return avg;
            }
            set
            {
                if(value>0 && value<=100) avg = value; 
            }
        }
    }
}
