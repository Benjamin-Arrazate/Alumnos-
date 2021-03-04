using System;

namespace Personas
{
     class Persona
    {  
        public string name; 
        public int age; 
        public string lastname;

        public string nombrecompleto
        {
            get => this.name + " " + this.lastname;
        }

        private string coloFavorito;

        public string ColorFavorito
        {
            get => "color" + this.coloFavorito;

            set => this.coloFavorito = value;
        }
         public Persona(string name, int age, string lastname)
        {
            this.name = name;
            this.age = age;
            this.lastname= lastname; 
            
        }


        public void saludar()
        {
            Console.WriteLine("Hola! mi nombre es " + name + " " + lastname + " y tengo " + age + " anios." );
        }
    }

}