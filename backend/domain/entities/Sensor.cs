using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace domain.entities
{
    [Table("TB_Sensor")]
    public class Sensor
    {
        [Key]
        [JsonIgnore]
        public Guid Id { get; set; }

        [Required]
        [Column("TimeStamp", TypeName = "float")]
        public long timestamp { get; set; }
        
        [Required]
        [MaxLength(50)]
        [Column("Tag", TypeName = "varchar(50)")]
        public string tag { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Valor", TypeName = "varchar(50)")]
        public string valor { get; set; }

        public bool ValidObject()
        {
            return  this.timestamp > 0 && 
                    (!string.IsNullOrEmpty(this.tag) && 
                        this.tag.Split('.').Length == 3 && 
                        !this.tag.Split('.').Any(x => string.IsNullOrEmpty(x))) &&
                    !string.IsNullOrEmpty(this.valor);
        }
    }
}