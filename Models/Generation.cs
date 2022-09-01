using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Generation")]
    public class Generation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }

        [Display(Name = "Nome", Prompt ="Digite o nome")]
        [Required(ErrorMessage ="Por Favor, informe o nome")]
        [StringLength(20, ErrorMessage = "O Nome deve possuir no máximo 20 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Nome", Prompt ="Digite a cor")]
        [Required(ErrorMessage ="Por Favor, informe o nome")]
        [StringLength(1, ErrorMessage = "A Mídia deve possuir no maximo 1 caracter")]
        public string midia { get; set; } = string.Empty;
    }
}