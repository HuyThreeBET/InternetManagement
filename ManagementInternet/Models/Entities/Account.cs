namespace ManagementInternet.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public short Id { get; set; }

        [Required]
        [StringLength(22)]
        public string IdCard { get; set; }

        [Required]
        [StringLength(55)]
        public string AccountName { get; set; }

        [Required]
        [StringLength(55)]
        public string Passowrd { get; set; }

        public bool Sex { get; set; }

        public byte RoleId { get; set; }

        public DateTime CreateAt { get; set; }

        public virtual Role Role { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual User User { get; set; }
    }
}
