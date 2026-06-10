using System;
using System.ComponentModel.DataAnnotations;

namespace ApiEcommerce.Models.DTOs;

public class CreateCategoryDto
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    [MaxLength(50, ErrorMessage = "El nombre no puede tener mas de 50 letras")]
    [MinLength(3, ErrorMessage = "El nombre no puede tener menos de 3 letras")]
    public string Name { get; set; } = string.Empty;
}
