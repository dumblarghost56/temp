using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;
public class TaskApp{
  [Key]
  public Guid TaskId{get;set;}
  [ForeignKey("CategoryId")]
  public Guid CategoryId {get;set;}
  [Required]
  [MaxLength(200)]
  public string Title {get;set;} = "";
  [MaxLength(280)]
  public string Description {get;set;} = "";

  public Priority TaskPriority{get;set;}
  public DateTime CreateDate{get;set;}
  public virtual Category Category{get;set;}
  [NotMapped]
  public string Resumen{get;set;} = "";
}
public enum Priority{
  Baja,
  Media,
  Alta
}