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
    public interface IPuttHistoryService : IService<PuttHistory>
    {
        #region IEnumerables
        IEnumerable<PuttHistory> GetAllPuttHistoryData();
        PuttHistory GetPuttHistoryById(int puttId);
        IEnumerable<PuttHistory> GetPuttByDistanceAndElevation(int distance, int elevation);
        PuttHistory GetPuttByDistanceElevationGreenCondition(int distance, int elevation, GreenSpeedEnum speed,
            GreenHardnessEnum hardness);
        IEnumerable<PuttHistory> GetPuttByDistance(int distance);
        IEnumerable<PuttHistory> GetPuttByDistanceAndElevationRange(int distance, int elevation, int rangeCount);
        IEnumerable<PuttHistory> GetPuttBySwingRatio(int swingRatio);
        IEnumerable<PuttHistory> GetPuttByGreenCondition(GreenSpeedEnum speed, GreenHardnessEnum hardness);
        #endregion (IEnumerables)
    }

    public class PuttHistoryService : Service<PuttHistory>, IPuttHistoryService
    {
        #region PuttHistoryService Constructor

        private readonly IRepositoryAsync<PuttHistory> _repository;

        public PuttHistoryService(IRepositoryAsync<PuttHistory> repository)
            : base(repository)
        {
            _repository = repository;
        }

        #endregion (PuttHistoryService Constructor)

        #region Golf.Repository method calls

        #region Base methods
        public IEnumerable<PuttHistory> GetAllPuttHistoryData()
        {
            return _repository.GetAllPuttHistoryData();
        }
        public PuttHistory GetPuttHistoryById(int puttId)
        {
            return _repository.GetPuttById(puttId);
        }
        public IEnumerable<PuttHistory> GetPuttByDistanceAndElevation(int distance, int elevation)
        {
            return _repository.GetPuttByDistanceAndElevation(distance, elevation);
        }
        public PuttHistory GetPuttByDistanceElevationGreenCondition(int distance, int elevation, GreenSpeedEnum speed, GreenHardnessEnum hardness)
        {
            return _repository.GetPuttByDistanceElevationGreenCondition(distance, elevation, speed, hardness);
        }
        public IEnumerable<PuttHistory> GetPuttByDistance(int distance)
        {
            return _repository.GetPuttByDistance(distance);
        }
        public IEnumerable<PuttHistory> GetPuttByDistanceAndElevationRange(int distance, int elevation, int rangeCount)
        {
            return _repository.GetPuttByDistanceAndElevationRange(distance, elevation, rangeCount);
        }
        public IEnumerable<PuttHistory> GetPuttBySwingRatio(int swingRatio)
        {
            return _repository.GetPuttBySwingRatio(swingRatio);
        }
        public IEnumerable<PuttHistory> GetPuttByGreenCondition(GreenSpeedEnum speed, GreenHardnessEnum hardness)
        {
            return _repository.GetPuttByGreenCondition(speed, hardness);
        }

        #endregion (Base methods)

        #endregion (JamIt.Repository method calls)
    }
}
