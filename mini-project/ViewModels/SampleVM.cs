using System.ComponentModel.DataAnnotations;
namespace mini_project.ViewModels;

/* 
Sample ViewModel
create ViewModel class in sigle file,
pls do not create multiple viewmodel class in one file, 
this will cause confusion if you write all the thing in single file(1k lines in single file)
================================================================================================
doing like this easy for maintain and fridenly for agent tool like antigravity,claude code,codex.
Just do it like this,thanks
*/
public class SampleVM
{
    [Required]
    public int code { get; set; }
    [Required]
    [MaxLength(100)]
    public string value { get; set; }
}
