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
    public class ReglasProfile : IOperacionesBasicas<ModeloProfile>
    {
        private static ReglasProfile? _Instancia;
        public static ReglasProfile Instancia
        {
            get
            {
                   if (_Instancia == null)
                    _Instancia = new ReglasProfile();
                   return _Instancia;
            }
        }
        private ReglasProfile()
        {
            
        }

        public ModeloRespuesta GetAll()
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Profile>(context);
                    var profiles = respositorio.GetAll();
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

                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Profile>(context);
                    var profile = respositorio.Get(Id);
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

        public ModeloRespuesta Update(ModeloProfile data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    ProyectoBlogDatos.Data.Profile profile = ConvertiGenerico.Instancia.Convert(data);
                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Profile>(context);
                    respositorio.Update(profile);
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

        public ModeloRespuesta Delete(ModeloProfile data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Profile>(context);
                    var profile = respositorio.Get(data.Id);
                    respositorio.Delete(profile);
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

        public ModeloRespuesta Add(ModeloProfile data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {
                    ProyectoBlogDatos.Data.Profile profile = ConvertiGenerico.Instancia.Convert(data);
                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Profile>(context);
                    respositorio.Add(profile);
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
