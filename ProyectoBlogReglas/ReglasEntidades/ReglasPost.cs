using ProyectoBlogModelos;
using ProyectoBlogModelos.Ayudantes;
using ProyectoBlogModelos.Entidades;
using ProyectoBlogReglas.Interfaces;
using ProyectoBlogReglas.Utilerias;
using ProyectoBlogRespositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlogReglas.ReglasEntidades
{
    public  class ReglasPost:IOperacionesBasicas<ModeloPost>
    {
        private static ReglasPost? _instance;
        public static ReglasPost Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ReglasPost();
                return _instance;
            }
        }
        private ReglasPost()
        {
            
        }

        public ModeloRespuesta GetAll()
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Post>(context);
                    var posts = respositorio.GetAll();
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

                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Post>(context);
                    var post = respositorio.Get(Id);
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

        public ModeloRespuesta Update(ModeloPost data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    ProyectoBlogDatos.Data.Post post = ConvertiGenerico.Instancia.Convert(data);
                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Post>(context);
                    respositorio.Update(post);
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

        public ModeloRespuesta Delete(ModeloPost data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Post>(context);
                    var post = respositorio.Get(data.Id);
                    respositorio.Delete(post);
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

        public ModeloRespuesta Add(ModeloPost data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {
                    ProyectoBlogDatos.Data.Post post = ConvertiGenerico.Instancia.Convert(data);
                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Post>(context);
                    respositorio.Add(post);
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
