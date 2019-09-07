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
using Golf.Entities.Context;
using Golf.Entities.Model;
using Golf.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using Repository.Pattern.Repositories;
using Repository.Pattern.UnitOfWork;

#endregion


namespace Golf.Test.Integration_Tests.Repositories
{
    [TestClass]
    public class MemberRepositoryTests
    {
        public TestContext TestContext { get; set; }
        // To allow access to Non-static dbSet 
        public GolfContext Dc = new GolfContext();

        [TestInitialize]
        public void Initialize()
        {
            //Utility.CreateSeededTestDatabase();
        }

        [TestMethod]
        public void GetAllMembersTest()
        {
            using (IDataContextAsync context = new GolfContext())
            using (IUnitOfWorkAsync unitOfWork = new UnitOfWork(context))
            {
                IRepositoryAsync<Member> memberRepository = new Repository<Member>(context, unitOfWork);

                var members = memberRepository.GetAllMembers();
                var enumerable = members as IList<Member> ?? members.ToList();
                TestContext.WriteLine("Members found: {0}", enumerable.Count());
                Assert.AreEqual(59, enumerable.Count());
            }
        }

        [TestMethod]
        public void GetMembersByIdTest()
        {
            using (IDataContextAsync context = new GolfContext())
            using (IUnitOfWorkAsync unitOfWork = new UnitOfWork(context))
            {
                IRepositoryAsync<Member> memberRepository = new Repository<Member>(context, unitOfWork);

                var member = memberRepository.GetMemberById(122);
                TestContext.WriteLine("Members found: {0}", member.Lastname);
                Assert.AreEqual("Dustin Johnson", string.Format("{0} {1}", member.Firstname, member.Lastname));
            }
        }

        [TestMethod]
        public void GetMemberByNameTest()
        {
            using (IDataContextAsync context = new GolfContext())
            using (IUnitOfWorkAsync unitOfWork = new UnitOfWork(context))
            {
                IRepositoryAsync<Member> memberRepository = new Repository<Member>(context, unitOfWork);

                var member = memberRepository.GetMemberByName("Woods", "Tiger");

                Assert.AreEqual(1, member.MemberId);
            }
        }
    }
}
