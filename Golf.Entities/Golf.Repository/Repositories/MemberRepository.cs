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
    public static class MemberRepository
    {
        #region Static Context

        //private static readonly GearContext dc = new GearContext();

        #endregion (Static Context)

        #region IEnumerables

        public static IEnumerable<Member> GetAllMembers(this IRepository<Member> repository)
        {
            return repository.Queryable().AsEnumerable();
        }
        public static Member GetMemberById(this IRepository<Member> repository, int memberId)
        {
            return repository.Queryable().FirstOrDefault(m => m.MemberId == memberId);
        }
        public static Member GetMemberByName(this IRepository<Member> repository, string memberLastName, string memberFirstName)
        {
            return repository.Queryable().FirstOrDefault(c => c.Lastname == memberLastName && c.Firstname == memberFirstName);
        }
        //public static IEnumerable<Member> GetGuitarModelLike(this IRepository<Member> repository, string memberType)
        //{
        //    return repository.Queryable()
        //        .Where(x => x.MemberType.Contains(memberType))
        //        .AsEnumerable();
        //}

        #endregion (IEnumerables)
    }
}
