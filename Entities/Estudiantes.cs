

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Campus.Entities
{
    public class Estudiantes
    {
        private int cod;
        private string name;
        private string email;
        private int age;
        private string address;

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private List<int> quiz = new List<int>() {0,0,0,0};
        public List<int> Quiz
        {
            get { return quiz; }
            set { quiz = value; }
        }

        private List<int> trabajos = new List<int>() {0,0};
        public List<int> Trabajos
        {
            get { return trabajos;}
            set { trabajos = value;}
        }

        private List<int> parciales = new List<int>() {0,0,0};
        public List<int> Parciales
        {
            get { return parciales;}
            set { parciales = value;}
        }
        
        public Estudiantes()
        {

        }

        public Estudiantes(int cod, string name, string email, int age, string address, List<int> quiz, List<int> trabajos, List<int> parciales)
        {
            this.cod = cod;
            this.name = name;
            this.email = email;
            this.age = age;
            this.address = address;
            this.quiz = quiz;
            this.trabajos = trabajos;
            this.parciales = parciales;
        }

    }
}