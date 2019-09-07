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
    // ShotHistory
    public partial class ShotHistory : Entity
    {
        public int ShotId { get; set; } // ShotId (Primary key)
        public ClubEnum Club { get; set; } // Club. Club as enum eg. 1iron=1, 2iron=2, etc. PW=10, SW=11, LW=12, 1W=13,etc.
        //public string ClubName { get; set; } // ClubName. Description of club (do i need along with Club enum???) OBSOLETE
        public int Distance { get; set; } // Distance. Distance in feet
        public ShotLieEmum Lie { get; set; } // Lie. Enum containing placement of the ball eg. (Fairway=1 [default=1], Sand=2, Rough=3, Fringe=4, FirstCut=5, DeepRough=7, TallGrass=8, Water=9, CartPath=10, etc.)
        public int Elevation { get; set; } // Elevation. Elevation of shot to destination (in feet)
        public WindDirectionEnum WindDirection { get; set; } // WindDirection. Wind direction as integer (0-15) with 0 meaning in your face & 8 meaning at your back
        public WindConditionEnum WindCondition { get; set; } // WindConditionEnum (1=No Wind, 2=Breezy, 3=Gusty, 4=Windy)
        public GreenSpeedEnum GreenSpeed { get; set; } // GreenSpeed. Green speed (Slow=1, Med.=2, 3=Fast, Challenging Slow=4,Challenging Med.=5,Challenging Fast=6) enum for Links2003
        public GreenHardnessEnum GreenHardness { get; set; } // GreenHardness. Green hardness (Slow=1, Med.=2, 3=Fast, Challenging Slow=4,Challenging Med.=5,Challenging Fast=6) enum for Links2003
        public int? SwingRatio { get; set; } // SwingPercent. Percentage of swing (0-100)
        public string Notes { get; set; } // Notes

        public ShotHistory()
        {
            Lie = ShotLieEmum.Fairway;
            Elevation = 0;
            WindDirection = 0;
            WindCondition = WindConditionEnum.Breezy;
            GreenSpeed = GreenSpeedEnum.MediumChallenge;
            GreenHardness = GreenHardnessEnum.MediumChallenge;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
