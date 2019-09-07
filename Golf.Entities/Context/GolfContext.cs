#region Directives
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51

#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Golf.Entities.Model;
using Golf.Entities.Model.Map;
using Repository.Pattern.Ef6;

#endregion

namespace Golf.Entities.Context
{
    public partial class GolfContext : DataContext, IGolfContext
    {
        public IDbSet<Country> Countries { get; set; } // Country
        public IDbSet<Course> Courses { get; set; } // Course
        public IDbSet<Member> Members { get; set; } // Members
        public IDbSet<MemberStat> MemberStats { get; set; } // MemberStat
        public IDbSet<PuttHistory> PuttHistories { get; set; } // PuttHistory
        public IDbSet<ShotHistory> ShotHistories { get; set; } // ShotHistory
        public IDbSet<Tournament> Tournaments { get; set; } // Tournaments
        public IDbSet<TournamentRound> TournamentRounds { get; set; } // TournamentRound
        public IDbSet<TournamentEntry> TournamentEntries { get; set; } // TournamentEntries
        public IDbSet<PrizeDistribution> PrizeDistributions { get; set; } // PrizeDistribution

        static GolfContext()
        {
            Database.SetInitializer<GolfContext>(null);
        }

        public GolfContext()
            : base("Name=GolfDatabase")
        {
            InitializePartial();
        }
        // =============================================================================================================================
        //The following two contructors create problems for Unity IoC
        //Error: The type String cannot be constructed. You must configure the container to supply this value.
        //The key text is: 
        //Resolving parameter "connectionString" of constructor 
        //Golf.Entities.Model.GolfContext(System.String connectionString) Resolving System.String,(none)
        // =============================================================================================================================

        //public GolfContext(string connectionString)
        //    : base(connectionString)
        //{
        //    InitializePartial();
        //}
        //public GolfContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        //{
        //    InitializePartial();
        //}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new CourseMap());
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new MemberStatMap());
            modelBuilder.Configurations.Add(new PuttHistoryMap());
            modelBuilder.Configurations.Add(new ShotHistoryMap());
            modelBuilder.Configurations.Add(new TournamentMap());
            modelBuilder.Configurations.Add(new TournamentRoundMap());
            modelBuilder.Configurations.Add(new TournamentEntryMap());
            modelBuilder.Configurations.Add(new PrizeDistributionMap());
            // correcting tablename pluralization in EF
            //modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            // search for .pdf named: "edspencer.me.uk-Entity Framework  Plural and Singular Table names.pdf"
            // or go to: https://edspencer.me.uk/2012/03/13/entity-framework-plural-and-singular-table-names/
            // to see article
            // example code:
            //public class EfDbContext : DbContext
            // {
            //  public DbSet Product Products { get; set; }
            //  protected override void OnModelCreating(DbModelBuilder modelBuilder)
            //  {
            //    modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            //  }
            // }
            
            OnModelCreatingPartial(modelBuilder);
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CountryMap(schema));
            modelBuilder.Configurations.Add(new CourseMap(schema));
            modelBuilder.Configurations.Add(new MemberMap(schema));
            modelBuilder.Configurations.Add(new MemberStatMap(schema));
            modelBuilder.Configurations.Add(new PuttHistoryMap(schema));
            modelBuilder.Configurations.Add(new ShotHistoryMap(schema));
            modelBuilder.Configurations.Add(new TournamentMap(schema));
            modelBuilder.Configurations.Add(new TournamentRoundMap(schema));
            modelBuilder.Configurations.Add(new TournamentEntryMap(schema));
            modelBuilder.Configurations.Add(new PrizeDistributionMap(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(DbModelBuilder modelBuilder);
        
        // Stored Procedures
    }
}


