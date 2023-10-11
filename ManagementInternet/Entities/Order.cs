namespace ManagementInternet.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            PlayTimeManagements = new HashSet<PlayTimeManagement>();
        }

        public int Id { get; set; }

        public int IdOfComputer { get; set; }

        [StringLength(255)]
        public string NameOfDish { get; set; }

        public int Quantity { get; set; }

        public int TotalAmount { get; set; }

        public DateTime CreateAt { get; set; }

        public virtual Computer Computer { get; set; }

        public virtual Dish Dish { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayTimeManagement> PlayTimeManagements { get; set; }
    }
}
