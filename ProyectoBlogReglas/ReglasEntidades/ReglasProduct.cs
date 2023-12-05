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
    public class ReglasProduct : IOperacionesBasicas<ModeloProduct>
    {
        private static ReglasProduct? _Instancia;
        public static ReglasProduct Instancia
        {
            get
            {
                if (_Instancia == null)
                    _Instancia = new ReglasProduct();
                return _Instancia;
            }
        }
        private ReglasProduct()
        {
            
        }

        public ModeloRespuesta GetAll()
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Product>(context);
                    var products = respositorio.GetAll();
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

                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Product>(context);
                    var product = respositorio.Get(Id);
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

        public ModeloRespuesta Update(ModeloProduct data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    ProyectoBlogDatos.Data.Product product = ConvertiGenerico.Instancia.Convert(data);
                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Product>(context);
                    respositorio.Update(product);
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

        public ModeloRespuesta Delete(ModeloProduct data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Product>(context);
                    var product = respositorio.Get(data.Id);
                    respositorio.Delete(product);
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

        public ModeloRespuesta Add(ModeloProduct data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {
                    ProyectoBlogDatos.Data.Product product = ConvertiGenerico.Instancia.Convert(data);
                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Product>(context);
                    respositorio.Add(product);
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
