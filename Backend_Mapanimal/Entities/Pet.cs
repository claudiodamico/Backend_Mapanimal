using System;
using System.ComponentModel.DataAnnotations;

namespace Backend_Mapanimal.Entities
{
    public class Pet
    {
        [Key]
        public int Id { get;  private set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get;  private set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Species")]
        public string Species { get;  private set; }

        [Required]
        [Display(Name = "Age")]
        public int Age {  get;  private set; }

        protected internal int SetId
        {
            set { Id = value; }
        }
    }
}
