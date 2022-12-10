using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Colonia
    {
        public static ML.Result GetByIdMunicipio(int IdMunicipio)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    var query = context.ColoniaGetByIdMunicipio(IdMunicipio).ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var row in query)
                        {
                            ML.Colonia colonia = new ML.Colonia();

                            colonia.IdColonia = row.IdColonia;
                            colonia.Nombre = row.Nombre;
                            colonia.CodigoPostal = row.CodigoPostal;

                            colonia.Municipio = new ML.Municipio();
                            colonia.Municipio.IdMunicipio = IdMunicipio;

                            result.Objects.Add(colonia); //boxing y unboxing

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

                throw;
            }
            return result;
        }

    }
}
