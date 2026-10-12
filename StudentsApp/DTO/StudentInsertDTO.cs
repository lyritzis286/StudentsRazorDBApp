using System.ComponentModel.DataAnnotations;

namespace StudentsApp.DTO;

public record StudentInsertDTO(
    [property: Required(ErrorMessage = "Firstname required")]
    [property: MinLength(2, ErrorMessage ="FIRSTNAME MUST CONTAIN ATLEAST 2 CHARACTERS")]
    string? Firstname,
    [property: Required(ErrorMessage = "Lastname required")]
    [property: MinLength(2, ErrorMessage ="LASTNAME MUST CONTAIN ATLEAST 2 CHARACTERS")]
    string? Lastname)
{
    public StudentInsertDTO() : this(string.Empty, string.Empty)
    {}
}
