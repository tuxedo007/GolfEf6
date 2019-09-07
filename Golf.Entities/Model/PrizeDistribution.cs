#region Directives
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51

#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Collections.Generic;
using Golf.Entities.Enumerations;
using Repository.Pattern.Ef6;
#endregion

namespace Golf.Entities.Model
{
    // PrizeDistribution
    public partial class PrizeDistribution : Entity
    {
        public int PrizeId { get; set; } // PrizeId (Primary key)
        public int Position { get; set; } // Position
        public TournamentCategoryEnum Category { get; set; } // Category. Category for the level of the event (1=Playoff,2=Major,3=WGC,4=FEC Standard,5=FEC Minor, 6=Non FEC (Other) [TouramentCategoryEnum value]
        public decimal FecPoints { get; set; } // FecPoints
        public decimal DistributionPercentage { get; set; } // DistributionPercentage
    }

}
