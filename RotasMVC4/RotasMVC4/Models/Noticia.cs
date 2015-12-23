using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RotasMVC4.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Categoria { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
            {
                new Noticia
                {
                    NoticiaId = 1,
                    Categoria = "Esportes", 
                    Titulo = "Felipe Massa ganha F1",
                    Conteudo = "Numa tarde de chuva Felipe Massa ganha a F1...", 
                    Data = new DateTime(2012, 7, 5)
                },
                new Noticia
                {
                    NoticiaId = 2,
                    Categoria = "Politica", 
                    Titulo = "Senado aprova PEC 266",
                    Conteudo = "Na manha dessa quarta feira no senado...", 
                    Data = new DateTime(2012, 7, 3)
                },
                new Noticia
                {
                    NoticiaId = 3,
                    Categoria = "Mundo", 
                    Titulo = "Foi descoberto a 'Arca de Noé' verdadera",
                    Conteudo = "Arqueologos alegam que os vestigios encontrados de uma...", 
                    Data = new DateTime(2012, 7, 1)
                },
                new Noticia
                {
                    NoticiaId = 4,
                    Categoria = "Esportes", 
                    Titulo = "O Tenista Gustavo Kuerten (Guga)",
                    Conteudo = "Guga ganha de virada em cima do espanhol...", 
                    Data = new DateTime(2012, 7, 1)
                },
                new Noticia
                {
                    NoticiaId = 5,
                    Categoria = "Ciência", 
                    Titulo = "Cientistas do CERN descobrem uma nova forma",
                    Conteudo = "Comunidade cientifica comemora a comprovação do ...", 
                    Data = new DateTime(2012, 7, 7)
                }
            };

            return retorno;
        }
    }
}