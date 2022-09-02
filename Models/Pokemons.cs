using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Pokemons")]
    public class Pokemons
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public uint Number { get; set; }

        [Display(Name = "Pokemon Base")]
        public uint? EvolvedFrom { get; set; }
        [ForeignKey("EnvolvedFrom")]
        [Display(Name = "Pokemon Base")]
        public Pokemons? PokemonBase { get; set; }

        [Display(Name = "Geração")]
        [Required(ErrorMessage = "Por favor, informe a Geração")]
        public uint GenerationId { get; set; }
        [ForeignKey("GenerationId")]
        public Generation Generation { get; set; } = new();


        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "Por favor, informe a o Gênero")]
        public uint GenderId { get; set; }
        [ForeignKey("GenderId")]
        public Gender Gender { get; set; } = new();

        [Display(Name = "Nome", Prompt ="Digite o nome")]
        [Required(ErrorMessage ="Por Favor, informe o nome")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Descrição", Prompt ="Digite a Descrição")]
        [StringLength(1000, ErrorMessage = "A descricção deve possuir no máximo 1000 caracteres")]
        public string? Description { get; set; }

        [Display(Name = "Altura")]
        [Required(ErrorMessage = "Por favor, informe a Altura")]
        [Column(TypeName = "decimal5,2")]

        public double height { get; set; } = 0;

        [Display(Name = "Peso")]
        [Required(ErrorMessage = "Por favor, informe o peso")]
        [Column(TypeName = "decimal7,3")]

        public double weight { get; set; } = 0;

        [Display(Name = "Imagem")]
        [StringLength(200)]

        public string? Image { get; set; }

        public ICollection<PokemonAbilities> Abilities { get; set; } = new List<PokemonAbilities>();

        public ICollection<PokemonTypes> Types { get; set; } = new List<PokemonTypes>();

        public ICollection<Weaknesses> Weaknesses { get; set; } = new List<Weaknesses>();
    }
}