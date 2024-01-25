using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object[] arr = new object[6]; 
            //arr[0] = 1859; //arr[1] = -7; 
            //arr[2] = 'g'; //arr[3] = "hello"; 
            //arr[4] = null; //arr[5] = new object(); 
            //foreach (var point in arr) 
            //{ // Console.WriteLine($"{arr}"); 
            //} //Console.ReadKey(); 
            
            
            /// <summary>
            /// создаем массив
            /// </summary> 
            
            Students[] students = new Students[2];
            /// <summary>
            /// Ввод информации о школьниках
            /// </summary> 
             
            for (int i = 0; i < students.Length; i++) 
            { Console.WriteLine($"Enter information for student {i + 1}:"); 
                Console.Write("Full name: "); string fullName = Console.ReadLine(); 
                Console.Write("Gender: "); string gender = Console.ReadLine();
                Console.Write("Birth year: "); int birthYear = int.Parse(Console.ReadLine()); 
                Console.WriteLine(); 
                students[i] = new Students(fullName, gender, birthYear); 
            } 
            
            int boysCount = Students.CountBoys(students);
            int girlsCount = Students.CountGirls(students);
            /// <summary>
            /// Подсчет количества мальчиков и девочек 
            /// </summary> 
        
            foreach (var student in students) 
            { if (student.Gender.ToLower() == "мужчина") 
                { boysCount++; } 
                else if (student.Gender.ToLower() == "женщина") 
                { girlsCount++; } }
            /// <summary>
            /// вывод каждого из списка
            /// </summary>
            Console.WriteLine($"Number of boys: {boysCount}"); 
            Console.WriteLine($"Number of girls: {girlsCount}"); 
            Console.WriteLine("\nList of boys:"); 
            foreach (var student in students) 
            { if (student.Gender.ToLower() == "мужчина") 
                { Console.WriteLine(student.FullName); } 
            } 
            Console.WriteLine("\nList of girls:"); 
            foreach (var student in students) 
            { if (student.Gender.ToLower() == "женщина") 
                { Console.WriteLine(student.FullName); } 
            } 
            Console.ReadKey(); } } }

        }
    }
}
