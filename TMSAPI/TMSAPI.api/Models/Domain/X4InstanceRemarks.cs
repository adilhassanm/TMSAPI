using System.ComponentModel.DataAnnotations;

namespace TMSAPI.api.Models.Domain
{
    public class X4InstanceRemarks
    {
        [Key]
        public int ID { get; set; }
        public string Language  { get; set; }

        public string RemarkPath { get; set; }

        public int Instance_ID { get; set; }

    }
}
