using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Golf.Entities.Model;
using Golf.Repository.Repositories;
using Repository.Pattern.Repositories;
using Service.Pattern;

namespace Golf.Service.Services
{
    public interface ITournamentRoundService : IService<TournamentRound>
    {
        #region IEnumerables
        IEnumerable<TournamentRound> GetAllTournamentRounds();
        TournamentRound GetRoundById(int roundId);
        TournamentRound GetTournamentRoundById(int tournamentId, int round);
        IEnumerable<TournamentRound> GetTournamentRounds(int tournamentId);
        #endregion (IEnumerables)
    }

    public class TournamentRoundService : Service<TournamentRound>, ITournamentRoundService
    {
        #region TournamentRoundService Constructor

        private readonly IRepositoryAsync<TournamentRound> _repository;

        public TournamentRoundService(IRepositoryAsync<TournamentRound> repository)
            : base(repository)
        {
            _repository = repository;
        }

        #endregion (TournamentRoundService Constructor)

        #region Golf.Repository method calls

        #region Base methods
        public IEnumerable<TournamentRound> GetAllTournamentRounds()
        {
            return _repository.GetAllTournamentRounds();
        }

        public TournamentRound GetRoundById(int roundId)
        {
            return _repository.Find(roundId);
        }

        public TournamentRound GetTournamentRoundById(int tournamentId, int round)
        {
            return _repository.GetTournamentRoundById(tournamentId, round);
        }
        public IEnumerable<TournamentRound> GetTournamentRounds(int tournamentId)
        {
            return _repository.GetTournamentRounds(tournamentId);
        }

        #endregion (Base methods)

        #endregion (JamIt.Repository method calls)
    }
}
