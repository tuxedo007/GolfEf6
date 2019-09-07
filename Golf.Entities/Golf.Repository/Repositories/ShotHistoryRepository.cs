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
    public static class ShotHistoryRepository
    {
        #region Static Context

        //private static readonly GearContext dc = new GearContext();

        #endregion (Static Context)

        #region IEnumerables

        public static IEnumerable<ShotHistory> GetAllShotHistoryData(this IRepository<ShotHistory> repository)
        {
            return repository.Queryable().AsEnumerable();
        }
        public static ShotHistory GetShotHistoryById(this IRepository<ShotHistory> repository, int shotId)
        {
            return repository.Queryable().FirstOrDefault(c => c.ShotId == shotId);
        }
        public static IEnumerable<ShotHistory> GetShotByDistance(this IRepository<ShotHistory> repository, int distance)
        {
            return repository.Queryable()
                .Where(x => x.Distance == distance)
                .AsEnumerable();
        }
        public static IEnumerable<ShotHistory> GetClubShotHistory(this IRepository<ShotHistory> repository, ClubEnum club)
        {
            return repository.Queryable()
                .Where(x => x.Club == club)
                .AsEnumerable();
        }
        public static IEnumerable<ShotHistory> GetShotByDistanceAndWindConditions(this IRepository<ShotHistory> repository, int distance,  WindDirectionEnum windDirection, WindConditionEnum windCondition)
        {
            return repository.Queryable()
                .Where(x => x.Distance == distance && x.WindDirection == windDirection && x.WindCondition == windCondition)
                .AsEnumerable();
        }
        #endregion (IEnumerables)
    }
}
