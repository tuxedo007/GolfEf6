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
    // PuttChart
    internal partial class PuttChartMap : EntityTypeConfiguration<PuttChart>
    {
        public PuttChartMap(string schema = "dbo")
        {
            ToTable(schema + ".PuttChart");
            HasKey(x => x.PuttId);

            Property(x => x.PuttId).HasColumnName("PuttId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PuttLength).HasColumnName("PuttLength").IsRequired();
            Property(x => x.Elevation).HasColumnName("Elevation").IsRequired();
            Property(x => x.SwingPercent).HasColumnName("SwingPercent").IsOptional();
            Property(x => x.GreenSpeed).HasColumnName("GreenCondition").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
