using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondominioAdm.Models;

[Table("Moradores")]
public class Morador
{
    [Key]
    public int MoradorId { get; set; }

    [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
    [Required(ErrorMessage = "Informe o nome do Morador")]
    [Display(Name = "Nome")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Informe a Idade do Morador")]
    [Display(Name = "Idade")]
    public int Idade { get; set; }

    public int FamiliaId { get; set; }
    public virtual Familia Familia { get; set; }
}

