using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiOldConsoles.Models
{
    [Table("OldConsoles")]
    public class OldConsole
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Marca { get; set; }
        public string? Fabricante { get; set; }
        
        [Required]
        public string Categoria { get; set;}
        public string? Valor { get; set; }
        public int? Ano { get; set; }
        public string? Foto { get; set;}

        [Required]
        public string Status { get; set;}

        [Required]
        public string Condicao { get; set;}
        public string? Regiao { get; set;}
        public string? Compatibilidade { get; set;}
    }
}
