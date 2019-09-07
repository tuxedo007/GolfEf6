#region Directives
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
using System.Collections.Generic;
using Golf.Entities.Model;
using Golf.Repository.Repositories;
using Repository.Pattern.Repositories;
using Service.Pattern;

#endregion (Directives)

namespace Golf.Service.Services
{
    public interface ITournamentService : IService<Tournament>
    {
        #region IEnumerables
        IEnumerable<Tournament> GetAllTournaments();
        Tournament GetTournamentById(int tournamentId);
        Tournament GetTournamentByName(string tournamentName);
        #endregion (IEnumerables)
    }

    public class TournamentService : Service<Tournament>, ITournamentService
    {
        #region TournamentService Constructor

        private readonly IRepositoryAsync<Tournament> _repository;

        public TournamentService(IRepositoryAsync<Tournament> repository)
            : base(repository)
        {
            _repository = repository;
        }

        #endregion (TournamentService Constructor)

        #region Golf.Repository method calls

        #region Base methods
        public IEnumerable<Tournament> GetAllTournaments()
        {
            return _repository.GetAllTournaments();
        }
        public Tournament GetTournamentById(int tournamentId)
        {
            return _repository.GetTournamentById(tournamentId);
        }
        public Tournament GetTournamentByName(string tournamentName)
        {
            return _repository.GetTournamentByName(tournamentName);
        }

        #endregion (Base methods)

        #endregion (JamIt.Repository method calls)
    }
}
