
using ProyectoBlogModelos;
using ProyectoBlogModelos.Ayudantes;
using ProyectoBlogModelos.Entidades;
using ProyectoBlogReglas.Interfaces;
using ProyectoBlogReglas.Utilerias;
using ProyectoBlogRespositorio;
using System.Reflection;

namespace ProyectoBlogReglas.ReglasEntidades
{
    public class ReglasCategory : IOperacionesBasicas<ModeloCategory>
    {
        private static ReglasCategory? _Instancia;
        public static ReglasCategory Instancia
        {
            get
            {
                if (_Instancia == null)
                    _Instancia = new ReglasCategory();
                return _Instancia;
            }
        }
        private ReglasCategory()
        {
            
        }

        public ModeloRespuesta GetAll()
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Category>(context);
                    var category = respositorio.GetAll();
                    //TODO: realizar conversiòn de Entidad a DTO
                    respuesta.ActualizarRespuesta(CodigosRespuesta.Exito, MensajesRespuesta.Exito);
                }
            }
            catch (Exception)
            {
                respuesta.ActualizarRespuesta(CodigosRespuesta.Error, MensajesRespuesta.Error + " - " + this.GetType().Name + " - " + MethodBase.GetCurrentMethod()?.Name);
            }
            return respuesta;
        }

        public ModeloRespuesta Get(int Id)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Category>(context);
                    var category = respositorio.Get(Id);
                    //TODO: realizar conversiòn de Entidad a DTO
                    respuesta.ActualizarRespuesta(CodigosRespuesta.Exito, MensajesRespuesta.Exito);
                }
            }
            catch (Exception)
            {
                respuesta.ActualizarRespuesta(CodigosRespuesta.Error, MensajesRespuesta.Error + " - " + this.GetType().Name + " - " + MethodBase.GetCurrentMethod()?.Name);
            }
            return respuesta;
        }

        public ModeloRespuesta Update(ModeloCategory data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    ProyectoBlogDatos.Data.Category Category = ConvertiGenerico.Instancia.Convert(data);
                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Category>(context);
                    respositorio.Update(Category);
                    respositorio.Save();
                    respuesta.ActualizarRespuesta(CodigosRespuesta.Exito, MensajesRespuesta.Exito);
                }
            }
            catch (Exception)
            {
                respuesta.ActualizarRespuesta(CodigosRespuesta.Error, MensajesRespuesta.Error + " - " + this.GetType().Name + " - " + MethodBase.GetCurrentMethod()?.Name);
            }
            return respuesta;
        }

        public ModeloRespuesta Delete(ModeloCategory data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Category>(context);
                    var Category = respositorio.Get(data.Id);
                    respositorio.Delete(Category);
                    respositorio.Save();
                    respuesta.ActualizarRespuesta(CodigosRespuesta.Exito, MensajesRespuesta.Exito);
                }
            }
            catch (Exception)
            {
                respuesta.ActualizarRespuesta(CodigosRespuesta.Error, MensajesRespuesta.Error + " - " + this.GetType().Name + " - " + MethodBase.GetCurrentMethod()?.Name);
            }
            return respuesta;
        }

        public ModeloRespuesta Add(ModeloCategory data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {
                    ProyectoBlogDatos.Data.Category Category = ConvertiGenerico.Instancia.Convert(data);
                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Category>(context);
                    respositorio.Add(Category);
                    respositorio.Save();
                    respuesta.ActualizarRespuesta(CodigosRespuesta.Exito, MensajesRespuesta.Exito);
                }
            }
            catch (Exception)
            {
                respuesta.ActualizarRespuesta(CodigosRespuesta.Error, MensajesRespuesta.Error + " - " + this.GetType().Name + " - " + MethodBase.GetCurrentMethod()?.Name);
            }
            return respuesta;
        }

        public ModeloRespuesta GetAll(dynamic filters)
        {
            throw new NotImplementedException();
        }
    }
}
