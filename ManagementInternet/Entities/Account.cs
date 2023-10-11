namespace ManagementInternet.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1)]
        public string AccountName { get; set; }

        [Required]
        [StringLength(1)]
        public string Passowrd { get; set; }

        [Required]
        [StringLength(255)]
        public string Role { get; set; }

        public DateTime CreateAt { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual User User { get; set; }
    }
}
