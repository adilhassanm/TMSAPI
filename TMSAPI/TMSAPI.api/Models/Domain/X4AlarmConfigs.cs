using System.ComponentModel.DataAnnotations;

namespace TMSAPI.api.Models.Domain
{
    public class X4AlarmConfigs
    {
        [Key]
        public int ID { get; set; }
        public string Effect { get; set; }

        public int X4AlarmGroup_ID { get; set; }

        public int X4Property_ID { get; set; }

        public int X4Instance_ID { get; set; }
    }
}