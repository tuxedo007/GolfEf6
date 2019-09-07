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
    // PuttHistory
    public partial class PuttHistory : Entity
    {
        public int PuttId { get; set; } // PuttId (Primary key)
        public int Distance { get; set; } // Distance. Length of putt (in feet)
        public int Elevation { get; set; } // Elevation. Elevation to thr destination of the shot (in inches)
        public int? SwingRatio { get; set; } // SwingPercent. Percentage of swing (0-100)
        public GreenSpeedEnum GreenSpeed { get; set; } // GreenSpeed. Green speed (Slow=1, Med.=2, 3=Fast, Challenging Slow=4,Challenging Med.=5,Challenging Fast=6) enum for Links2003
        public GreenHardnessEnum GreenHardness { get; set; } // GreenHardness. Green hardness (Slow=1, Med.=2, 3=Fast, Challenging Slow=4,Challenging Med.=5,Challenging Fast=6) enum for Links2003
        public string Notes { get; set; } // Notes

        public PuttHistory()
        {
            Elevation = 0;
            GreenSpeed = GreenSpeedEnum.MediumChallenge;
            GreenHardness = GreenHardnessEnum.MediumChallenge;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
