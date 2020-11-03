using System;
using domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace infra.context
{
    public class RepositoryContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public RepositoryContext(DbContextOptions<RepositoryContext> options, IConfiguration configuration) : base(options) 
        { 
            _configuration = configuration;
        }
        public DbSet<Sensor> Sensor { get; set; }
        
        public RepositoryContext Create(Microsoft.EntityFrameworkCore.DbContextOptions options)
        {
            string CONNECTIONSTRING = _configuration.GetConnectionString("DefaultConn");

            var construtor = new DbContextOptionsBuilder<RepositoryContext>();
            construtor.UseSqlServer(CONNECTIONSTRING);
            return new RepositoryContext(construtor.Options, _configuration);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string pais = "Brasil";
            string[] regioes = {"Centro-Oeste", "Norte", "Nordeste", "Sul", "Sudeste"};
            string[] sensor = {"sensor01", "sensor02"};

            for (int i = 1; i < 100 ; i++)
            {
                modelBuilder.Entity<Sensor>().HasData(new Sensor() {
                    Id = Guid.NewGuid(),
                    timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds(),
                    tag = string.Format("{0}.{1}.{2}", pais, regioes[new Random().Next(0,4)], sensor[new Random().Next(0,1)]),
                    valor = new Random().Next(1,1000).ToString()
                });
            }
        }
    }
}