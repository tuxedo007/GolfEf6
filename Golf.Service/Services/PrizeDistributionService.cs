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
using Golf.Repository.Repositories;
using Repository.Pattern.Repositories;
using Service.Pattern;

#endregion (Directives)

namespace Golf.Service.Services
{
    public interface IPrizeDistributionService : IService<PrizeDistribution>
    {
        #region IEnumerables
        IEnumerable<PrizeDistribution> GetAllPrizeDistributions();
        PrizeDistribution GetPrizeDistributionById(int courseId);
        PrizeDistribution GetPrizeDistributionCategoryPosition(TournamentCategoryEnum category, int position);
        IEnumerable<PrizeDistribution> GetPrizeDistributionsByCategory(TournamentCategoryEnum category);

        #endregion (IEnumerables)
    }

    public class PrizeDistributionService : Service<PrizeDistribution>, IPrizeDistributionService
    {
        #region PrizeDistributionService Constructor

        private readonly IRepositoryAsync<PrizeDistribution> _repository;

        public PrizeDistributionService(IRepositoryAsync<PrizeDistribution> repository)
            : base(repository)
        {
            _repository = repository;
        }

        #endregion (PrizeDistributionService Constructor)

        #region Golf.Repository method calls

        #region Base methods
        public IEnumerable<PrizeDistribution> GetAllPrizeDistributions()
        {
            return _repository.GetAllPrizeDistributions();
        }
        public PrizeDistribution GetPrizeDistributionById(int courseId)
        {
            return _repository.GetPrizeDistributionById(courseId);
        }
        public PrizeDistribution GetPrizeDistributionCategoryPosition(TournamentCategoryEnum category, int position)
        {
            return _repository.Queryable().FirstOrDefault(p => p.Category == category && p.Position == position);
        }
        public IEnumerable<PrizeDistribution> GetPrizeDistributionsByCategory(TournamentCategoryEnum category)
        {
            return _repository.Queryable().Where(p => p.Category == category).AsEnumerable();
        }

        #endregion (Base methods)

        #endregion (JamIt.Repository method calls)
    }
}