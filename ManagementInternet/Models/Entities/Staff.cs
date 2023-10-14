namespace ManagementInternet.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IdOfStaff { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        public DateTime DayOfBirth { get; set; }

        public bool State { get; set; }

        public DateTime DayOfWork { get; set; }

        public DateTime DayOff { get; set; }

        public virtual Account Account { get; set; }
    }
}
