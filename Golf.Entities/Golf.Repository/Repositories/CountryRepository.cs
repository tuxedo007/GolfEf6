#region DirectivesCourse
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
using System.Collections.Generic;
using System.Linq;
using Golf.Entities.Model;
using Repository.Pattern.Repositories;

#endregion (Directives)

namespace Golf.Repository.Repositories
{
    public static class CountryRepository
    {
        #region Static Context

        //private static readonly GearContext dc = new GearContext();

        #endregion (Static Context)

        #region IEnumerables

        public static IEnumerable<Country> GetAllCountries(this IRepository<Country> repository)
        {
            return repository.Queryable().AsEnumerable();
        }
        public static Country GetCountryById(this IRepository<Country> repository, int countryId)
        {
            return repository.Queryable().FirstOrDefault(c => c.CountryId == countryId);
        }
        public static Country GetCountryByName(this IRepository<Country> repository, string countryName)
        {
            return repository.Queryable().FirstOrDefault(c => c.Name == countryName);
        }

        #endregion (IEnumerables)
    }
}
