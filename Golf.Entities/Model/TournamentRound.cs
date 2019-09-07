#region Directives
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51

#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Golf.Entities.Enumerations;
using Repository.Pattern.Ef6;
#endregion

namespace Golf.Entities.Model
{
    public partial class TournamentRound : Entity
    {
        public int RoundId { get; set; } // RoundId (Primary key)
        public int TournamentId { get; set; } // TournamentId. Tournament (by TournamentId)
        public int RoundNo { get; set; } // RoundNo. Tournament round for the selected course
        public int CourseId { get; set; } // CourseId. Tournament Course used (by CourseId)
        public bool CutRound { get; set; } // CutRound. Is there a Tournament cut on this round
        public int? RemainingAfterCut { get; set; } // RemainingAfterCut
        public WindConditionEnum WindConditions { get; set; } // WindConditions. Wind conditions for round
        public GreenSpeedEnum GreenSpeed { get; set; } // GreenSpeed. Green speed for round
        public GreenHardnessEnum GreenHardness { get; set; } // GreenHardness. Green hardness for round
        public PinLocationEnum PinLocation { get; set; } // PinLocation. Pin location for round

        // Foreign keys
        public virtual Course Course { get; set; } // FK_TournamentCourses_Course
        public virtual Tournament Tournament { get; set; } // FK_TournamentCourses_Tournaments

        public TournamentRound()
        {
            CutRound = false;
            WindConditions = WindConditionEnum.Breezy;
            GreenSpeed = GreenSpeedEnum.MediumChallenge;
            GreenHardness = GreenHardnessEnum.MediumChallenge;
            PinLocation = PinLocationEnum.Moderate;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
