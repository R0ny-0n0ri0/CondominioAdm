using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondominioAdm.Models;

[Table("Condominios")]
public class Condominio
{
    [Key]
    public int CondominioId { get; set; }

    [StringLength(100,ErrorMessage ="O tamanho máximo é 100 caracteres")]
    [Required(ErrorMessage ="Informe o nome do Condominio")]
    [Display(Name ="Nome")]
    public string Name { get; set; }

    [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
    [Required(ErrorMessage = "Informe o Bairro do Condominio")]
    [Display(Name = "Bairo")]
    public string Bairro { get; set; }
     
    public List<Familia> Familia { get; set; }
}

