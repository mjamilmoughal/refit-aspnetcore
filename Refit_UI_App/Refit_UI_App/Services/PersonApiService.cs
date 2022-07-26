using Refit;
using Refit_UI_App.Models;

namespace Refit_UI_App.Services
{
    public interface IPersonApiService
    {
        [Get("/Persons")]
        Task<List<Person>> GetPersons();

        [Get("/Persons/{id}")]
        Task<Person> GetPerson(int id);

        [Post("/Persons")]
        Task NewPerson([Body] Person guest);

        [Put("/Persons/{id}")]
        Task UpdatePerson(int id, [Body] Person guest);

        [Delete("/Persons/{id}")]
        Task DeletePerson(int id);
    }
}
