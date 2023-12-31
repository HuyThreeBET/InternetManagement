namespace ManagementInternet.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Computer")]
    public partial class Computer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Computer()
        {
            Orders = new HashSet<Order>();
            PlayTimeManagements = new HashSet<PlayTimeManagement>();
        }

        public short Id { get; set; }

        public short? ComputerType { get; set; }

        public bool State { get; set; }

        [StringLength(22)]
        public string IdOfUser { get; set; }

        [StringLength(255)]
        public string StartTime { get; set; }

        public virtual ComputerType ComputerType1 { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayTimeManagement> PlayTimeManagements { get; set; }
    }
}
