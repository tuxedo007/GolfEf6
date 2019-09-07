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
    // Country
    public partial class Country : Entity
    {
        public int CountryId { get; set; } // CountryId (Primary key)
        public string Name { get; set; } // Name
        public string Code2 { get; set; } // Code2
        public string Code3 { get; set; } // Code3
        public string Flag32 { get; set; } // Flag32
        public string Flag128 { get; set; } // Flag128

        // Reverse navigation
        public virtual ICollection<Member> Members { get; set; } // Members.FK_Members_Country

        public Country()
        {
            Members = new List<Member>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
