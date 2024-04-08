using _13_Static_Interface.Extension;
using _13_Static_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Static_Interface.Models
{
    internal class Student : ICodeAcademy
    {
        static int Count = 1;
        public int Id { get; set; }
        private string _name;
        private string _surname;
        public string CodeEmail 
        { 
            get { return GenerateEmail(); }
            set { }
            
        }
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (CheckLenght(value) && CheckDigit(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Yanlisiniz var");
                }

            }
        }
        public string Surname 
        {
            get 
            {  
                return _surname; 
            }
            set
            {
                if (CheckLenght(value) && CheckDigit(value))
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Yanlisiniz var");
                }

            } 
        }

        

        public Student(string name, string surname) 
        {
            Name = name.Capitalize();
            Surname = surname.Capitalize();
            Id = Count;
            Count++;
        }

        public bool CheckLenght(string name)
        {
            if(name.Length>3 && name.Length < 21)
            {
                return true;
            }
            return false;
        }

        public bool CheckDigit(string name)
        {
            foreach (char c in name)
            {
                if (char.IsDigit(c) == true)
                {
                    return false;
                }
            }
            return true;
        }



        public string GenerateEmail()
        {
            return String.Concat(Name.ToLower(), '.', Surname.ToLower(), Id, "@code.edu.az");
        }

        public void ToSring()
        {
            Console.WriteLine($"{Id}. {Name} {Surname} - {CodeEmail}");
        }
    }
}
