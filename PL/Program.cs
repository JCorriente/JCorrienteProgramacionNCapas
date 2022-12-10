using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Elige una opcion: ");
                Console.WriteLine("\n1.-Agregar un Usuario: " + "\n2.-Eliminar un Usuario: " + "\n3.-Actualizar datos de un Usuario:"+ "\n4.-GetAll" +"\n5.-AddSP" +"\n6.-DeleteSP"+"\n7.UpdateSP"+"\n8.-GetById"+"\n9.-AddEF"+"\n10.-DeleteEF"+"\n11.-UpdateEF"+"\n12.-GetByIdEF"+"\n13.-GetAllEF");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Usuario.Add();
                        break;
                    case 2:
                        Usuario.Delete();
                        break;
                    case 3:
                        Usuario.Update();
                        break;
                    case 4:
                        Usuario.GetAll();
                        break;
                    case 5:
                        Usuario.AddSP();
                        break;
                    case 6: 
                        Usuario.DeleteSP();
                        break;
                    case 7:
                        Usuario.UpdateSP();
                        break;
                    case 8:
                        Usuario.GetById();
                        break;
                    case 9:
                        Usuario.AddEF();
                        break;
                    case 10:
                        Usuario.DeleteEF();
                        break;
                    case 11:
                        Usuario.UpdateEF();
                        break;
                    case 12:
                        Usuario.GetByIdEF();
                        break;
                    //case 13:
                    //    Usuario.GetAllEF();
                    //    break;
                    case 14:
                        Usuario.AddLINQ();
                        break;
                }
                Console.ReadKey();
            } while (opcion !=15);
        }
    }
}
