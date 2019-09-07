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
    public interface IMemberStatService : IService<MemberStat>
    {
        #region IEnumerables
        IEnumerable<MemberStat> GetAllMemberStats();
        MemberStat GetStatById(int statId);
        IEnumerable<MemberStat> GetStatsByMemberId(int memberId);
        MemberStat GetStatByMemberAndSeason(int memberId, int season);
        #endregion (IEnumerables)
    }

    public class MemberStatService : Service<MemberStat>, IMemberStatService
    {
        #region MemberStatService Constructor

        private readonly IRepositoryAsync<MemberStat> _repository;

        public MemberStatService(IRepositoryAsync<MemberStat> repository)
            : base(repository)
        {
            _repository = repository;
        }

        #endregion (MemberStatService Constructor)

        #region Golf.Repository method calls

        #region Base methods
        public IEnumerable<MemberStat> GetAllMemberStats()
        {
            return _repository.GetAllMemberStats();
        }
        public MemberStat GetStatById(int statId)
        {
            return _repository.GetStatById(statId);
        }

        IEnumerable<MemberStat> IMemberStatService.GetStatsByMemberId(int memberId)
        {
            return _repository.GetStatsByMemberId(memberId);
        }

        public MemberStat GetStatByMemberAndSeason(int memberId, int season)
        {
            return _repository.GetStatByMemberAndSeason(memberId, season);
        }

        #endregion (Base methods)

        #endregion (JamIt.Repository method calls)
    }
}