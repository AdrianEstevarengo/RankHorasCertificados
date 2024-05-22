using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RankHorasCertificados.Models
{
    [Table("Usuario")]
    public class UsuarioModel
    {
        public UsuarioModel()
        {
            Id = Guid.NewGuid();
            Cursos = new List<CursoModel>();
        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int Matricula { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Setor { get; set; }
        public virtual List<CursoModel> Cursos { get; set; }
       
        public int? CargaHoraria => Cursos.Sum(c => c.Duracao);
    }
}
