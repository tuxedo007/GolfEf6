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
    // PuttChart
    public partial class PuttChart : Entity
    {
        public int PuttId { get; set; } // PuttId (Primary key)
        public int PuttLength { get; set; } // PuttLength. Length of putt (in feet)
        public int Elevation { get; set; } // Elevation. Elevation to the putt destination
        public int? SwingPercent { get; set; } // SwingPercent. The percentage of swing needed to reach the destination
        public GreenSpeedEnum GreenSpeed { get; set; } // GreenSpeed. Links2003 green condition (Slow=1, Med.=2, 3=Fast, Challenging Slow=4,Challenging Med.=5,Challenging Fast=6)
        public GreenHardnessEnum GreenHardness { get; set; } // GreenHardness. Green hardness (Slow=1, Med.=2, 3=Fast, Challenging Slow=4,Challenging Med.=5,Challenging Fast=6) enum for Links2003
        public PuttChart()
        {
            GreenSpeed = GreenSpeedEnum.MediumChallenge;
            GreenHardness = GreenHardnessEnum.MediumChallenge;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
