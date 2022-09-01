using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Types")]
    public class Types
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }

        [Display(Name = "Nome", Prompt ="Digite o nome")]
        [Required(ErrorMessage ="Por Favor, informe o nome")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Nome", Prompt ="Digite a cor")]
        [Required(ErrorMessage ="Por Favor, informe o nome")]
        [StringLength(30, ErrorMessage = "A cor deve possuir no máximo 7 caracteres")]
        public string Color { get; set; } = string.Empty;
    }
}