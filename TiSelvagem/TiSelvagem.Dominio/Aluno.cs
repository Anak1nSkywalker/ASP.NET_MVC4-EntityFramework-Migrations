using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TiSelvagem.Dominio
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        [Required(ErrorMessage = "Preencha o nome do aluno")]
        public string Nome { get; set; }
        
        [DisplayName("Mãe")]
        [Required(ErrorMessage = "Preencha o nome da mãe do aluno")]
        public string Mae { get; set; }

        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Preencha a data de nascimento do aluno")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
    }
}
