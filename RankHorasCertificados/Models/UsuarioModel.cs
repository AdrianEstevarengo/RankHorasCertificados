using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RankHorasCertificados.Models
{
    [Table("Usuario")]
    public class UsuarioModel
    {
        [Key]
        public Guid Id { get; set; }
        public int Matricula { get; set; }
        public string Name { get; set; }
        public string Setor { get; set; }
        public List<CursoModel> Cursos { get; set; }
    }
}
