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
using System.Data.Entity;
using Golf.Entities.Model;
using Repository.Pattern.Ef6;

#endregion

namespace Golf.Entities.Context
{
    public interface IGolfContext : IDisposable
    {
        IDbSet<Country> Countries { get; set; } // Country
        IDbSet<Course> Courses { get; set; } // Course
        IDbSet<Member> Members { get; set; } // Members
        IDbSet<MemberStat> MemberStats { get; set; } // MemberStat
        IDbSet<PuttHistory> PuttHistories { get; set; } // PuttHistory
        IDbSet<ShotHistory> ShotHistories { get; set; } // ShotHistory
        IDbSet<Tournament> Tournaments { get; set; } // Tournaments
        IDbSet<TournamentEntry> TournamentEntries { get; set; } // TournamentEntry
        IDbSet<TournamentRound> TournamentRounds { get; set; } // TournamentRound
        IDbSet<PrizeDistribution> PrizeDistributions { get; set; } // PrizeDistribution
        int SaveChanges();
        
        // Stored Procedures
    }

}
