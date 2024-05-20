using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RankHorasCertificados.Models
{
    [Table("Usuario")]
    public class UsuarioModel
    {
        [Key]
        public Guid Id { get; set; }
        public int  Matricula { get; set; }
        [MaxLength(60)]
        public string Name { get; set; }
        [MaxLength(80)]
        public string Setor { get; set; }
  
    }
}
