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
    public class Usuario
    {
        public static ML.Result Add(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConexion()))
                {
                    string query = "INSERT INTO[Usuario]([Nombre],[ApellidoPaterno],[ApellidoMaterno],[FechaNacimiento],[Genero],[Email],[Password],[Telefono],[Celular],[CURP],[UserName],[IdRol])VALUES(@Nombre, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento, @Genero, @Email, @Password, @Telefono, @Celular, @CURP, @UserName, @IdRol)";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context; //conexion
                        cmd.CommandText = query; //query

                        context.Open();

                        SqlParameter[] collection = new SqlParameter[12];

                        collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                        collection[0].Value = usuario.Nombre;

                        collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                        collection[1].Value = usuario.ApellidoPaterno;

                        collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                        collection[2].Value = usuario.ApellidoMaterno;

                        collection[3] = new SqlParameter("FechaNacimiento", SqlDbType.Date);
                        collection[3].Value = usuario.FechaNacimiento;

                        collection[4] = new SqlParameter("Genero", SqlDbType.Char);
                        collection[4].Value = usuario.Genero;

                        collection[5] = new SqlParameter("Email", SqlDbType.VarChar);
                        collection[5].Value = usuario.Email;

                        collection[6] = new SqlParameter("Password", SqlDbType.VarChar);
                        collection[6].Value = usuario.Password;

                        collection[7] = new SqlParameter("Telefono", SqlDbType.VarChar);
                        collection[7].Value = usuario.Telefono;

                        collection[8] = new SqlParameter("Celular", SqlDbType.VarChar);
                        collection[8].Value = usuario.Celular;

                        collection[9] = new SqlParameter("CURP", SqlDbType.VarChar);
                        collection[9].Value = usuario.CURP;

                        collection[10] = new SqlParameter("UserName", SqlDbType.VarChar);
                        collection[10].Value = usuario.UserName;

                        collection[11] = new SqlParameter("IdRol", SqlDbType.TinyInt);
                        collection[11].Value = usuario.Rol.IdRol;

                        cmd.Parameters.AddRange(collection);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected >= 1)
                        {
                            result.Message = "Se agrego el usuario correctamente";
                        }
                    }

                }
                result.Correct = true;
            }//codigo que puede causar una excepcion 
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al insertar el Usuario" + result.Ex;
            }//manejo de excepciones 
            return result;

        }//Ya quedo

        public static ML.Result Delete(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConexion()))
                {
                    string query = "DELETE FROM Usuario WHERE Matricula = @Matricula";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context; //conexion
                        cmd.CommandText = query; //query

                        context.Open();

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("Matricula", SqlDbType.Int);
                        collection[0].Value = usuario.Matricula;

                        cmd.Parameters.AddRange(collection);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected >= 1)
                        {
                            result.Message = "Se elimino el usuario correctamente";
                        }

                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al eliminar el Usuario" + result.Ex;

                throw;
            }
            return result;
        }//ya quedo

        public static ML.Result Update(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConexion()))
                {
                    string query = "UPDATE Usuario SET[Nombre] = @Nombre,[ApellidoPaterno] = @ApellidoPaterno,[ApellidoMaterno] = @ApellidoMaterno,[FechaNacimiento] = @FechaNacimiento,[Genero]= @Genero,[Email]= @Email,[Password]=@Password,[Telefono]=@Telefono,[Celular]=@Celular,[CURP]=@CURP,[UserName]=@UserName,[IdRol]=IdRol WHERE Matricula = @Matricula";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context; //conexion
                        cmd.CommandText = query; //query

                        context.Open();

                        SqlParameter[] collection = new SqlParameter[13];

                        collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                        collection[0].Value = usuario.Nombre;

                        collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                        collection[1].Value = usuario.ApellidoPaterno;

                        collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                        collection[2].Value = usuario.ApellidoMaterno;

                        collection[3] = new SqlParameter("FechaNacimiento", SqlDbType.Date);
                        collection[3].Value = usuario.FechaNacimiento;

                        collection[4] = new SqlParameter("Genero", SqlDbType.Char);
                        collection[4].Value = usuario.Genero;

                        collection[5] = new SqlParameter("Email", SqlDbType.VarChar);
                        collection[5].Value = usuario.Email;

                        collection[6] = new SqlParameter("Password", SqlDbType.VarChar);
                        collection[6].Value = usuario.Password;

                        collection[7] = new SqlParameter("Telefono", SqlDbType.VarChar);
                        collection[7].Value = usuario.Telefono;

                        collection[8] = new SqlParameter("Celular", SqlDbType.VarChar);
                        collection[8].Value = usuario.Celular;

                        collection[9] = new SqlParameter("CURP", SqlDbType.VarChar);
                        collection[9].Value = usuario.CURP;

                        collection[10] = new SqlParameter("UserName", SqlDbType.VarChar);
                        collection[10].Value = usuario.UserName;

                        collection[11] = new SqlParameter("IdRol", SqlDbType.TinyInt);
                        collection[11].Value = usuario.Rol.IdRol;
                                                
                        collection[12] = new SqlParameter("Matricula", SqlDbType.Int);
                        collection[12].Value = usuario.Matricula;

                        cmd.Parameters.AddRange(collection);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected >= 1)
                        {
                            result.Message = "Se actualizo el usuario correctamente";
                        }
                    }

                }
                result.Correct = true;
            }//codigo que puede causar una excepcion 
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al actulizar el Usuario" + result.Ex;

                throw;
            }//manejo de excepciones 
            return result;

        }//ya quedo

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConexion()))
                {
                    string querySP = "UsuarioGetAll";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;//para conexion
                        cmd.CommandText = querySP;//para el query
                        cmd.CommandType = CommandType.StoredProcedure;//para el SP

                        context.Open();

                        DataTable usuarioTable = new DataTable();

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                        sqlDataAdapter.Fill(usuarioTable);

                        if (usuarioTable.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            foreach (DataRow row in usuarioTable.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();

                                usuario.Matricula = int.Parse(row[0].ToString());
                                usuario.Nombre = row[1].ToString();
                                usuario.ApellidoPaterno = row[2].ToString();
                                usuario.ApellidoMaterno = row[3].ToString();
                                usuario.FechaNacimiento = row[4].ToString();
                                usuario.Genero = (row[5].ToString());
                                usuario.Email= row[6].ToString();
                                usuario.Password= row[7].ToString();
                                usuario.Telefono = row[8].ToString();
                                usuario.Celular= row[9].ToString();
                                usuario.CURP= row[10].ToString();
                                usuario.UserName= row[11].ToString();

                                usuario.Rol = new ML.Rol();
                                usuario.Rol.IdRol = byte.Parse(row[12].ToString());
                               

                                result.Objects.Add(usuario); //boxing y unboxing

                            }

                        }
                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al insertar el alumno" + result.Ex;
            }
            return result;
        }//yaquedo

        public static ML.Result AddSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConexion()))
                {
                    string query = "UsuarioAdd";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context; //conexion
                        cmd.CommandText = query; //query
                        cmd.CommandType = CommandType.StoredProcedure;//para identificar que estoy utilizando SP 


                        context.Open();

                        SqlParameter[] collection = new SqlParameter[12];

                        collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                        collection[0].Value = usuario.Nombre;

                        collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                        collection[1].Value = usuario.ApellidoPaterno;

                        collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                        collection[2].Value = usuario.ApellidoMaterno;

                        collection[3] = new SqlParameter("FechaNacimiento", SqlDbType.DateTime);
                        collection[3].Value = usuario.FechaNacimiento;

                        collection[4] = new SqlParameter("Genero", SqlDbType.Char);
                        collection[4].Value = usuario.Genero;

                        collection[5] = new SqlParameter("Email", SqlDbType.VarChar);
                        collection[5].Value = usuario.Email;

                        collection[6] = new SqlParameter("Password", SqlDbType.VarChar);
                        collection[6].Value = usuario.Password;

                        collection[7] = new SqlParameter("Telefono", SqlDbType.VarChar);
                        collection[7].Value = usuario.Telefono;

                        collection[8] = new SqlParameter("Celular", SqlDbType.VarChar);
                        collection[8].Value = usuario.Celular;

                        collection[9] = new SqlParameter("CURP", SqlDbType.VarChar);
                        collection[9].Value = usuario.CURP;

                        collection[10] = new SqlParameter("UserName", SqlDbType.VarChar);
                        collection[10].Value = usuario.UserName;

                        collection[11] = new SqlParameter("IdRol", SqlDbType.TinyInt);
                        collection[11].Value = usuario.Rol.IdRol;


                        cmd.Parameters.AddRange(collection);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected >= 1)
                        {
                            result.Message = "Se agrego el usuario correctamente";
                        }
                    }

                }
                result.Correct = true;
            }//codigo que puede causar una excepcion 
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al insertar el Usuario" + result.Ex;

                throw;
            }//manejo de excepciones 
            return result;

        }//yaquedo

        public static ML.Result DeleteSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConexion()))
                {
                    string query = "DeleteSP";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context; //conexion
                        cmd.CommandText = query; //query
                        cmd.CommandType = CommandType.StoredProcedure;//para identificar que estoy utilizando SP 

                        context.Open();

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("Matricula", SqlDbType.Int);
                        collection[0].Value = usuario.Matricula;

                        cmd.Parameters.AddRange(collection);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected >= 1)
                        {
                            result.Message = "Se elimino el usuario correctamente";
                        }

                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al eliminar el Usuario" + result.Ex;

                throw;
            }
            return result;
        }//yaquedo

        public static ML.Result GetById(int Matricula)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConexion()))
                {
                    string querySP = "UsuarioGetById";


                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context; //conexion
                        cmd.CommandText = querySP; //query
                        cmd.CommandType = CommandType.StoredProcedure;//SP

                        context.Open();

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("Matricula", SqlDbType.Int);
                        collection[0].Value = Matricula;

                        cmd.Parameters.AddRange(collection);

                        DataTable usuarioTable = new DataTable();

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                        sqlDataAdapter.Fill(usuarioTable);

                        if (usuarioTable.Rows.Count > 0)
                        {
                            
                            DataRow row = usuarioTable.Rows[0];

                            ML.Usuario usuario = new ML.Usuario();

                            usuario.Matricula = int.Parse(row[0].ToString());
                            usuario.Nombre = row[1].ToString();
                            usuario.ApellidoPaterno = row[2].ToString();
                            usuario.ApellidoMaterno = row[3].ToString();
                            usuario.FechaNacimiento = row[4].ToString();
                            usuario.Genero = row[5].ToString();
                            usuario.Email = row[6].ToString();
                            usuario.Password = row[7].ToString();
                            usuario.Telefono = row[8].ToString();
                            usuario.Celular = row[9].ToString();
                            usuario.CURP = row[10].ToString();
                            usuario.UserName = row[11].ToString();

                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = byte.Parse(row[12].ToString());


                            result.Object = usuario;//boxing y unboxing

                        }

                    }

                }
                result.Correct = true;

            }//codigo que puede causar una excepcion 
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al insertar el alumno" + result.Ex;
            }//manejo de excepciones 

            return result;
        }//ya quedo

        public static ML.Result UpdateSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConexion()))
                {
                    string query = "UpdateSP";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context; //conexion
                        cmd.CommandText = query; //query
                        cmd.CommandType = CommandType.StoredProcedure;//para identificar que estoy utilizando SP

                        context.Open();

                        SqlParameter[] collection = new SqlParameter[12];

                        collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                        collection[0].Value = usuario.Nombre;

                        collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                        collection[1].Value = usuario.ApellidoPaterno;

                        collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                        collection[2].Value = usuario.ApellidoMaterno;

                        collection[3] = new SqlParameter("FechaNacimiento", SqlDbType.DateTime);
                        collection[3].Value = usuario.FechaNacimiento;

                        collection[4] = new SqlParameter("Genero", SqlDbType.Char);
                        collection[4].Value = usuario.Genero;
                                              
                        collection[5] = new SqlParameter("Email", SqlDbType.VarChar);
                        collection[5].Value = usuario.Email;

                        collection[6] = new SqlParameter("Password", SqlDbType.VarChar);
                        collection[6].Value = usuario.Password;

                        collection[7] = new SqlParameter("Telefono", SqlDbType.VarChar);
                        collection[7].Value = usuario.Telefono;

                        collection[8] = new SqlParameter("Celular", SqlDbType.VarChar);
                        collection[8].Value = usuario.Celular;

                        collection[9] = new SqlParameter("CURP", SqlDbType.VarChar);
                        collection[9].Value = usuario.CURP;

                        collection[10] = new SqlParameter("UserName", SqlDbType.VarChar);
                        collection[10].Value = usuario.UserName;

                        collection[11] = new SqlParameter("IdRol", SqlDbType.TinyInt);
                        collection[11].Value = usuario.Rol.IdRol;

                        cmd.Parameters.AddRange(collection);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected >= 1)
                        {
                            result.Message = "Se actualizo el usuario correctamente";
                        }
                    }

                }
                result.Correct = true;
            }//codigo que puede causar una excepcion 
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al actulizar el Usuario" + result.Ex;

                throw;
            }//manejo de excepciones 
            return result;

        }//yaquedo

        public static ML.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    var query = context.UsuarioAdd(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.FechaNacimiento, usuario.Genero, usuario.Email, 
                        usuario.Password, usuario.Telefono, usuario.Celular, usuario.CURP, usuario.UserName, usuario.Rol.IdRol,usuario.Imagen.ToString(),usuario.Direccion.Calle, 
                        usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior,usuario.Direccion.Colonia.IdColonia);

                    if (query > 0)
                    {
                        result.Message = "Se agrego el usuario correctamente";
                    }
                    else
                    {
                        result.Correct = false;
                        result.Message = "Ocurrio un error al insertar el Usuario" + result.Ex;
                    }
                }
                result.Correct = true;
            }//codigo que puede causar una excepcion 
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al insertar el Usuario" + result.Ex;
            }//manejo de excepciones 
            return result;

        }//
        public static ML.Result DeleteEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 contex = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    int query = contex.DeleteSP(usuario.Matricula);

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

        public static ML.Result UpdateEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    var query = context.UpdateSP(usuario.Matricula,usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno,
                        usuario.FechaNacimiento, usuario.Genero, usuario.Email, usuario.Password, usuario.Telefono, usuario.Celular, usuario.CURP, 
                        usuario.UserName,usuario.Rol.IdRol,usuario.Imagen.ToString(),usuario.Direccion.Calle,usuario.Direccion.NumeroInterior,usuario.Direccion.NumeroExterior,usuario.Direccion.Colonia.IdColonia);

                    if (query > 0)
                    {
                        result.Message = "Se actualizo el usuario correctamente";
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

        public static ML.Result GetAllEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            ML.Rol rol = new ML.Rol();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    usuario.Rol.IdRol = (byte)((usuario.Rol.IdRol == null) ? 0 : usuario.Rol.IdRol);
                    var query = context.UsuarioGetAll(usuario.Nombre,usuario.ApellidoPaterno, usuario.Rol.IdRol).ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var row in query)
                        {
                            ML.Usuario usuarioobj = new ML.Usuario();

                            usuarioobj.Matricula = row.Matricula;
                            usuarioobj.Nombre = row.Nombre;
                            usuarioobj.ApellidoPaterno = row.ApellidoPaterno;
                            usuarioobj.ApellidoMaterno = row.ApellidoMaterno;
                            usuarioobj.FechaNacimiento = row.FechaNacimiento.Value.ToString("dd-MM-yy");
                            usuarioobj.Genero = row.Genero;
                            usuarioobj.Email = row.Email;
                            usuarioobj.Password = row.Password;
                            usuarioobj.Telefono = row.Telefono;
                            usuarioobj.Celular = row.Celular;
                            usuarioobj.CURP = row.CURP;
                            usuarioobj.UserName = row.UserName;
                            //usuario.Imagen = row.Imagen;


                            usuarioobj.Rol = new ML.Rol();
                            usuarioobj.Rol.IdRol = row.IdRol.Value;
                            usuarioobj.Rol.Nombre = row.RolNombre;

                            usuarioobj.Direccion = new ML.Direccion();
                            usuarioobj.Direccion.IdDireccion = row.IdDireccion;
                            usuarioobj.Direccion.Calle = row.Calle;
                            usuarioobj.Direccion.NumeroInterior = row.NumeroInterior;
                            usuarioobj.Direccion.NumeroExterior = row.NumeroExterior;

                            usuarioobj.Direccion.Colonia = new ML.Colonia();
                            usuarioobj.Direccion.Colonia.IdColonia = row.IdColonia.Value;
                            usuarioobj.Direccion.Colonia.Nombre = row.ColoniaNombre;
                            usuarioobj.Direccion.Colonia.CodigoPostal = row.CodigoPostal;
                            usuarioobj.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuarioobj.Direccion.Colonia.Municipio.IdMunicipio = row.IdMunicipio.Value;
                            usuarioobj.Direccion.Colonia.Municipio.Nombre = row.MunicipioNombre;

                            usuarioobj.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuarioobj.Direccion.Colonia.Municipio.Estado.IdEstado = row.IdEstado.Value;
                            usuarioobj.Direccion.Colonia.Municipio.Estado.Nombre = row.EstadoNombre;

                            usuarioobj.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                            usuarioobj.Direccion.Colonia.Municipio.Estado.Pais.IdPais = row.IdPais.Value;
                            usuarioobj.Direccion.Colonia.Municipio.Estado.Pais.Nombre = row.PaisNombre;

                            result.Objects.Add(usuarioobj); //boxing y unboxing

                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.Message = "No se ha podido realizar la consulta";

                    }
                }
                //result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al insertar el alumno" + result.Ex;

            }
            return result;
        }

        public static ML.Result GetByIdEF(int Matricula)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    var query = context.UsuarioGetById(Matricula).FirstOrDefault();
                    result.Objects = new List<object>();
                    if (query != null)
                    {

                        ML.Usuario usuario = new ML.Usuario();

                        usuario.Matricula = query.Matricula;
                        usuario.Nombre = query.Nombre;
                        usuario.ApellidoPaterno = query.ApellidoPaterno;
                        usuario.ApellidoMaterno = query.ApellidoMaterno;
                        usuario.FechaNacimiento = query.FechaNacimiento.Value.ToString();
                        usuario.Genero = query.Genero;
                        usuario.Email = query.Email;
                        usuario.Password = query.Password;
                        usuario.Telefono = query.Telefono;
                        usuario.Celular = query.Celular;
                        usuario.CURP = query.CURP;
                        usuario.UserName = query.UserName;

                        usuario.Rol = new ML.Rol();
                        usuario.Rol.IdRol = query.IdRol.Value;
                        usuario.Rol.Nombre = query.Nombre;

                        usuario.Direccion = new ML.Direccion();
                        usuario.Direccion.IdDireccion = query.IdDireccion;
                        usuario.Direccion.Calle = query.Calle;
                        usuario.Direccion.NumeroInterior = query.NumeroInterior;
                        usuario.Direccion.NumeroExterior = query.NumeroExterior;

                        usuario.Direccion.Colonia = new ML.Colonia();
                        usuario.Direccion.Colonia.IdColonia = query.IdColonia.Value;
                        usuario.Direccion.Colonia.Nombre = query.ColoniaNombre;
                        usuario.Direccion.Colonia.CodigoPostal = query.CodigoPostal;

                        usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                        usuario.Direccion.Colonia.Municipio.IdMunicipio = query.IdMunicipio.Value;
                        usuario.Direccion.Colonia.Municipio.Nombre = query.MunicipioNombre;

                        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                        usuario.Direccion.Colonia.Municipio.Estado.IdEstado = query.IdEstado.Value;
                        usuario.Direccion.Colonia.Municipio.Estado.Nombre = query.EstadoNombre;

                        usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                        usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = query.IdPais.Value;
                        usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = query.PaisNombre;
                                               

                        result.Object = usuario;//boxing y unboxing

                    }

                }
                result.Correct = true;

            }//codigo que puede causar una excepcion 
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al insertar el alumno" + result.Ex;
            }//manejo de excepciones 

            return result;
        }//Ya quedo

        public static ML.Result AddLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    DL_EF.Usuario usuarioDL = new DL_EF.Usuario();

                    usuarioDL.Nombre = usuario.Nombre;
                    usuarioDL.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuarioDL.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuarioDL.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento);
                    usuarioDL.Genero = usuario.Genero;
                    usuarioDL.Email = usuario.Email;
                    usuarioDL.Password = usuario.Password;
                    usuarioDL.Telefono = usuario.Telefono;
                    usuarioDL.Celular = usuario.Celular;
                    usuarioDL.CURP = usuario.CURP;
                    usuarioDL.UserName = usuario.UserName;

                    usuarioDL.IdRol = usuario.Rol.IdRol;

                    context.Usuarios.Add(usuarioDL);
                    context.SaveChanges();

                }
                result.Correct = true;
            }//codigo que puede causar una excepcion 
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al insertar el Usuario" + result.Ex;

            }//manejo de excepciones 
            return result;

        }

        public static ML.Result DeleteLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConexion()))
                {
                    DL_EF.Usuario usuarioDL = new DL_EF.Usuario();
                                       
                    usuarioDL.Matricula = usuario.Matricula;

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

        public static ML.Result UpdateLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    DL_EF.Usuario usuarioDL = new DL_EF.Usuario();

                    usuarioDL.Nombre = usuario.Nombre;
                    usuarioDL.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuarioDL.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuarioDL.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento);
                    usuarioDL.Genero = usuario.Genero;
                    usuarioDL.Email = usuario.Email;
                    usuarioDL.Password = usuario.Password;
                    usuarioDL.Telefono = usuario.Telefono;
                    usuarioDL.Celular = usuario.Celular;
                    usuarioDL.CURP = usuario.CURP;
                    usuarioDL.UserName = usuario.UserName;
                    usuarioDL.Matricula = usuario.Matricula;

                    usuarioDL.IdRol = usuario.Rol.IdRol;

                    context.Usuarios.Add(usuarioDL);
                    context.SaveChanges();

                }
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

        public static ML.Result GetAllLINQ()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 context = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    var query = (from usuarioLINQ in context.Usuarios

                                 select new
                                 {
                                     Matricula = usuarioLINQ.Matricula,
                                     Nombre = usuarioLINQ.Nombre,
                                     ApellidoPaterno = usuarioLINQ.ApellidoPaterno,
                                     ApellidoMaterno = usuarioLINQ.ApellidoMaterno,
                                     FechaNacimiento = usuarioLINQ.FechaNacimiento,
                                     Genero = usuarioLINQ.Genero,
                                     Email = usuarioLINQ.Email,
                                     Password=usuarioLINQ.Password,
                                     Telefono=usuarioLINQ.Telefono,
                                     Celular=usuarioLINQ.Celular,
                                     CURP=usuarioLINQ.CURP,
                                     UserName=usuarioLINQ.UserName,
                                     IdRol = usuarioLINQ.IdRol

                                 });
                    if (query != null && query.ToList().Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (var row in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.Matricula = row.Matricula;
                            usuario.Nombre = row.Nombre;
                            usuario.ApellidoPaterno = row.ApellidoPaterno;
                            usuario.ApellidoMaterno = row.ApellidoMaterno;
                            usuario.FechaNacimiento = row.FechaNacimiento.Value.ToString("dd-MM-yy");
                            usuario.Genero = row.Genero;
                            usuario.Email = row.Email;
                            usuario.Password=row.Password;
                            usuario.Telefono=row.Telefono;
                            usuario.Celular=row.Celular;
                            usuario.CURP=row.CURP;
                            usuario.UserName=row.UserName;

                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = row.IdRol.Value;

                            result.Objects.Add(usuario); //boxing y unboxing

                        }

                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al insertar el Usuario" + result.Ex;
            }
            return result;
        }

        public static ML.Result GetByIdLINQ(int Matricula)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JCorrienteProgramacionNCapasEntities1 contex = new DL_EF.JCorrienteProgramacionNCapasEntities1())
                {
                    var query = (from usuarioLINQ in contex.Usuarios
                                select new
                                {
                                    Matricula = usuarioLINQ.Matricula,
                                    Nombre = usuarioLINQ.Nombre,
                                    ApellidoPaterno = usuarioLINQ.ApellidoPaterno,
                                    ApellidoMaterno = usuarioLINQ.ApellidoMaterno,
                                    FechaNacimiento = usuarioLINQ.FechaNacimiento,
                                    Genero = usuarioLINQ.Genero,
                                    Email = usuarioLINQ.Email,
                                    Password = usuarioLINQ.Password,
                                    Telefono = usuarioLINQ.Telefono,
                                    Celular = usuarioLINQ.Celular,
                                    CURP = usuarioLINQ.CURP,
                                    UserName = usuarioLINQ.UserName,
                                    IdRol = usuarioLINQ.IdRol

                                });
                    if (query != null && query.ToList().Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (var row in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.Matricula = row.Matricula;
                            usuario.Nombre = row.Nombre;
                            usuario.ApellidoPaterno = row.ApellidoPaterno;
                            usuario.ApellidoMaterno = row.ApellidoMaterno;
                            usuario.FechaNacimiento = row.FechaNacimiento.Value.ToString("dd-MM-yy");
                            usuario.Genero = row.Genero;
                            usuario.Email = row.Email;
                            usuario.Password = row.Password;
                            usuario.Telefono = row.Telefono;
                            usuario.Celular = row.Celular;
                            usuario.CURP= usuario.CURP;
                            usuario.UserName = usuario.UserName;

                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = row.IdRol.Value;

                            result.Objects.Add(usuario); //boxing y unboxing

                        }

                    }

                }
                result.Correct = true;

            }//codigo que puede causar una excepcion 
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al insertar el Usuario" + result.Ex;

            }//manejo de excepciones 

            return result;
        }


    }
}






