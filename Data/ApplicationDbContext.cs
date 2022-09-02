using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pokedex.Models;

namespace Pokedex.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        
        }
        public DbSet<Abilities> Abilities { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Generation> Generations { get; set; }
        public DbSet<Pokemons> Pokemons { get; set; }
        public DbSet<PokemonAbilities> PokemonsAbilities { get; set; }
        public DbSet<PokemonTypes> PokemonsTypes { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Weaknesses> Weaknesses { get; set; }
        

    }
}