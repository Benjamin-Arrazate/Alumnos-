using System;

namespace Alumnos
{


    //public class Alumno 
    //{
        //public string name; 
        //public int age;
        //public string lastname; 

        //public void Saludo()
        //{
            //Console.WriteLine("Hola! mi nombre es " + name + " " + lastname + " y tengo " + age + " anios." );
        //}
//}
    class Program
    {
        static void Main(string[] args)
        {

            Persona persona1 = new Persona("Juan", 20, "Salcido");
            {
                Console.WriteLine(persona1.nombrecompleto);


                persona1.lastname = "Ackerman";
                Console.WriteLine(persona1.nombrecompleto);


                persona1.ColorFavorito = "morado";

                persona1.saludar();
                
            }



            Alumno alumno1 = new Alumno("Jose", "Talamantes", 20, 5243, "Palmore");
            Console.WriteLine("Primer Alumno: " + alumno1.nombrecompleto);
            alumno1.saludar();





            //Alumno Juan = new Alumno();
            //Juan.name = "Juan"; 
            //Juan.age = 20;
            //Juan.lastname = "Salcido";
            //Juan.Saludo();
        }
    }
}
