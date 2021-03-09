using System;

namespace Alumnos 
{
    class Alumno : Persona
    {

        public int matricula; 
        static public string escuela = "CRESP"; 
        public Alumno (string nombre, string apellido, int edad, int matricula, string escuela) : base(nombre, edad, apellido)
        {
            this.matricula = matricula;

        }


        public override void saludar()
        {
            Console.WriteLine("Hola, mi nombre es " + this.nombrecompleto + " y soy estudiante en " + Alumno.escuela + " con matrticula " + this.matricula);
        }
    }    
}