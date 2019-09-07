#region Directives
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51

#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
#endregion

namespace Golf.Entities.Model.Map
{
    // ShotHistory
    internal partial class ShotHistoryMap : EntityTypeConfiguration<ShotHistory>
    {
        public ShotHistoryMap(string schema = "dbo")
        {
            ToTable(schema + ".ShotHistory");
            HasKey(x => x.ShotId);

            Property(x => x.ShotId).HasColumnName("ShotId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Club).HasColumnName("Club").IsRequired();
            //Property(x => x.ClubName).HasColumnName("ClubName").IsOptional().HasMaxLength(10); OBSOLETE
            Property(x => x.Distance).HasColumnName("Distance").IsRequired();
            Property(x => x.Lie).HasColumnName("Lie").IsRequired();
            Property(x => x.Elevation).HasColumnName("Elevation").IsRequired();
            Property(x => x.WindDirection).HasColumnName("WindDirection").IsRequired();
            Property(x => x.WindCondition).HasColumnName("WindCondition").IsRequired();
            Property(x => x.GreenSpeed).HasColumnName("GreenSpeed").IsRequired();
            Property(x => x.GreenHardness).HasColumnName("GreenHardness").IsRequired();
            Property(x => x.SwingRatio).HasColumnName("SwingRatio").IsOptional();
            Property(x => x.Notes).HasColumnName("Notes").IsOptional().HasMaxLength(50);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
