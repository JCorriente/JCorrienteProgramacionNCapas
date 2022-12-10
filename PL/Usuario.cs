using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
      public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Ingrese sus datos de Usuario");
            Console.WriteLine("Nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Fecha de Nacimiento (yyyy-MM-dd): ");
            usuario.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Genero(M-F): ");
            usuario.Genero = Console.ReadLine();
            Console.WriteLine("Email");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Password");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Telefono");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Celular");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("CURP");
            usuario.CURP = Console.ReadLine();
            Console.WriteLine("UserName");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese el Rol del Usuario: ");
            usuario.Rol = new ML.Rol();
            usuario.Rol.IdRol = byte.Parse(Console.ReadLine());


            ML.Result result = BL.Usuario.Add(usuario);//enviamos el objeto con informacion 

            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadLine();
            }
        }
      public static void Delete()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Ingrese la matricula del usuario a eliminar");
            Console.WriteLine("Matricula");
            usuario.Matricula = int.Parse(Console.ReadLine());
           

            ML.Result result = BL.Usuario.Delete(usuario);//Se envia la informacion ingresada  

            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadLine();
            }

        }
      public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Ingrese los nuevos datos del Usuario");
            Console.WriteLine("Nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Fecha de Nacimiento (yyyy-MM-dd): ");
            usuario.FechaNacimiento = (Console.ReadLine());
            Console.WriteLine("Genero(M-F): ");
            usuario.Genero = (Console.ReadLine());
            Console.WriteLine("Email");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Password");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Telefono");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Celular");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("CURP");
            usuario.CURP = Console.ReadLine();
            Console.WriteLine("UserName");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese el Rol del Usuario: ");
            usuario.Rol = new ML.Rol();
            usuario.Rol.IdRol = byte.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la matricula del usuario a cambiar los datos");
            Console.WriteLine("Matricula");
            usuario.Matricula = int.Parse(Console.ReadLine());


            ML.Result result = BL.Usuario.Update(usuario);//Se envia la informacion ingresada 

            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadLine();
            }
        }
      public static void GetAll()
        {
            ML.Result result = BL.Usuario.GetAll();

            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
                {
                    Console.WriteLine("La matricula del Usuario es:" + usuario.Matricula);
                    Console.WriteLine("El nombre del Usuario es:" + usuario.Nombre);
                    Console.WriteLine("El apellido paterno del Usuario es:" + usuario.ApellidoPaterno);
                    Console.WriteLine("El apellido materno del Usuario es:" + usuario.ApellidoMaterno);
                    Console.WriteLine("La fecha de nacimiento del Usuario es:" + usuario.FechaNacimiento);
                    Console.WriteLine("El genero del Usuario es:" + usuario.Genero);
                    Console.WriteLine("El Email del Usuario es:" + usuario.Email);
                    Console.WriteLine("El Password del Usuario es:" + usuario.Password);
                    Console.WriteLine("El Telefono del a es:" + usuario.Telefono);
                    Console.WriteLine("El Celular del Usuario es:" + usuario.Celular);
                    Console.WriteLine("El CURP del Usuario es:" + usuario.CURP);
                    Console.WriteLine("El UserName del Usuario es:" + usuario.UserName);
                    Console.WriteLine("El Rol del Usuario es:" + usuario.Rol.IdRol);
                    Console.WriteLine("----------------------------------------------------------");
                    
                }
            }
        }
      public static void AddSP()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Ingrese sus datos de Usuario");
            Console.WriteLine("Nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Fecha de Nacimiento (yyyy-MM-dd): ");
            usuario.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Genero(M-F): ");
            usuario.Genero = Console.ReadLine();
            Console.WriteLine("Email");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Password");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Telefono");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Celular");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("CURP");
            usuario.CURP = Console.ReadLine();
            Console.WriteLine("UserName");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese el Rol del Usuario: ");
            usuario.Rol = new ML.Rol();
            usuario.Rol.IdRol = byte.Parse(Console.ReadLine());


            ML.Result result = BL.Usuario.AddSP(usuario);//enviamos el objeto con informacion 

            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadLine();
            }
        }
      public static void DeleteSP()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Ingrese la matricula del usuario a eliminar");
            Console.WriteLine("Matricula");
            usuario.Matricula = int.Parse(Console.ReadLine());


            ML.Result result = BL.Usuario.DeleteSP(usuario);//Se envia la informacion ingresada  

            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadLine();
            }

        }
      public static void UpdateSP()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Ingrese los nuevos datos del Usuario");
            Console.WriteLine("Nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Fecha de Nacimiento (yyyy-MM-dd): ");
            usuario.FechaNacimiento = (Console.ReadLine());
            Console.WriteLine("Genero(M-F): ");
            usuario.Genero = (Console.ReadLine());
            Console.WriteLine("Email");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Password");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Telefono");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Celular");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("CURP");
            usuario.CURP = Console.ReadLine();
            Console.WriteLine("UserName");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese el Rol del Usuario: ");
            usuario.Rol = new ML.Rol();
            usuario.Rol.IdRol = byte.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la matricula del usuario a cambiar los datos");
            Console.WriteLine("Matricula");
            usuario.Matricula = int.Parse(Console.ReadLine());


            ML.Result result = BL.Usuario.UpdateSP(usuario);//Se envia la informacion ingresada 

            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadLine();
            }
        }
      public static void GetById()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Por favor ingrese la matricula del Usuario");
            Console.WriteLine("Matricula: ");
            usuario.Matricula = int.Parse(Console.ReadLine());
            ML.Result result = BL.Usuario.GetById(usuario.Matricula);

            if (result.Correct)
            {
                usuario = (ML.Usuario)result.Object; // unboxing 

                Console.WriteLine("El id del Usuario es:" + usuario.Matricula);
                Console.WriteLine("El nombre del Usuariio es:" + usuario.Nombre);
                Console.WriteLine("El apellido paterno del Usuario es:" + usuario.ApellidoPaterno);
                Console.WriteLine("El apellido materno del Usuario es:" + usuario.ApellidoMaterno);
                Console.WriteLine("La fecha de nacimiento del Usuario es:" + usuario.FechaNacimiento);
                Console.WriteLine("El genero del Usuario es:" + usuario.Genero);
                Console.WriteLine("El Email del Usuario es:" + usuario.Email);
                Console.WriteLine("El Password del Usuario es:" + usuario.Password);
                Console.WriteLine("El Telefono del a es:" + usuario.Telefono);
                Console.WriteLine("El Celular del Usuario es:" + usuario.Celular);
                Console.WriteLine("El CURP del Usuario es:" + usuario.CURP);
                Console.WriteLine("El UserName del Usuario es:" + usuario.UserName);
                Console.WriteLine("El Rol del Usuario es:" + usuario.Rol.IdRol);
                Console.WriteLine("----------------------------------------------------------");

            }
        }
      public static void AddEF()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Ingrese sus datos de Usuario");
            Console.WriteLine("Nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Fecha de Nacimiento (yyyy-MM-dd): ");
            usuario.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Genero(M-F): ");
            usuario.Genero = Console.ReadLine();
            Console.WriteLine("Email");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Password");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Telefono");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Celular");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("CURP");
            usuario.CURP = Console.ReadLine();
            Console.WriteLine("UserName");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese el Rol del Usuario: ");
            usuario.Rol = new ML.Rol();
            usuario.Rol.IdRol = byte.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.AddEF(usuario);//enviamos el objeto con informacion 

            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadLine();
            }
        }
      public static void DeleteEF()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Ingrese la matricula del usuario a eliminar");
            Console.WriteLine("Matricula");
            usuario.Matricula = int.Parse(Console.ReadLine());


            ML.Result result = BL.Usuario.DeleteEF(usuario);//Se envia la informacion ingresada  

            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadLine();
            }

        }
      public static void UpdateEF()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Ingrese los nuevos datos del Usuario");
            Console.WriteLine("Nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Fecha de Nacimiento (yyyy-MM-dd): ");
            usuario.FechaNacimiento = (Console.ReadLine());
            Console.WriteLine("Genero(M-F): ");
            usuario.Genero = (Console.ReadLine());
            Console.WriteLine("Ingrese la matricula del usuario a cambiar los datos");
            Console.WriteLine("Matricula");
            usuario.Matricula = int.Parse(Console.ReadLine());


            ML.Result result = BL.Usuario.UpdateEF(usuario);//Se envia la informacion ingresada 

            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadLine();
            }
        }
      public static void GetByIdEF()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Por favor ingrese la matricula del Usuario");
            Console.WriteLine("Matricula: ");
            usuario.Matricula = int.Parse(Console.ReadLine());
            ML.Result result = BL.Usuario.GetByIdEF(usuario.Matricula);

            if (result.Correct)
            {
                usuario = (ML.Usuario)result.Object; // unboxing 

                Console.WriteLine("El id del Usuario es:" + usuario.Matricula);
                Console.WriteLine("El nombre del Usuariio es:" + usuario.Nombre);
                Console.WriteLine("El apellido paterno del Usuario es:" + usuario.ApellidoPaterno);
                Console.WriteLine("El apellido materno del Usuario es:" + usuario.ApellidoMaterno);
                Console.WriteLine("La fecha de nacimiento del Usuario es:" + usuario.FechaNacimiento);
                Console.WriteLine("El genero del Usuario es:" + usuario.Genero);
                Console.WriteLine("El Email del Usuario es:" + usuario.Email);
                Console.WriteLine("El Password del Usuario es:" + usuario.Password);
                Console.WriteLine("El Telefono del a es:" + usuario.Telefono);
                Console.WriteLine("El Celular del Usuario es:" + usuario.Celular);
                Console.WriteLine("El CURP del Usuario es:" + usuario.CURP);
                Console.WriteLine("El UserName del Usuario es:" + usuario.UserName);
                Console.WriteLine("El Rol del Usuario es:" + usuario.Rol.IdRol);
                Console.WriteLine("----------------------------------------------------------");

            }
        }
      //public static void GetAllEF()
      //  {
      //      ML.Result result = BL.Usuario.GetAllEF();

      //      if (result.Correct)
      //      {
      //          foreach (ML.Usuario usuario in result.Objects)
      //          {
      //              Console.WriteLine("La matricula del Usuario es:" + usuario.Matricula);
      //              Console.WriteLine("El nombre del Usuario es:" + usuario.Nombre);
      //              Console.WriteLine("El apellido paterno del Usuario es:" + usuario.ApellidoPaterno);
      //              Console.WriteLine("El apellido materno del Usuario es:" + usuario.ApellidoMaterno);
      //              Console.WriteLine("La fecha de nacimiento del Usuario es:" + usuario.FechaNacimiento);
      //              Console.WriteLine("El genero del Usuario es:" + usuario.Genero);
      //              Console.WriteLine("El Email del Usuario es:" + usuario.Email);
      //              Console.WriteLine("El Password del Usuario es:" + usuario.Password);
      //              Console.WriteLine("El Telefono del a es:" + usuario.Telefono);
      //              Console.WriteLine("El Celular del Usuario es:" + usuario.Celular);
      //              Console.WriteLine("El CURP del Usuario es:" + usuario.CURP);
      //              Console.WriteLine("El UserName del Usuario es:" + usuario.UserName);
      //              Console.WriteLine("El Rol del Usuario es:" + usuario.Rol.IdRol);
      //              Console.WriteLine("----------------------------------------------------------");
                    
      //          }
      //      }
      //  }
      public static void AddLINQ()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Ingrese sus datos de Usuario");
            Console.WriteLine("Nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Fecha de Nacimiento (yyyy-MM-dd): ");
            usuario.FechaNacimiento = (Console.ReadLine());
            Console.WriteLine("Genero(M-F): ");
            usuario.Genero = (Console.ReadLine());

            ML.Result result = BL.Usuario.AddLINQ(usuario);//enviamos el objeto con informacion 

            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadLine();
            }
        }
      public static void DeleteLINQ()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Ingrese la matricula del usuario a eliminar");
            Console.WriteLine("Matricula");
            usuario.Matricula = int.Parse(Console.ReadLine());


            ML.Result result = BL.Usuario.DeleteLINQ(usuario);//Se envia la informacion ingresada  

            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadLine();
            }

        }
      public static void UpdateLINQ()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Ingrese los nuevos datos del Usuario");
            Console.WriteLine("Nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Fecha de Nacimiento (yyyy-MM-dd): ");
            usuario.FechaNacimiento = (Console.ReadLine());
            Console.WriteLine("Genero(M-F): ");
            usuario.Genero = (Console.ReadLine());
            Console.WriteLine("Ingrese la matricula del usuario a cambiar los datos");
            Console.WriteLine("Matricula");
            usuario.Matricula = int.Parse(Console.ReadLine());


            ML.Result result = BL.Usuario.UpdateLINQ(usuario);//Se envia la informacion ingresada 

            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadLine();
            }
        }
      public static void GetAllLINQ()
        {
            ML.Result result = BL.Usuario.GetAllLINQ();

            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
                {
                    Console.WriteLine("La matricula del Usuario es:" + usuario.Matricula);
                    Console.WriteLine("El nombre del Usuario es:" + usuario.Nombre);
                    Console.WriteLine("El apellido paterno del Usuario es:" + usuario.ApellidoPaterno);
                    Console.WriteLine("El apellido materno del Usuario es:" + usuario.ApellidoMaterno);
                    Console.WriteLine("La fecha de nacimiento del Usuario es:" + usuario.FechaNacimiento);
                    Console.WriteLine("El genero del Usuario es:" + usuario.Genero);
                    Console.WriteLine("----------------------------------------------------------");
                }
            }
        }
      public static void GetByIdLINQ()
        {
            ML.Usuario usuario = new ML.Usuario(); //Instancia

            Console.WriteLine("Por favor ingrese la matricula del Usuario");
            Console.WriteLine("Matricula: ");
            usuario.Matricula = int.Parse(Console.ReadLine());
            ML.Result result = BL.Usuario.GetByIdLINQ(usuario.Matricula);

            if (result.Correct)
            {
                usuario = (ML.Usuario)result.Object; // unboxing 

                Console.WriteLine("El id del Usuario es:" + usuario.Matricula);
                Console.WriteLine("El nombre del Usuariio es:" + usuario.Nombre);
                Console.WriteLine("El apellido paterno del Usuario es:" + usuario.ApellidoPaterno);
                Console.WriteLine("El apellido materno del Usuario es:" + usuario.ApellidoMaterno);
                Console.WriteLine("La fecha de nacimiento del Usuario es:" + usuario.FechaNacimiento);
                Console.WriteLine("El genero del Usuario es:" + usuario.Genero);
                Console.WriteLine("El Email del Usuario es:" + usuario.Email);
                Console.WriteLine("El Password del Usuario es:" + usuario.Password);
                Console.WriteLine("El Telefono del a es:" + usuario.Telefono);
                Console.WriteLine("El Celular del Usuario es:" + usuario.Celular);
                Console.WriteLine("El CURP del Usuario es:" + usuario.CURP);
                Console.WriteLine("El UserName del Usuario es:" + usuario.UserName);
                Console.WriteLine("El Rol del Usuario es:" + usuario.Rol.IdRol);
                Console.WriteLine("----------------------------------------------------------");

            }
        }

    }

}

   
