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
using Repository.Pattern.Ef6;
#endregion

namespace Golf.Entities.Model
{
    // TournamentEntries
    public partial class TournamentEntry : Entity
    {
        public int EntryId { get; set; } // EntryId (Primary key)
        public int TournamentId { get; set; } // TournamentId
        public int MemberId { get; set; } // MemberId
        public int Position { get; set; } // Position
        public int? R1 { get; set; } // R1
        public int? R2 { get; set; } // R2
        public int? R3 { get; set; } // R3
        public int? R4 { get; set; } // R4
        public int? TotalStrokes { get; set; } // TotalStrokes
        public decimal Earnings { get; set; } // Earnings
        public decimal FecPoints { get; set; } // FecPoints. FedEx Cup points awarded
        public bool Cut { get; set; } // Cut. Cut from this Tournament
        public string Player { get; set; } // Player (OBSOLETE)

        // Foreign keys
        public virtual Member Member { get; set; } // FK_TournamentEntries_Members
        public virtual Tournament Tournament { get; set; } // FK_TournamentEntries_Tournaments

        public TournamentEntry()
        {
            Position = 0;
            Earnings = 0.00m;
            FecPoints = 0m;
            Cut = false;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
