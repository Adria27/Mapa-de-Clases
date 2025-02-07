using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadEducativa
{
    // aqui esta la clase principal// 
    public class ColegioFeYAlegria
    {
        public string NombreColegio { get; set; } 
        public string Direccion { get; set; } 
        public int AñoFundacion { get; set; } 
    }

    // Clase base para miembros de la comunidad educativa//
    public class MiembroDeLaComunidad : ColegioFeYAlegria
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    public class Empleado : MiembroDeLaComunidad
    {
        public string Departamento { get; set; }
        public int HorasDeTrabajo { get; set; }
        public decimal Sueldo { get; set; }
    }

    public class Docente : Empleado
    {
        public string Materia { get; set; }
    }

    public class Administrativo : Empleado
    {
        public string Puesto { get; set; }
    }

    public class Administrador : Empleado  
    {
        public int NumeroDeEmpleados { get; set; }
    }

    public class Maestro : Docente
    {
        public int HorasClase { get; set; }
        public string Diploma { get; set; }
        public string HorarioDeClases { get; set; }
    }

    public class Estudiante : MiembroDeLaComunidad
    {
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public int AñosCursados { get; set; }  
        public string HorarioDeClase { get; set; }
    }

    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AñoGraduacion { get; set; } 
        public string TituloUniversitario { get; set; }
    }

    class Program
    {
        static void Main()
        {


            //instancia//
            Estudiante estudiante = new() 
            {
                Nombre = "Adrian",
                Edad = 21,
                Matricula = "20231246",
                Carrera = "Ingeniería",
                AñosCursados = 3, 
                HorarioDeClase = "9:00am - 12:00"
            };

            // datos de salida son solos del estudiante, no sabia si habia que poner imprimir o no //
            Console.WriteLine("Datos del Estudiante:");

            Console.WriteLine($"Nombre: {estudiante.Nombre}");

            Console.WriteLine($"Edad: {estudiante.Edad} años");

            Console.WriteLine($"Matrícula: {estudiante.Matricula}");

            Console.WriteLine($"Carrera: {estudiante.Carrera}");

            Console.WriteLine($"Años Cursados: {estudiante.AñosCursados}");

            Console.WriteLine($"Horario de Clase: {estudiante.HorarioDeClase}");
        }
    }
}
