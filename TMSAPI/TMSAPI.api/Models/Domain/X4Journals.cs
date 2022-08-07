using System.ComponentModel.DataAnnotations;

namespace TMSAPI.api.Models.Domain
{
    public class X4Journals
    {
        [Key]
        public int ID { get; set; }
        public DateTimeOffset OnTime { get; set; }

        public DateTimeOffset OffTime { get; set; }

        public DateTimeOffset OnNoticeTime { get; set; }

        public DateTimeOffset OffNoticeTime { get; set; }

        public int OnNoticeUserID { get; set; }

        public int OffNoticeUserID { get; set; }

        public int InstanceID { get; set; }

        public int PropertyID { get; set; }
    }
}
