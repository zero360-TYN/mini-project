namespace mini_project.Models;

using System.ComponentModel.DataAnnotations;
public class SampleEntity
{
    [Key]
    public int code { get; set; }
    public int value { get; set; }
}
