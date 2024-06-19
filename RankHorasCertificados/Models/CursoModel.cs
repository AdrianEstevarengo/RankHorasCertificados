using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RankHorasCertificados.Models
{
     [Table("Curso")]
    public class CursoModel
    {
        public CursoModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; } 
        public bool Externo { get; set; }
        public bool Interno { get; set; }
        public int Duracao { get; set;}
        public Guid UsuarioId{ get; set; }
        public UsuarioModel? UsuarioModel { get; set; }
    }
}
