using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento

        [HttpGet]
        public ActionResult GetAll()
        {
            //CONSUMO DE SERVICIO WCF EN MVC 

            ML.Departamento departamento = new ML.Departamento(); 
          /*  ML.Result result = BL.Departamento.GetAllEF();*/ 
            ServiceDepartamento1.DepartamentoClient context = new ServiceDepartamento1.DepartamentoClient();
            var result = context.GetAll();

            if (result.Correct) //validacion 
            {
                departamento.Departamentos = result.Objects.ToList();
                //departamento.Area.Areas = result.Objects;
            }
            else
            {
                ViewBag.Message = "Ocurrio un error";
            }

            return View(departamento);
        }

        [HttpGet] //muestra las vistas
        public ActionResult Form(int? IdDepartamento)
        {

            ML.Departamento departamento = new ML.Departamento(); //instancia de la clase usuario
            departamento.Area = new ML.Area(); //Objeto de la instancia



            //instancias
            ML.Result resultArea = BL.Area.GetAllEF();



            if (IdDepartamento == null) //validacion de la informacion
            {
                departamento.Area.Areas = resultArea.Objects;


                return View(departamento); //regresa a la vista
            }
            else
            {
                //GetById
                ML.Result result = BL.Departamento.GetByIdEF(IdDepartamento.Value);

                if (result.Correct)
                {
                    departamento = (ML.Departamento)result.Object;

                    departamento.Area.Areas = resultArea.Objects;

                }
                else
                {
                    ViewBag.Message = "Ocurrio un error";
                }
                return View(departamento);
            }
        }

        [HttpPost]
        public ActionResult Form(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();

            if (departamento.IdDepartamento == 0)
            {
                //ADD
                result = BL.Departamento.AddEF(departamento);
                if (result.Correct)
                {
                    ViewBag.Message = "Seagrego correctamente el departamento. " + result.Message;
                }
                else
                {
                    ViewBag.Message = "Error" + result.Message;
                }
            }
            else
            {
                //Update
                result = BL.Departamento.UpdateEF(departamento);

                if (result.Correct)
                {
                    ViewBag.Massage = "Se actualizo correctamente el departamento. " + result.Message;
                }
                else
                {
                    ViewBag.Massage = "Error: " + result.Message;
                }
            }

            return PartialView("Modal");
        }

        //[HttpDelete]
        public ActionResult Delete(ML.Departamento departamento)
        {
            ML.Result result = BL.Departamento.DeleteEF(departamento);

            if (departamento != null)
            {
                if (result.Correct)
                {
                    ViewBag.Massage = result.Message;
                }
                else
                {
                    ViewBag.Massage = "Error: " + result.Message;
                }
            }
            else
            {
                return Redirect("/Departamento/GetAll");
            }
            return PartialView("Modal");
        }

    }
}