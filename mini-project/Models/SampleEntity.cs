using System.ComponentModel.DataAnnotations;
namespace mini_project.Models;
public class SampleEntity
{
    [Key]
    public int code { get; set; }
    public int value { get; set; }
}
