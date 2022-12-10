using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BL
{
    public class Departamento
    {
        public static ML.Result GetByIdArea(int IdArea)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    var query = context.DepartamentoGetByIdArea(IdArea).ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var row in query)
                        {
                            ML.Departamento departamento = new ML.Departamento();

                            departamento.IdDepartamento = row.IdDepartamento;
                            departamento.Nombre = row.Nombre;

                            departamento.Area = new ML.Area();
                            departamento.Area.IdArea = IdArea;

                            result.Objects.Add(departamento); //boxing y unboxing

                        }

                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "No se ha podido realizar la consulta" + result.Ex;
            }
            return result;
        }
        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {

                    var query = context.DepartamentoGetAll().ToList();
                    result.Objects = new List<object>();
                    if (query != null)
                    {
                        foreach (var row in query)
                        {
                            ML.Departamento departamento = new ML.Departamento();

                            departamento.IdDepartamento = row.IdDepartamento;
                            departamento.Nombre = row.Nombre;

                            //tabla Area
                            departamento.Area = new ML.Area();
                            departamento.Area.IdArea = row.IdArea.Value;
                            departamento.Area.Nombre = row.AreaNombre;

                            result.Objects.Add(departamento); //boxing y unboxing

                        }
                        result.Correct = true;
                    }
                }
                //result.Correct = true;
            }//codigo que puede causar una excepcion 
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al mostrar los usuarios" + result.Ex;

            }//manejo de excepciones 

            return result;
        }
        public static ML.Result GetByIdEF(int IdDepartamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {

                    var query = context.DepartamentoGetByid(IdDepartamento).SingleOrDefault();

                    if (query != null)
                    {

                        ML.Departamento departamento = new ML.Departamento();

                        departamento.IdDepartamento = query.IdDepartamento;
                        departamento.Nombre = query.Nombre;
                        //tabla area
                        departamento.Area = new ML.Area();
                        departamento.Area.IdArea = query.IdArea.Value;

                        result.Object = departamento; //boxing y unboxing
                    }
                    result.Correct = true;
                }
                //result.Correct = true;

            }//codigo que puede causar una excepcion 
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "No se pudo mostar al usuario selecionado. " + result.Ex;

            }//manejo de excepciones 

            return result;
        }
        public static ML.Result AddEF(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    int query = context.DepartamentoAdd(departamento.Nombre, departamento.Area.IdArea);

                    if (query > 0)
                    {
                        result.Message = "Se agrago el departamento correctamente.";
                    }

                }
                result.Correct = true;
            }//codigo que puede causar una excepcion 
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "No se pudo agregar el departamento." + result.Ex;

            }//manejo de excepciones 
            return result;

        }
        public static ML.Result UpdateEF(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    var query = context.DepartamentoUpdate(departamento.IdDepartamento, departamento.Nombre, departamento.Area.IdArea);

                    if (query > 0)
                    {
                        result.Message = "Se actualizo el departamento correctamente";
                    }
                    else
                    {
                        result.Correct = false;
                    }

                }
                //}
                result.Correct = true;
            }//codigo que puede causar una excepcion 
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al actulizar el Usuario" + result.Ex;
            }//manejo de excepciones 
            return result;

        }
        public static ML.Result DeleteEF(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 contex = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    int query = contex.DepartamentoDelete(departamento.IdDepartamento);

                    if (query >= 0)
                    {
                        result.Message = "Se elimino el usuario correctamente";
                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al eliminar el Usuario" + result.Ex;
            }
            return result;
        }
    }
}

  
   

