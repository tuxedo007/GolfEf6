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
    public interface ICountryService : IService<Country>
    {
        #region IEnumerables
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
        Country GetCountryByName(string countryName);
        #endregion (IEnumerables)
    }

    public class CountryService : Service<Country>, ICountryService
    {
        #region CountryService Constructor

        private readonly IRepositoryAsync<Country> _repository;

        public CountryService(IRepositoryAsync<Country> repository)
            : base(repository)
        {
            _repository = repository;
        }

        #endregion (CountryService Constructor)

        #region Golf.Repository method calls

        #region Base methods
        public IEnumerable<Country> GetAllCountries()
        {
            return _repository.GetAllCountries();
        }
        public Country GetCountryById(int countryId)
        {
            return _repository.GetCountryById(countryId);
        }
        public Country GetCountryByName(string countryName)
        {
            return _repository.GetCountryByName(countryName);
        }
        #endregion (Base methods)

        #endregion (JamIt.Repository method calls)
    }
}

