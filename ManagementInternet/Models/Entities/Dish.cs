namespace ManagementInternet.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dish")]
    public partial class Dish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dish()
        {
            Order = new HashSet<Order>();
        }

        [Key]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Type { get; set; }

        public short Price { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Image { get; set; }

        public bool State { get; set; }

        public virtual TypeOfDish TypeOfDish { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
