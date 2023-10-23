using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCC2023.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome de usuário!")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        public int Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o PIN!")]
        public int Pin { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o E-mail!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do dispositivo!")]
        public string NomeDispositivo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o processador!")]
        public string Processador { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a frequencia do processador!")]
        public  int GHz { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quantidade de memoria instalada!")]
        public string Memoria { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tamanho do armazenamento de disco!")]
        public int HardDisk { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o sistema operacional instalado!")]
        public string SistemaOpoeracional { get; set; }

        [Required(ErrorMessage = "Obrigatório informar qual office instalado!")]
        public string Office { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o modelo e marca do computador!")]
        public string MarcaModelo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o numero de serie do computador!")]
        public int NumeroSerie { get; set; }

        [Required(ErrorMessage = "Obrigatório informar qual o status da máquina!")]
        public String Status { get; set; }
    }
}
