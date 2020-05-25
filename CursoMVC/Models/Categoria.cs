using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set;}
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo Descrição Obrigatório")]

        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}