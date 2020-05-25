namespace mvc_aspnet.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public int IdCategoria { get; set; }

        public Categoria Categoria { get; set; }
    }
}