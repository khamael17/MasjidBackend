using Masjid.Models;

namespace Masjid.Services
{
    public interface IEvent
    {
      IEnumerable<YouthProgram> GetYouthPrograms { get; set; }
        IEnumerable<AftSchoolProgram> GetAftSchoolPrograms { get; set; }
        IEnumerable<Event> GetEvents { get; set; }  
        IEnumerable<IslamicClasse> GetIslamicClasses { get; set; }


    }
}
