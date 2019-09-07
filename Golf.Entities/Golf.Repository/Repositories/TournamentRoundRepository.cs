using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Golf.Entities.Model;
using Repository.Pattern.Repositories;

namespace Golf.Repository.Repositories
{
    public static class TournamentRoundRepository
    {
        #region Static Context

        //private static readonly GearContext dc = new GearContext();

        #endregion (Static Context)

        #region IEnumerables

        public static IEnumerable<TournamentRound> GetAllTournamentRounds(this IRepository<TournamentRound> repository)
        {
            return repository.Queryable().AsEnumerable();
        }
        public static TournamentRound GetRoundById(this IRepository<TournamentRound> repository, int tournamentRoundId)
        {
            return repository.Find(tournamentRoundId);
        }

        public static TournamentRound GetTournamentRoundById(this IRepository<TournamentRound> repository,
            int tournamentId, int round)
        {
            return repository.Queryable().FirstOrDefault(t => t.TournamentId == tournamentId && t.RoundNo == round);
        }
        public static IEnumerable<TournamentRound> GetTournamentRounds(this IRepository<TournamentRound> repository, int tournamentId)
        {
            return repository.Queryable().Where(e => e.TournamentId == tournamentId).AsEnumerable();
        }
        #endregion (IEnumerables)

        #region QueryModel methods

        #endregion (QueryModel methods)
    }
}
