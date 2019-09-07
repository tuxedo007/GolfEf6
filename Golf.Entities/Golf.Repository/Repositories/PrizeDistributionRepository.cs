#region Directives
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
using System.Collections.Generic;
using System.Linq;
using Golf.Entities.Enumerations;
using Golf.Entities.Model;
using Repository.Pattern.Repositories;

#endregion (Directives)

namespace Golf.Repository.Repositories
{
    //class PrizeDistributionRepository
    public static class PrizeDistributionRepository
    {
        #region Static Context

        //private static readonly GearContext dc = new GearContext();

        #endregion (Static Context)

        #region IEnumerables

        public static IEnumerable<PrizeDistribution> GetAllPrizeDistributions(this IRepository<PrizeDistribution> repository)
        {
            return repository.Queryable().AsEnumerable();
        }
        public static PrizeDistribution GetPrizeDistributionById(this IRepository<PrizeDistribution> repository, int prizeId)
        {
            return repository.Find(prizeId);
        }
        public static PrizeDistribution GetPrizeDistributionCategoryPosition(this IRepository<PrizeDistribution> repository, TournamentCategoryEnum category, int position)
        {
            return repository.Queryable().FirstOrDefault(p => p.Category == category && p.Position == position);
        }
        public static IEnumerable<PrizeDistribution> GetPrizeDistributionsByCategory(this IRepository<PrizeDistribution> repository, TournamentCategoryEnum category)
        {
            return repository.Queryable().Where(p => p.Category == category).AsEnumerable();
        }

        #endregion (IEnumerables)
    }
}
