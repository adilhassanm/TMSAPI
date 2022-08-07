using System.ComponentModel.DataAnnotations;

namespace TMSAPI.api.Models.Domain
{
    public class AutomationControlPropertyRemarks
    {

        [Key]
        public int ID { get; set; }
        public string Language { get; set; }

        public string Remark { get; set; }

        public int Property_ID { get; set; }
    }
}
