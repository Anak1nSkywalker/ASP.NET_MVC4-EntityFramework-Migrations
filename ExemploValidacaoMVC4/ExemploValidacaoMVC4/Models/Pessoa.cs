using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploValidacaoMVC4.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "Nome deve ser preenchido")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "A obseração deve ter entre 5 e 50 caracteres")]
        [Required(ErrorMessage = "Preencha a observação")]
        public string Observacao { get; set; }

        [Range(18, 50, ErrorMessage = "A idade da pessoa deve ter entre 18 e 50 anos")]
        [Required(ErrorMessage = "Informe uma idade")]
        public int Idade { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "O email informado não é vãlido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "O login deve possuir somente letras e deve ter de 5 a 15 caracteres")]
        [Required(ErrorMessage = "O login deve ser preenchido")]
        [Remote("LoginUnico", "Pessoa", ErrorMessage = "Esse nome de login já existe")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A senha dever ser informada")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas não conferem")]
        public string ConfirmarSenha { get; set; } 
    }
}