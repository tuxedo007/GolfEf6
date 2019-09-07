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
    public interface IShotHistoryService : IService<ShotHistory>
    {
        #region IEnumerables

        IEnumerable<ShotHistory> GetAllShotHistoryData();
        ShotHistory GetShotHistoryById(int shotId);
        IEnumerable<ShotHistory> GetShotByDistance(int distance);
        IEnumerable<ShotHistory> GetClubShotHistory(ClubEnum club);
        IEnumerable<ShotHistory> GetShotByWindConditions(int distance, WindDirectionEnum windDirection, WindConditionEnum windCondition);

        #endregion (IEnumerables)
    }

    public class ShotHistoryService : Service<ShotHistory>, IShotHistoryService
    {
        #region ShotHistoryService Constructor

        private readonly IRepositoryAsync<ShotHistory> _repository;

        public ShotHistoryService(IRepositoryAsync<ShotHistory> repository)
            : base(repository)
        {
            _repository = repository;
        }

        #endregion (ShotHistoryService Constructor)

        #region Golf.Repository method calls

        #region Base methods
        public IEnumerable<ShotHistory> GetAllShotHistoryData()
        {
            return _repository.GetAllShotHistoryData();
        }
        public ShotHistory GetShotHistoryById(int shotId)
        {
            return _repository.GetShotHistoryById(shotId);
        }
        public IEnumerable<ShotHistory> GetShotByDistance(int distance)
        {
            return _repository.GetShotByDistance(distance);
        }
        public IEnumerable<ShotHistory> GetClubShotHistory(ClubEnum club)
        {
            return _repository.GetClubShotHistory(club);
        }
        public IEnumerable<ShotHistory> GetShotByWindConditions(int distance,  WindDirectionEnum windDirection, WindConditionEnum windCondition)
        {
            return _repository.GetShotByDistanceAndWindConditions(distance,  windDirection, windCondition);
        }

        #endregion (Base methods)

        #endregion (JamIt.Repository method calls)
    }
}
