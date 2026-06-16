using System.ComponentModel.DataAnnotations;

namespace BibliotecaMVC.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "O autor é obrigatório")]
        [Display(Name = "Autor")]
        public string Autor { get; set; } = string.Empty;

        [Required(ErrorMessage = "A categoria é obrigatória")]
        [Display(Name = "Categoria")]
        public string Categoria { get; set; } = string.Empty;

        [Display(Name = "Ano de Publicação")]
        public int AnoPublicacao { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; } = string.Empty;

        [Display(Name = "Disponível")]
        public bool Disponivel { get; set; } = true;

        [Display(Name = "ISBN")]
        public string ISBN { get; set; } = string.Empty;
    }
}