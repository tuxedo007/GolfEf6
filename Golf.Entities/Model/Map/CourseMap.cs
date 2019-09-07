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
    // Course
    internal partial class CourseMap : EntityTypeConfiguration<Course>
    {
        public CourseMap(string schema = "dbo")
        {
            ToTable(schema + ".Course");
            HasKey(x => x.CourseId);

            Property(x => x.CourseId).HasColumnName("CourseId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CourseName).HasColumnName("CourseName").IsRequired().HasMaxLength(255);
            Property(x => x.Location).HasColumnName("Location").IsOptional().HasMaxLength(100);
            Property(x => x.CourseType).HasColumnName("CourseType").IsOptional().IsFixedLength().HasMaxLength(10);
            Property(x => x.Designer).HasColumnName("Designer").IsOptional().IsFixedLength().HasMaxLength(10);
            Property(x => x.DesignId).HasColumnName("DesignId").IsOptional();
            Property(x => x.DesignerName).HasColumnName("DesignerName").IsOptional().HasMaxLength(50);
            Property(x => x.Yardage).HasColumnName("Yardage").IsOptional();
            Property(x => x.Par).HasColumnName("Par").IsRequired();
            Property(x => x.Difficulty).HasColumnName("Difficulty").IsOptional();
            Property(x => x.WindCondition).HasColumnName("WindCondition").IsRequired();
            Property(x => x.GreenSpeed).HasColumnName("GreenSpeed").IsRequired();
            Property(x => x.GreenHardness).HasColumnName("GreenHardness").IsRequired();
            Property(x => x.PinLocation).HasColumnName("PinLocation").IsRequired();
            Property(x => x.PersonalRating).HasColumnName("PersonalRating").IsOptional();
            Property(x => x.UserRating).HasColumnName("UserRating").IsOptional();
            Property(x => x.BestRoundScore).HasColumnName("BestRoundScore").IsOptional();

            InitializePartial();
        }
        partial void InitializePartial();
    }

}
