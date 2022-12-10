using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Area
    {
        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    var query = context.AreaGetAll().ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var row in query)
                        {
                            ML.Area area = new ML.Area();

                            area.IdArea = row.IdArea;
                            area.Nombre = row.Nombre;

                            result.Objects.Add(area); //boxing y unboxing

                        }
                        result.Correct = true;
                    }
                }
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
