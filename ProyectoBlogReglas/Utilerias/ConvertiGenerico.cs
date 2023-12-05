using ProyectoBlogDatos.Data;
using ProyectoBlogModelos.Entidades;
using ProyectoBlogReglas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBlogReglas.Utilerias
{
    public class ConvertiGenerico : IConvertirGenerico<ModeloAttachment, Attachment>, IConvertirGenerico<ModeloAttachmentsPost,AttachmentsPost >, IConvertirGenerico<ModeloCategory, Category>
    , IConvertirGenerico<ModeloComment, Comment>, IConvertirGenerico<ModeloPost, Post>, IConvertirGenerico<ModeloProduct, Product>, IConvertirGenerico<ModeloProfile, Profile>
        , IConvertirGenerico<ModeloUser, User>, IConvertirGenerico<ModeloUserinfo, Userinfo>
    {

        private static ConvertiGenerico? _Instancia;
        public static ConvertiGenerico Instancia
        {
            get
            {
                if (_Instancia == null)
                    _Instancia = new ConvertiGenerico();
                return _Instancia;
            }
        }


        public Attachment Convert(ModeloAttachment obj)
        {
            throw new NotImplementedException();
        }

        public AttachmentsPost Convert(ModeloAttachmentsPost obj)
        {
            throw new NotImplementedException();
        }

        public Category Convert(ModeloCategory obj)
        {
            throw new NotImplementedException();
        }

        public Comment Convert(ModeloComment obj)
        {
            throw new NotImplementedException();
        }

        public Post Convert(ModeloPost obj)
        {
            throw new NotImplementedException();
        }

        public Product Convert(ModeloProduct obj)
        {
            throw new NotImplementedException();
        }

        public Profile Convert(ModeloProfile obj)
        {
            throw new NotImplementedException();
        }

        public User Convert(ModeloUser obj)
        {
            throw new NotImplementedException();
        }

        public Userinfo Convert(ModeloUserinfo obj)
        {
            throw new NotImplementedException();
        }
    }
}
