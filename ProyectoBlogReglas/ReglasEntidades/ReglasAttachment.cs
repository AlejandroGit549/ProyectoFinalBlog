using ProyectoBlogModelos;
using ProyectoBlogModelos.Ayudantes;
using ProyectoBlogModelos.Entidades;
using ProyectoBlogReglas.Interfaces;
using ProyectoBlogReglas.Utilerias;
using ProyectoBlogRespositorio;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ProyectoBlogReglas.ReglasEntidades
{
    public class ReglasAttachment : IOperacionesBasicas<ModeloAttachment>
    {
        private static ReglasAttachment? _Instancia;
        public static ReglasAttachment Instancia 
        { 
            get
            {
                if (_Instancia == null)
                    _Instancia = new ReglasAttachment();
                return _Instancia;
            }
        }
        private ReglasAttachment(){}

        public ModeloRespuesta Add(ModeloAttachment data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext() )
                {
                    ProyectoBlogDatos.Data.Attachment attachment = ConvertiGenerico.Instancia.Convert(data);
                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Attachment>(context);
                    respositorio.Add(attachment);
                    respositorio.Save();
                    respuesta.ActualizarRespuesta(CodigosRespuesta.Exito, MensajesRespuesta.Exito);
                }
            }
            catch (Exception)
            {
                respuesta.ActualizarRespuesta(CodigosRespuesta.Error, MensajesRespuesta.Error + " - "+ this.GetType().Name + " - "+ MethodBase.GetCurrentMethod()?.Name);
            }
            return respuesta;
        }

        public ModeloRespuesta Delete(ModeloAttachment data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {
                    
                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Attachment>(context);
                    var attachment = respositorio.Get(data.Id);
                    respositorio.Delete(attachment);
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
        public ModeloRespuesta Update(ModeloAttachment data)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {
                    ProyectoBlogDatos.Data.Attachment attachment = ConvertiGenerico.Instancia.Convert(data);
                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Attachment>(context);
                    respositorio.Update(attachment);
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
        public ModeloRespuesta Get(int Id)
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {
                  
                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Attachment>(context);
                    var attachment = respositorio.Get(Id);
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

        public ModeloRespuesta GetAll()
        {
            ModeloRespuesta respuesta = new ModeloRespuesta();
            List<ModeloAttachment> modeloAttachments = new List<ModeloAttachment>();
            try
            {
                using (ProyectoBlogDatos.Data.BlogContext context = new ProyectoBlogDatos.Data.BlogContext())
                {

                    var respositorio = new RepositorioGenerico<ProyectoBlogDatos.Data.Attachment>(context);
                    var attachments = respositorio.GetAll();
                    //TODO: realizar conversiòn de Entidad a DTO

                    foreach (var attachment in attachments)
                    {
                        modeloAttachments.Add(new ModeloAttachment()
                        {
                            Id = attachment.Id,
                            Name = attachment.Name,
                            Description = attachment.Description,
                            Url = attachment.Url
                        });
                    }

                    respuesta.ActualizarRespuesta(CodigosRespuesta.Exito, MensajesRespuesta.Exito, modeloAttachments);
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
