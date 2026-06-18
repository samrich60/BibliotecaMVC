using System.ComponentModel.DataAnnotations;

namespace BibliotecaMVC.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O usuário é obrigatório")]
        [Display(Name = "Usuário")]
        public string Usuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha é obrigatória")]
        [Display(Name = "Senha")]
        public string Senha { get; set; } = string.Empty;
    }
}