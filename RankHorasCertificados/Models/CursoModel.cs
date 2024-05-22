using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RankHorasCertificados.Enum;

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
        public ESetor? Setor { get; set; }
        public bool Externo { get; set; }
        public bool Interno { get; set; }
        public int Duracao { get; set;}
        public Guid UsuarioId{ get; set; }
        public UsuarioModel? UsuarioModel { get; set; }
    }
}
