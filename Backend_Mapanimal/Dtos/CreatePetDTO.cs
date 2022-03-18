using System.ComponentModel.DataAnnotations;

namespace Backend_Mapanimal.Dtos
{
    public class CreatePetDTO
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; private set; }
    }
}
