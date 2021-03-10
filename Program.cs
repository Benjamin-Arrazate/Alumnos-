using System;
using System.Collections.Generic; 

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

            Materia programacion1 = new Materia("Programacion I", 2);
            Console.WriteLine("La materia de " + programacion1.nombre + " se ve en " + programacion1.semestre);

            Materia inteligenciaArtificial = new Materia("Inteligencia Artificial", 2);
            Console.WriteLine("La materia de " + programacion1.nombre + " se ve en " + programacion1.semestre);


            List<Materia> materiasDeInteres = new List<Materia>();
            materiasDeInteres.Add(programacion1);
            materiasDeInteres.Add(inteligenciaArtificial);
            materiasDeInteres.Add(new Materia("Sistemas Interactivos I",7));

            Console.WriteLine("La materia de " + materiasDeInteres[2].nombre + " se ve en " + materiasDeInteres[2].NombreSemestre);
            Console.WriteLine("Me interesan " + materiasDeInteres.Count + " materias");

            for (int i = 0; i < materiasDeInteres.Count; i++)
            {
                Console.WriteLine(materiasDeInteres[i].nombre);
            }
            Console.WriteLine(" . . . ");
            materiasDeInteres.Remove(programacion1);
            Console.WriteLine("Me interesan " + materiasDeInteres.Count + " materias");
            Console.WriteLine("Primer Materia ahora es: " + materiasDeInteres[0].nombre);

            Materia materiaBorrar = null;
            for (int i = 0; i < materiasDeInteres.Count; i++)
            {
                if (materiasDeInteres[i].nombre == "Sistemas Interactivos I")
                {
                    materiaBorrar = materiasDeInteres[i];
                }
            }

            





            //Alumno Juan = new Alumno();
            //Juan.name = "Juan"; 
            //Juan.age = 20;
            //Juan.lastname = "Salcido";
            //Juan.Saludo();
        }
    }
}
