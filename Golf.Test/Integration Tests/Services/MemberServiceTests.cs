#region Directives
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51

using System.Linq;
using Golf.Entities.Context;
using Golf.Entities.Model;
using Golf.Service.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using Repository.Pattern.Repositories;
using Repository.Pattern.UnitOfWork;
using Service.Pattern;

#endregion

namespace Golf.Test.Integration_Tests.Services
{
    [TestClass]
    public class MemberServiceTests
    {
        public TestContext TestContext { get; set; }
        // To allow access to Non-static dbSet 
        //public GolfContext Dc = new GolfContext();

        [TestInitialize]
        public void Initialize()
        {
            //Utility.CreateSeededTestDatabase();
        }

        [TestMethod]
        public void FindMemberByIdTest()
        {
            using (IDataContextAsync context = new GolfContext())
            using (IUnitOfWorkAsync unitOfWork = new UnitOfWork(context))
            {
                IRepositoryAsync<Member> memberRepository = new Repository<Member>(context, unitOfWork);
                IService<Member> memberService = new MemberService(memberRepository);
                var member = memberService.Find(5);
                TestContext.WriteLine("Member found: {0}", member.Lastname);
                Assert.AreEqual("Dave Kilminster", string.Format("{0} {1}", member.Firstname, member.Lastname));
            }
        }

        [TestMethod]
        public void RepositoryGetAllMembersTest()
        {
            using (IDataContextAsync context = new GolfContext())
            using (IUnitOfWorkAsync unitOfWork = new UnitOfWork(context))
            {
                IRepositoryAsync<Member> memberRepository = new Repository<Member>(context, unitOfWork);
                IMemberService memberService = new MemberService(memberRepository);
                var members = memberService.GetAllMembers();

                TestContext.WriteLine("Members found: {0}", members.Count());
                Assert.AreEqual(59, members.Count());
            }
        }

        [TestMethod]
        public void RepositoryGetMemberByIdTest()
        {
            using (IDataContextAsync context = new GolfContext())
            using (IUnitOfWorkAsync unitOfWork = new UnitOfWork(context))
            {
                IRepositoryAsync<Member> memberRepository = new Repository<Member>(context, unitOfWork);
                IMemberService memberService = new MemberService(memberRepository);
                var memberById = memberService.GetMemberById(4);

                Assert.AreEqual("James Humphries", string.Format("{0} {1}", memberById.Firstname, memberById.Lastname));
            }
        }

        [TestMethod]
        public void RepositoryGetMemberByNameTest()
        {
            using (IDataContextAsync context = new GolfContext())
            using (IUnitOfWorkAsync unitOfWork = new UnitOfWork(context))
            {
                IRepositoryAsync<Member> memberRepository = new Repository<Member>(context, unitOfWork);
                IMemberService memberService = new MemberService(memberRepository);
                var memberByName = memberService.GetMemberByName("Aledort", "Andy");

                Assert.AreEqual(1, memberByName.MemberId);
            }
        }
    }
}
