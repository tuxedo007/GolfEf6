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
    public static class TournamentRepository
    {
        #region Static Context

        //private static readonly GearContext dc = new GearContext();

        #endregion (Static Context)

        #region IEnumerables

        public static IEnumerable<Tournament> GetAllTournaments(this IRepository<Tournament> repository)
        {
            return repository.Queryable().AsEnumerable();
        }
        public static Tournament GetTournamentById(this IRepository<Tournament> repository, int tournamentId)
        {
            return repository.Queryable().FirstOrDefault(t => t.TournamentId == tournamentId);
        }
        public static Tournament GetTournamentByName(this IRepository<Tournament> repository, string tournamentName)
        {
            return repository.Queryable().FirstOrDefault(t => t.TournamentName == tournamentName);
        }
        public static IEnumerable<Tournament> GetTournamentBySeason(this IRepository<Tournament> repository, int season)
        {
            return repository.Queryable()
                .Where(x => x.Season == season)
                .AsEnumerable();
        }

        #endregion (IEnumerables)
    }
}
