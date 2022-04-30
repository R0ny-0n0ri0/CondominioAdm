using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondominioAdm.Models;

[Table("Familias")]
public class Familia
{
    [Key]
    public int FamiliaId { get; set; }

    [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
    [Required(ErrorMessage = "Informe o nome da Familia")]
    [Display(Name = "Nome")]

    public string Name { get; set; }

    [Required(ErrorMessage = "Informe o numero do Apto")]
    [Display(Name = "Apto")]
    public int Apto { get; set; }

    public int CondominioId { get; set; }

    public virtual Condominio Condominio { get; set; }

    public List<Morador> Morador { get; set; }



}

