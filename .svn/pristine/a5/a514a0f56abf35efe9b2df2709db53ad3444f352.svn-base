namespace SelfCheckinWebApp.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SiteFeatureSwitch")]
    public partial class SiteFeatureSwitch
    {
        public int Id { get; set; }

        public int SiteId { get; set; }

        public int FeatureSwitchId { get; set; }

        public string AppMode { get; set; }

        [Required]
        public string Value { get; set; }

        public virtual Site Site { get; set; }

        public virtual FeatureSwitch FeatureSwitch { get; set; }
    }
}