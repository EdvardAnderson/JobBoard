using System.ComponentModel.DataAnnotations;

namespace JobBoard.API.Models;

public class CompanyForUpdateDto
{
    [Required(ErrorMessage = "You must provide a name.")]
    [MaxLength(100)]
    public string Name { get; set; }

    public string Address { get; set; }
}
