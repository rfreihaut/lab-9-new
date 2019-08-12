using System;
using System.Collections.Generic;
using System.Linq;

namespace lab9080519
{
    class Program
    {
        static void Main(string[] args)
        {
            AddStudent("Dakota", "Kent City", "Pho", "Blue");
            AddStudent("Josh", "Grand Rapids", "Tortelini", "Red");
            AddStudent("Tommy", "Raleigh", "Chicken Curry", "Green");
            AddStudent("James", "Grand Rapids", "Cheese Burgers", "Red");
            AddStudent("Maricela", "Morelia", "Tacos", "Red");
            AddStudent("KimVy", "Grand Rapids", "Sushi", "Pink");
            AddStudent("Sam", "Grand Rapids", "Tacos", "Orange");
            AddStudent("Cody", "Lawton", "Potato Soup", "Yellow");
            AddStudent("Flaka", "Pristina", "Thai", "Blue");
            AddStudent("Mahruchi", "Teaneck", "Chicken Wings", "Green and White");
            AddStudent("Manik", "Cox's Bazaar", "Beef Curry", "Indigo");
            AddStudent("Moise", "Grand Rapids", "Lasagna", "Violet");
            AddStudent("Liz", "Earth", "Salmon", "Red");
            AddStudent("Jason", "Holland", "Burgers", "Orange");
            AddStudent("Bob", "Metro Detroit", "Burgers", "Maize and Blue");
            AddStudentAlphabetically();
            string studentInfo = GetInput();
            Console.WriteLine(studentInfo);
            Console.ReadKey();
        }
        public static List<Student> students = new List<Student>();


        public static void AddStudent(string name, string hometown, string favfood, string favcolor)
        {
            students.Add(new Student(name, hometown, favfood, favcolor));
        }
        public static void AddStudentAlphabetically()
        {
            students = students.OrderBy(x => x.Name).ToList();
        }
        public static string GetStudent(int index)
        {
            try
            {
                return ($"Student Name: {students[index].Name},  Hometown: {students[index].HomeTown}, Favorite Food: {students[index].FavoriteFood}, " +
                    $"Favorite Color: {students[index].FavoriteColor}");
            }
            catch (IndexOutOfRangeException)
            {
                return ("Student not found, try another index");
            }
        }
        public static void StudentList()
        {
            for (int i = 0; i < students.Count; i++)
            {
                string name = students[i].Name;
                if (name != "")
                {
                    Console.WriteLine(i + 1 + ") " + students[i].Name);
                }
            }
        }
        public static string GetInput()
        {
            StudentList();
            Console.WriteLine("Please select index of the student you want to learn about.");
            string input = Console.ReadLine();
            try
            {
                int index = int.Parse(input);
                if (students[index - 1].Name == "")
                {
                    Console.WriteLine("Student not found, try another index.");
                    return GetInput();
                }
                else
                {
                    return GetStudent(index - 1);
                }
            }
            catch (FormatException)
            {
                return GetInput();
            }
        }
        



    }

}
