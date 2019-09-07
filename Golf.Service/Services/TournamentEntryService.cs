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
    public interface ITournamentEntryService : IService<TournamentEntry>
    {
        #region IEnumerables
        IEnumerable<TournamentEntry> GetEntriesForAllTournaments();
        TournamentEntry GetTournamentEntryById(int tournamentEntryId);
        IEnumerable<TournamentEntry> GetTournamentEntries(int tournamentId);
        #endregion (IEnumerables)
    }

    public class TournamentEntryService : Service<TournamentEntry>, ITournamentEntryService
    {
        #region TournamentEntryService Constructor

        private readonly IRepositoryAsync<TournamentEntry> _repository;

        public TournamentEntryService(IRepositoryAsync<TournamentEntry> repository)
            : base(repository)
        {
            _repository = repository;
        }

        #endregion (TournamentEntryService Constructor)

        #region Golf.Repository method calls

        #region Base methods
        public IEnumerable<TournamentEntry> GetEntriesForAllTournaments()
        {
            return _repository.GetEntriesForAllTournaments();
        }
        public TournamentEntry GetTournamentEntryById(int tournamentEntryId)
        {
            return _repository.GetTournamentEntryById(tournamentEntryId);
        }
        public IEnumerable<TournamentEntry> GetTournamentEntries(int tournamentId)
        {
            return _repository.GetTournamentEntries(tournamentId);
        }

        #endregion (Base methods)

        #endregion (JamIt.Repository method calls)
    }
}
