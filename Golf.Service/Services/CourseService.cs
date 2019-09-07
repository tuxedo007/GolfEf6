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
    public interface ICourseService : IService<Course>
    {
        #region IEnumerables
        IEnumerable<Course> GetAllCourses();
        Course GetCourseById(int courseId);
        Course GetCourseByName(string courseName);
        IEnumerable<Course> GetCoursesByDesigner(string courseDesigner);
        #endregion (IEnumerables)
    }

    public class CourseService : Service<Course>, ICourseService
    {
        #region CourseService Constructor

        private readonly IRepositoryAsync<Course> _repository;

        public CourseService(IRepositoryAsync<Course> repository)
            : base(repository)
        {
            _repository = repository;
        }

        #endregion (CourseService Constructor)

        #region Golf.Repository method calls

        #region Base methods
        public IEnumerable<Course> GetAllCourses()
        {
            return _repository.GetAllCourses();
        }
        public Course GetCourseById(int courseId)
        {
            return _repository.GetCourseById(courseId);
        }
        public Course GetCourseByName(string courseName)
        {
            return _repository.GetCourseByName(courseName);
        }
        public IEnumerable<Course> GetCoursesByDesigner(string courseDesigner)
        {
            return _repository.GetCoursesByDesigner(courseDesigner);
        }

        #endregion (Base methods)

        #endregion (JamIt.Repository method calls)
    }
}
