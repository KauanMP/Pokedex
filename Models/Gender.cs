using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Gender")]
    public class Gender
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }

        [Display(Name = "Nome", Prompt ="Digite o nome")]
        [Required(ErrorMessage ="Por Favor, informe o nome")]
        [StringLength(15, ErrorMessage = "O Nome deve possuir no máximo 15 caracteres")]
        public string Name { get; set; } = string.Empty;

    }
}