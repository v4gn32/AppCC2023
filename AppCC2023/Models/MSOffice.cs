using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCC2023.Models
{
    [Table("MSOffices")]
    public class MSOffice
    {
        [Key]
        public int Id{ get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome de usuário!")]
        public string NameUsuario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o login da microsoft!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        public int Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o PIN!")]
        public int Pin { get; set; }
    
        [Required(ErrorMessage = "Obrigatório informar qual a licença do Office!")]
        public string LicencaMS { get; set; }

        [Required(ErrorMessage = "Obrigatório informar qual metodo esta cadastrado para authenticar MS!")]
        public string Authenticador { get; set; }

        [Required(ErrorMessage = "Obrigatório informar qual o status do usuário")]
        public string Status { get; set; }
    }
}
