using TMSAPI.api.Models.Domain;

namespace TMSAPI.api.Repositories
{
    public interface IAlarms
    {
        IEnumerable<FinalAlarm> GetFinalAlarms();   
    }
}
