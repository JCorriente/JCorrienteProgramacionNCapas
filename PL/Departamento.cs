using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Departamento
    {
        //public static void Add()
        //{
        //    ML.Departamento departamento = new ML.Departamento(); //Instancia

        //    Console.WriteLine("Ingrese sus datos de Usuario");
        //    Console.WriteLine("Nombre");
        //    departamento.Nombre = Console.ReadLine();
        //    Console.WriteLine("Id Area");
        //    departamento.IdDepartamento = Convert.ToInt32(Console.ReadLine());


        //    ML.Result result = BL.Departamento.Add(departamento);//enviamos el objeto con informacion 

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Mensaje: " + result.Message);
        //        Console.ReadLine();
        //    }
        //}
        public static void GetAllEF()
        {
            ML.Result result = BL.Departamento.GetAllEF();

            if (result.Correct)
            {
                foreach (ML.Departamento departamento in result.Objects)
                {
                    //Console.WriteLine("La matricula del Usuario es:" + usuario.Matricula);
                    //Console.WriteLine("El nombre del Usuario es:" + usuario.Nombre);
                    //Console.WriteLine("El apellido paterno del Usuario es:" + usuario.ApellidoPaterno);
                    //Console.WriteLine("El apellido materno del Usuario es:" + usuario.ApellidoMaterno);
                    //Console.WriteLine("La fecha de nacimiento del Usuario es:" + usuario.FechaNacimiento);
                    //Console.WriteLine("El genero del Usuario es:" + usuario.Genero);
                    //Console.WriteLine("El Email del Usuario es:" + usuario.Email);
                    //Console.WriteLine("El Password del Usuario es:" + usuario.Password);
                    //Console.WriteLine("El Telefono del a es:" + usuario.Telefono);
                    //Console.WriteLine("El Celular del Usuario es:" + usuario.Celular);
                    //Console.WriteLine("El CURP del Usuario es:" + usuario.CURP);
                    //Console.WriteLine("El UserName del Usuario es:" + usuario.UserName);
                    //Console.WriteLine("El Rol del Usuario es:" + usuario.Rol.IdRol);
                    //Console.WriteLine("----------------------------------------------------------");

                }
            }
        }
    }
}
