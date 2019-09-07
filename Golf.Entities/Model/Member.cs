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
using Repository.Pattern.Ef6;
#endregion

namespace Golf.Entities.Model
{
    // Members
    public partial class Member : Entity
    {
        public int MemberId { get; set; } // MemberId (Primary key)
        public string Lastname { get; set; } // Lastname
        public string Firstname { get; set; } // Firstname
        public string CountryName { get; set; } // Country
        public int CountryId { get; set; } // CountryId
        public int? Ranking { get; set; } // Ranking. Member field ranking for this season (to date)
        public decimal Earnings { get; set; } // Earnings. Earnings this season
        public decimal FecPoints { get; set; } // FecPoints. FedEx points awarded this season (to date)
        public int? FecRank { get; set; } // FecRank. FedEx Cup point field ranking this season (to date)
        public int CutCount { get; set; } // CutCount. Number of Tournaments the member has been cut from this season
        public int CutStreak { get; set; } // CutStreak. Number of tournaments the member has played in since the last time the player was cut from a tournament this season
        public int Wins { get; set; } // Wins. Number of tournaments the member has won
        public int TopThree { get; set; } // TopThree. Top three finishes (second ot third place only)
        public int TopTen { get; set; } // TopTen. Top ten finishes (third to tenth place only)
        public int Majors { get; set; } // Majors. The number of major tournaments the member has won (major=550 or more FedEx points)
        public int? Strokes { get; set; } // Strokes
        public decimal? Average { get; set; } // Average. Average score for the member this season
        public int RoundCount { get; set; } // RoundCount. Total rounds completed by the member this season
        public int? EntryCount { get; set; } // EntryCount. Number of tournaments the member has participated in this season (to date)
        public int? LastEvent { get; set; } // LastEvent. TournamentId of the last event the member participated in
        public bool Active { get; set; } // Active. If the member is active in a tournament currently in progress
        public bool Simulated { get; set; } // Simulated. Is this Members scoring to be simulated (when an event is simulated)
        public string ImagePath { get; set; } // ImagePath. Path to members' picture
        //public byte[] Photo { get; set; } // Photo

        // Reverse navigation
        public virtual ICollection<MemberStat> MemberStats { get; set; } // MemberStat.FK_MemberStats_Members
        public virtual ICollection<TournamentEntry> TournamentEntries { get; set; } // TournamentEntries.FK_TournamentEntries_Members

        // Foreign keys
        //public virtual Country Country_CountryId { get; set; } // FK_Members_Country
        public virtual Country Country { get; set; } // FK_Members_Country

        public Member()
        {
            CountryId = 251; //gjf this is the value i created to use Unknown zz-flag
            Earnings = 0m;
            FecPoints = 0m;
            CutCount = 0;
            CutStreak = 0;
            Wins = 0;
            TopThree = 0;
            TopTen = 0;
            Majors = 0;
            RoundCount = 0;
            EntryCount = 0;
            Active = false;
            Simulated = true;
            MemberStats = new List<MemberStat>();
            TournamentEntries = new List<TournamentEntry>();

            InitializePartial();
        }

        partial void InitializePartial();
    }

}
