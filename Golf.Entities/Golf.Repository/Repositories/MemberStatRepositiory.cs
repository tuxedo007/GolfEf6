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
using Golf.Entities.Model;
using Repository.Pattern.Repositories;

#endregion (Directives)

namespace Golf.Repository.Repositories
{
    public static class MemberStatRepository
    {
        #region Static Context

        //private static readonly GearContext dc = new GearContext();

        #endregion (Static Context)

        #region IEnumerables

        public static IEnumerable<MemberStat> GetAllMemberStats(this IRepository<MemberStat> repository)
        {
            return repository.Queryable().AsEnumerable();
        }
        public static MemberStat GetStatById(this IRepository<MemberStat> repository, int statId)
        {
            return repository.Queryable().FirstOrDefault(m => m.StatId == statId);
        }
        public static IEnumerable<MemberStat> GetStatsByMemberId(this IRepository<MemberStat> repository, int memberId)
        {
            return repository.Queryable().Where(m => m.MemberId == memberId);
        }

        public static MemberStat GetStatByMemberAndSeason(this IRepository<MemberStat> repository, int memberId,
            int season)
        {
            return repository.Queryable().FirstOrDefault(s => s.MemberId == memberId && s.Season == season);
        }
        #endregion (IEnumerables)
    }
}
