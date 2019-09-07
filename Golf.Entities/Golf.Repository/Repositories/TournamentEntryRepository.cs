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
    public static class TournamentEntryRepository
    {
        #region Static Context

        //private static readonly GearContext dc = new GearContext();

        #endregion (Static Context)

        #region IEnumerables

        public static IEnumerable<TournamentEntry> GetEntriesForAllTournaments(this IRepository<TournamentEntry> repository)
        {
            return repository.Queryable().AsEnumerable();
        }
        public static TournamentEntry GetTournamentEntryById(this IRepository<TournamentEntry> repository, int tournamentEntryId)
        {
            return repository.Queryable().FirstOrDefault(e => e.EntryId == tournamentEntryId);
        }
        public static IEnumerable<TournamentEntry> GetTournamentEntries(this IRepository<TournamentEntry> repository, int tournamentId)
        {
            return repository.Queryable().Where(e => e.TournamentId == tournamentId).AsEnumerable();
        }
        //public static TournamentEntry GetTournamentEntryByName(this IRepository<TournamentEntry> repository, string tournamentEntryName)
        //{
        //    return repository.Queryable().FirstOrDefault(c => c.TournamentEntryName == tournamentEntryName);
        //}
        //public static IEnumerable<TournamentEntry> GetTournamentEntrysByType(this IRepository<TournamentEntry> repository, string tournamentEntryType)
        //{
        //    return repository.Queryable()
        //        .Where(x => x.TournamentEntryType.Contains(tournamentEntryType))
        //        .AsEnumerable();
        //}

        #endregion (IEnumerables)

        #region QueryModel methods
        //public static IEnumerable<PublicationSongArticleQueryModel> PerformerSongArticles(this IRepository<Article> repository)
        //{
        //    var publications = repository.GetRepository<Publication>().Queryable();
        //    var issues = repository.GetRepository<Issue>().Queryable();
        //    var articles = repository.GetRepository<Article>().Queryable();
        //    var performers = repository.GetRepository<Performer>().Queryable();
        //    var tutors = repository.GetRepository<Tutor>().Queryable();
        //    var styles = repository.GetRepository<SongStyle>().Queryable();
        //    var types = repository.GetRepository<ArticleType>().Queryable();

        //    var query = (from ar in articles
        //                 join iu in issues on new { u = ar.IssueId }
        //                     equals new { u = iu.IssueId }
        //                 join pu in publications on new { v = iu.PubId }
        //                     equals new { v = pu.PubId }
        //                 join pf in performers on new { x = ar.PerformerId }
        //                     equals new { x = pf.PerformerId }
        //                 join at in types on new { y = ar.ArticleTypeId }
        //                     equals new { y = at.TypeId }
        //                 join ss in styles on new { z = ar.SongStyleId }
        //                     equals new { z = ss.StyleId }
        //                 join tu in tutors on new { w = ar.TutorId }
        //                     equals new { w = (int?)tu.TutorId } into notutor
        //                 from na in notutor.DefaultIfEmpty()
        //                 orderby ar.PerformerId, iu.IssueYear, iu.IssueMonth
        //                 select new PublicationSongArticleQueryModel
        //                 {
        //                     ArticleId = ar.ArticleId,
        //                     ArticleName = ar.ArticleName,
        //                     PerformerId = pf.PerformerId,
        //                     PerformerName = pf.PerformerName,
        //                     AbilityRating = ar.AbilityRating,
        //                     TypeName = at.TypeName,
        //                     StyleName = ss.StyleName,
        //                     PubId = pu.PubId,
        //                     PubName = pu.PubName,
        //                     IssueId = iu.IssueId,
        //                     IssueNo = iu.IssueNo,
        //                     IssueYear = (int)iu.IssueYear,
        //                     IssueMonth = iu.IssueMonth,
        //                     Collected = iu.Collected,
        //                     IssueFormat = iu.IssueFormat,
        //                     TutorName = na.Lastname
        //                 });

        //    return query.AsEnumerable();
        //}
        #endregion (QueryModel methods)
    }
}
