using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101
{
    // Do Refactoring the following code:
    public class QuestionsAndAnswers
    {
        public QuestionsAndAnswers()
        {
        }

        // 1. Mysterious Name
        public double Max(double a, double b)
        {
            return a > b ? a : b;
        }

        // 2. Duplicate Code
        public void Print()


        {
            PrintName("Mr. Harry Potter");
            PrintName("Ms. Mary Poppin");
            PrintName("Mr. Johny Black");
        }

        private void PrintName(string name)
        {
            Console.WriteLine("***********************");
            Console.WriteLine($"   {name}");
            Console.WriteLine("***********************");
            Console.WriteLine();

        }

        // 3. Shotgun Surgery
        public static class StudentData
        {
            public const int StudentCount = 48;
        }

        public class Shotgun1
        {
            public void DisplayStudents()
            {
                Console.WriteLine("Student Count = " + StudentData.StudentCount);
            }
        }

        public class Shotgun2
        {
            public void PrintTotal()
            {
                Console.WriteLine("Total Students : " + StudentData.StudentCount);
            }
        }


        // 4. Data Clump
        public void Print(Date Date)
        {

        }
        public class Date
        {
            public required int day { get; set; }
            public required int month { get; set; }
            public required int year { get; set; }
        }




        // 5. Feature Envy
        //     จากข้อที่แล้ว น่าจะได้สร้างคลาส Date ขึ้นมา
        //     ในคลาส Date นั้นให้สร้าง method: public string Format()
        //      ปรับให้ PrintDate(...) ของเดิม ไปเรียก date.Format() ดังกล่าว
        public void PrintDate(Date Date)
        {
            Console.WriteLine($"{Date.day:00}/{Date.month:00}/{Date.year:0000}");
        }
    }
}
        
    
    
    

