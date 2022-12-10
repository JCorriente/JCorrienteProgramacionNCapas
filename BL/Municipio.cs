using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Municipio
    {
        public static ML.Result GetByIdEstado(int IdEstado)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    var query = context.MunicipioGetByIdEstado(IdEstado).ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var row in query)
                        {
                            ML.Municipio municipio = new ML.Municipio();

                            municipio.IdMunicipio = row.IdMunicipio;
                            municipio.Nombre = row.Nombre;

                            municipio.Estado = new ML.Estado();
                            municipio.Estado.IdEstado = IdEstado;

                            result.Objects.Add(municipio); //boxing y unboxing

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

    }
}
