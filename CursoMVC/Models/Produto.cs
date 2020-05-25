using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo Descrição Obrigatório")]

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public int IdCategoria { get; set; }

        public Categoria Categoria { get; set; }
    }
}