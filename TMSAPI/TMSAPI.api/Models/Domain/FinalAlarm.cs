using System.ComponentModel.DataAnnotations;

namespace TMSAPI.api.Models.Domain
{
    public class FinalAlarm
    {
        [Key]
        public int ID { get; set; }
        public DateTimeOffset OnTime { get; set; }

        public DateTimeOffset OffTime { get; set; }

        public DateTimeOffset OnNoticeTime { get; set; }

        public DateTimeOffset OffNoticeTime { get; set; }

       
        public int InstanceID { get; set; }

        public string RemarkPath { get; set; }

        public int PropertyID { get; set; }

        public string Remark { get; set; }

        public int X4AlarmGroup_ID { get; set; }

        public string Name { get; set; }


    }
}
