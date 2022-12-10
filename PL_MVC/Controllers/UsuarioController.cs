using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PL_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [HttpGet]
        public ActionResult GetAll()
        {
            //ML.Result result = BL.Usuario.GetAllEF();
            //ML.Usuario usuario = new ML.Usuario();

            //usuario.Rol = new ML.Rol();
            //ML.Result resultRol= BL.Rol.GetAll();
            ML.Usuario usuario = new ML.Usuario();
            ML.Result result = new ML.Result();
            usuario.Rol = new ML.Rol();

            //ML.Result resultRol = BL.Rol.GetAll();
            //result = BL.Usuario.GetAllEF();
            if (result.Correct)
            {
                usuario.Usuarios = result.Objects;
            }
            else
            {
                ViewBag.Message = "Ocurrio un error al realizar la consulta de Usuario";
            }
            return View(usuario);
        }

        [HttpGet]//Muestra las vistas
        public ActionResult Form(int? Matricula)
        {
            ML.Result resultRol = BL.Rol.GetAll();
            ML.Result resultPaises = BL.Pais.GetAll();
            ML.Usuario usuario = new ML.Usuario();
          

            usuario.Rol = new ML.Rol();
            usuario.Direccion = new ML.Direccion();
            usuario.Direccion.Colonia = new ML.Colonia();
            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();


            if (Matricula == null)
            {
                usuario.Rol.Rols = resultRol.Objects;
                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPaises.Objects;
                return View(usuario);
            }
            else
            {
                //GetbyId
                ML.Result result = BL.Usuario.GetByIdEF(Matricula.Value);
             
                if (result.Correct)
                {
                    usuario = (ML.Usuario)result.Object;
                    usuario.Rol.Rols = resultRol.Objects;
                    usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPaises.Objects;

                    ML.Result resultEstados = BL.Estado.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
                    usuario.Direccion.Colonia.Municipio.Estado.Estados = resultEstados.Objects;
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al consultar el Usuario";
                }
                return View(usuario);
            }

        }
        [HttpPost]
        public ActionResult Form(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            HttpPostedFileBase file = Request.Files["ImagenData"];

            if (file.ContentLength > 0)
            {
                //usuario.Imagen = ConverToBytes(file);
            }

            if (usuario.Matricula == 0)
            {
                //Add
                result = BL.Usuario.AddEF(usuario);
                
                if (result.Correct)
                {
                    ViewBag.Message = result.Message;
                }
                else
                {
                    ViewBag.Message = "Error: " + result.Message;
                }
            }
            else
            {
                //update
                result = BL.Usuario.UpdateEF(usuario);
                if (result.Correct)
                {
                    ViewBag.Message = result.Message;
                }
                else
                {
                    ViewBag.Message = "Error " + result.Message;
                }
            }
            return View("Modal");
        }
        //DELETE
        [HttpGet]
        public ActionResult Delete(int Matricula)
        {
            ML.Result result = new ML.Result();
            
            if (result.Correct)
            {
                ViewBag.Mensaje = "Se ha elimnado el registro";
                return PartialView("Modal");
            }
            else
            {
                ViewBag.Mensaje = "No se ha elimnado el registro" + result.Message;
                return PartialView("Modal");
            }
        }
        public JsonResult GetEstado(int IdPais)
        {
            var result = BL.Estado.GetByIdPais(IdPais);

            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMunicipio(int IdEstado)
        {
            var result = BL.Municipio.GetByIdEstado(IdEstado);

            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetColonia(int IdMunicipio)
        {
            var result = BL.Municipio.GetByIdEstado(IdMunicipio);

            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetDireccion(int IdPais)
        {
            var result = BL.Municipio.GetByIdEstado(IdPais);

            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        public byte[] ConverToBytes(HttpPostedFileBase Imagen)
        {
            byte[] data = null;
            System.IO.BinaryReader reader = new System.IO.BinaryReader(Imagen.InputStream);
            data = reader.ReadBytes((int)Imagen.ContentLength);

            return data;
        }

        //function readURL(input)
        //{
        //    if (input.files && input.files[0])
        //    {
        //        var reader = new FileReader();
        //        reader.onload = function(e)
        //            {
        //            $('#ImagenPreview').attr('src', e.tarjet.result);
        //        };
        //        reader.readAsDataURL(input.files[0]);
        //    }
        //}
    }
}