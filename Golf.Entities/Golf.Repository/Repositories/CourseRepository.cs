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
    public static class CourseRepository
    {
        #region Static Context

        //private static readonly GearContext dc = new GearContext();

        #endregion (Static Context)

        #region IEnumerables

        public static IEnumerable<Course> GetAllCourses(this IRepository<Course> repository)
        {
            return repository.Queryable().AsEnumerable();
        }
        public static Course GetCourseById(this IRepository<Course> repository, int courseId)
        {
            return repository.Queryable().FirstOrDefault(c => c.CourseId == courseId);
        }
        public static Course GetCourseByName(this IRepository<Course> repository, string courseName)
        {
            return repository.Queryable().FirstOrDefault(c => c.CourseName == courseName);
        }
        public static IEnumerable<Course> GetCoursesByDesigner(this IRepository<Course> repository, string courseDesigner)
        {
            return repository.Queryable()
                .Where(x => x.Designer.Contains(courseDesigner))
                .AsEnumerable();
        }

        #endregion (IEnumerables)
    }
}
