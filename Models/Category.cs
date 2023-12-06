using System.ComponentModel.DataAnnotations;

namespace Models;
public class Category{
  [Key]
  public Guid Id {get;set;}
  [Required]
  [MaxLength(180)]
  public string Name {get;set;} = "";
  [MaxLength(280)]
  public string Description {get;set;} = "";
  public ICollection<TaskApp> Tasks {get;set;}

}