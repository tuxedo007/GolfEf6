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
    public interface IMemberService : IService<Member>
    {
        #region IEnumerables
        IEnumerable<Member> GetAllMembers();
        Member GetMemberById(int memberId);
        Member GetMemberByName(string lastName, string firstName);
        #endregion (IEnumerables)
    }

    public class MemberService : Service<Member>, IMemberService
    {
        #region MemberService Constructor

        private readonly IRepositoryAsync<Member> _repository;

        public MemberService(IRepositoryAsync<Member> repository)
            : base(repository)
        {
            _repository = repository;
        }

        #endregion (MemberService Constructor)

        #region Golf.Repository method calls

        #region Base methods
        public IEnumerable<Member> GetAllMembers()
        {
            return _repository.GetAllMembers();
        }
        public Member GetMemberById(int memberId)
        {
            return _repository.GetMemberById(memberId);
        }
        public Member GetMemberByName(string lastName, string firstName)
        {
            return _repository.GetMemberByName(lastName, firstName);
        }

        #endregion (Base methods)

        #endregion (JamIt.Repository method calls)
    }
}
