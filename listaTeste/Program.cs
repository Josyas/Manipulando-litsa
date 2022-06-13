using listaTeste.Entites;
using System;
using System.Collections.Generic;

namespace listaTeste
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new();

            Console.WriteLine("Do you want to register the student? ");
            int register = int.Parse(Console.ReadLine());

            for(int i = 0; i < register; i++)
            {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Last name: ");
                string lastName = Console.ReadLine();
                list.Add(new Student(id, name, lastName));
            }

            foreach(var student in list)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Edit student registration");
            
            Console.WriteLine();
            Console.WriteLine("Name: ");
            string nameEdit = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Last name: ");
            string lastNameEdit = Console.ReadLine();

            Student studentEdit = list.Find(s => s.Name == nameEdit);
            if(studentEdit != null)
            {
                Console.Write("New name: ");
                string name = Console.ReadLine();
                studentEdit.Name = name;
            }
            else
            {
                Console.WriteLine("this name not exist!");
            }

            studentEdit = list.Find(l => l.LastName == lastNameEdit);
            if(studentEdit == null)
            {

            }

            Console.WriteLine();
            Console.WriteLine("Updated list of student!");
            foreach(var obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
