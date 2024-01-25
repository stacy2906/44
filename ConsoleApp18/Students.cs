﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Students
    {
         public string FullName;

        public string Gender;

        public int BirthYear;



        public Students(string fullName, string gender, int birthYear)

        {

            FullName = fullName;

            Gender = gender;

            BirthYear = birthYear;
        }
        
        public static int CountBoys(Student[] students)
    {
        int count = 0;
        foreach (Student kid in students)
        {
            if (kid.Gender == 'Мужчина')
            {
                count++;
            }
        }
        return count;
    }

    public static int CountGirls(Student[] students)
    {
        int count = 0;
        foreach (Student kid in students)
        {
            if (kid.Gender == 'Женщина')
            {
                count++;
            }
        }
        return count;
    }
    }
}
