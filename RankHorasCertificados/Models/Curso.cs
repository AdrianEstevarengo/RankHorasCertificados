using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RankHorasCertificados.Models
{
     [Table("Curso")]
    public class Curso
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Externo { get; set; }
        public bool Interno { get; set; }
        public int Duracao { get; set;}
        public Guid UsuarioId{ get; set; }
        public virtual UsuarioModel UsuarioModel { get; set; }
    }
}
