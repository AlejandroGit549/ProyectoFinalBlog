using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoBlogModelos;
using ProyectoBlogModelos.Entidades;
using ProyectoBlogReglas.ReglasEntidades;

namespace ProyectoBlogWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private readonly ILogger<AttachmentController> _logger;
        public AttachmentController(ILogger<AttachmentController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAttachments")]
        public List<ModeloAttachment>? GetAll()
        {
            List<ModeloAttachment>? modeloAttachments = new List<ModeloAttachment>();
            ModeloRespuesta respuesta = ReglasAttachment.Instancia.GetAll();
            if (!respuesta.Exito) return modeloAttachments;
            modeloAttachments = respuesta.ObtenerValorComo<List<ModeloAttachment>>();
            return modeloAttachments;
        }
    }
}
