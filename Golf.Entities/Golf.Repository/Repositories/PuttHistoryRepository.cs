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
    public static class PuttHistoryRepository
    {
        #region Static Context

        //private static readonly GearContext dc = new GearContext();

        #endregion (Static Context)

        #region IEnumerables

        public static IEnumerable<PuttHistory> GetAllPuttHistoryData(this IRepository<PuttHistory> repository)
        {
            return repository.Queryable().AsEnumerable();
        }
        public static PuttHistory GetPuttById(this IRepository<PuttHistory> repository, int puttId)
        {
            return repository.Queryable().FirstOrDefault(p => p.PuttId == puttId);
        }
        public static IEnumerable<PuttHistory> GetPuttByDistanceAndElevation(this IRepository<PuttHistory> repository, int distance, int elevation)
        {
            return repository.Queryable().Where(p => p.Distance == distance && p.Elevation == elevation);
        }
        public static PuttHistory GetPuttByDistanceElevationGreenCondition(this IRepository<PuttHistory> repository, int distance, int elevation, GreenSpeedEnum speed, GreenHardnessEnum hardness)
        {
            return repository.Queryable().FirstOrDefault(p => p.Distance == distance && p.Elevation == elevation && p.GreenSpeed == speed && p.GreenHardness == hardness);
        }
        public static IEnumerable<PuttHistory> GetPuttByDistance(this IRepository<PuttHistory> repository, int distance)
        {
            return repository.Queryable().Where(p => p.Distance == distance).AsEnumerable();
        }
        public static IEnumerable<PuttHistory> GetPuttByDistanceAndElevationRange(this IRepository<PuttHistory> repository, int distance, int elevation, int rangeCount)
        {
            return repository.Queryable()
                .Where(x => (x.Distance >= distance - rangeCount && x.Distance <= distance + rangeCount) && 
                    (x.Elevation == elevation - rangeCount && x.Elevation == elevation + rangeCount))
                .AsEnumerable();
        }
        public static IEnumerable<PuttHistory> GetPuttBySwingRatio(this IRepository<PuttHistory> repository, int swingRatio)
        {
            return repository.Queryable()
                .Where(x => x.SwingRatio == swingRatio)
                .AsEnumerable();
        }
        public static IEnumerable<PuttHistory> GetPuttByGreenCondition(this IRepository<PuttHistory> repository, GreenSpeedEnum speed, GreenHardnessEnum hardness)
        {
            return repository.Queryable()
                .Where(x => x.GreenSpeed == speed && x.GreenHardness == hardness)
                .AsEnumerable();
        }
 
        #endregion (IEnumerables)
    }
}

