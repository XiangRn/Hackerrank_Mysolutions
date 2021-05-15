using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Inheritance
{
    public class Student : Person
    {
        private int[] testScores;
        public Student(string firstName, string lastName, int identification, int[] testScores) : base(firstName, lastName, identification)
        {
            this.testScores = testScores;
        }
        public char Calculate()
        {

            double avg = Queryable.Average(testScores.AsQueryable());
           if(avg>=90 && avg <= 100)
            {
                return 'O';
            }else if(avg>=80 && avg < 90)
            {
                return 'E';
            }else if(avg>=70 && avg < 80)
            {
                return 'A';
            }
            else if (avg >= 55 && avg < 70)
            {
                return 'P';
            }
            else if (avg >=40 && avg < 55)
            {
                return 'D';
            }
            else
            {
                return 'T';
            }
        }
       
    }
}
