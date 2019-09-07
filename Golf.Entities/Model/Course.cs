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
    // Course
    public partial class Course : Entity
    {
        public int CourseId { get; set; } // CourseId (Primary key)
        public string CourseName { get; set; } // CourseName
        public string Location { get; set; } // Location. Course location
        public string CourseType { get; set; } // CourseType. Real of Fictional course
        public string Designer { get; set; } // Designer. using Arnold Palmer Course Designer (APCD) or Microsoft release (MS)
        public int? DesignId { get; set; } // DesignId. LinksCorner Design Id
        public string DesignerName { get; set; } // DesignerName. Name of APCD designer
        public int? Yardage { get; set; } // Yardage. Yardage of golf course
        public int Par { get; set; } // Par. Golf course par
        public double? Difficulty { get; set; } // Difficulty. Difficulty in comparison with course par  (< 1 = easier than par; > 1 = harder than par)
        public WindConditionEnum WindCondition { get; set; } // WindCondition. Default wind condition (unless specifed in TournamentCourses table)
        public GreenSpeedEnum GreenSpeed { get; set; } // GreenSpeed. Default green speed (unless specifed in TournamentCourses table)
        public GreenHardnessEnum GreenHardness { get; set; } // GreenHardness. Default green hardness (unless specifed in TournamentCourses table)
        public PinLocationEnum PinLocation { get; set; } // PinLocation. Default pin location (unless specifed in TournamentCourses table)
        public int? PersonalRating { get; set; } // PersonalRating. personal rating as percent
        public double? UserRating { get; set; } // UserRating. LinksCorner user rating as percent
        public int? BestRoundScore { get; set; } // BestRoundScore. Personal best round

        // Reverse navigation
        public virtual ICollection<TournamentRound> TournamentRounds { get; set; } // TournamentRound.FK_TournamentRound_Course

        public Course()
        {
            Par = 72;
            WindCondition = WindConditionEnum.Breezy;
            GreenSpeed = GreenSpeedEnum.MediumChallenge;
            GreenHardness = GreenHardnessEnum.MediumChallenge;
            PinLocation = PinLocationEnum.Moderate;
            TournamentRounds = new List<TournamentRound>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
