namespace SelfCheckinWebApp.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserLogin")]
    public partial class UserLogin
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Application { get; set; }

        public int LoginFailCount { get; set; }

        [Column(TypeName = "date")]
        public DateTime LastFail { get; set; }
    }
}
