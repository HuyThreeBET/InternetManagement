namespace ManagementInternet.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepositHistory")]
    public partial class DepositHistory
    {
        public int Id { get; set; }

        [StringLength(22)]
        public string IdOfUser { get; set; }

        public int DepositAmount { get; set; }

        public DateTime CreateAt { get; set; }

        public virtual User User { get; set; }
    }
}
