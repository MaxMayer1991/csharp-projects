using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class Student
    {
        public string Name { get; set; }
        public string Grade { get; set; }
        public Student(string n, string g)
        {
            this.Name = n;
            this.Grade = g;
        }
        public Student(string n)
        {
            this.Name = n;
        }
        public string finalScoreCalculate(string[] grades)
        {

            double average = 0;
            string grade = "";

            foreach (string g in grades)
            {
                average += Convert.ToDouble(g);
            }
            average = average / grades.Length;

            char answer;
            Console.Write("Is student taken an extra credit assignment(Y/N): ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                answer = Convert.ToChar(input);
                if (answer == 'Y' || answer == 'y')
                {
                    average *= 1.1;
                }
                else if (answer == 'N' || answer == 'n')
                {
                    Console.WriteLine("No extra credit added.");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                if (average >= 0 && average < 60)
                {
                    grade = $"{average}   F";
                }
                else if (average >= 60 && average < 64)
                {
                    grade = $"{average}   D-";
                }
                else if (average >= 64 && average < 67)
                {
                    grade = $"{average}   D";
                }
                else if (average >= 67 && average < 70)
                {
                    grade = $"{average}   D+";
                }
                else if (average >= 70 && average < 73)
                {
                    grade = $"{average}   C-";
                }
                else if (average >= 73 && average < 77)
                {
                    grade = $"{average}   C";
                }
                else if (average >= 77 && average < 80)
                {
                    grade = $"{average}   C+";
                }
                else if (average >= 80 && average < 83)
                {
                    grade = $"{average}   B-";
                }
                else if (average >= 83 && average < 87)
                {
                    grade = $"{average}   B";
                }
                else if (average >= 87 && average < 90)
                {
                    grade = $"{average}   B+";
                }
                else if (average >= 90 && average < 93)
                {
                    grade = $"{average}   A-";
                }
                else if (average >= 93 && average < 97)
                {
                    grade = $"{average}   A";
                }
                else if (average >= 97 && average <= 100)
                {
                    grade = $"{average}   A+";
                }
            }
            return grade;
        }
        public void displayStudentInfo(Student[] S)
        {
            Console.WriteLine("Student\t\tGrade");
            Console.WriteLine("-------\t\t-----");
            foreach (Student s in S)
            {
                Console.WriteLine($"{s.Name}\t\t{s.Grade}");
            }
        }
        static void main(string[] args)
        {

            Student[] S = new Student[5];
            S[0] = new Student("John", "90");
            S[1] = new Student("Jane", "80");
            S[2] = new Student("Jim", "70");
            S[3] = new Student("Jill", "60");

            Student student = new Student("Jack");
            string[] grades = { "90", "80", "70", "60", "50" };
            S[4] = new Student("Jack", student.finalScoreCalculate(grades));

            student.displayStudentInfo(S);
        }
    }

}
