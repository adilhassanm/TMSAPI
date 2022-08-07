using System.ComponentModel.DataAnnotations;

namespace TMSAPI.api.Models.Domain
{
    public class X4AlarmGroups
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public int Priority { get; set; }
        public string Image { get; set; }

        public bool NoticeONAlarm { get; set; }

        public bool NoticeOFFAlarm { get; set; }

        public double NoiseRejection { get; set; }

        public bool SpeechEnable { get; set; }

        public string SoundFile { get; set; }

        public string AlarmOnForeground  { get; set; }

        public string AlarmOnBackground { get; set; }



        public string AlarmNoticeForeground { get; set; }

        public string AlarmNoticeBackground { get; set; }

        public string AlarmOffForeground { get; set; }

        public int AlarmOffBackground { get; set; }

        public bool LockInAlarmList { get; set; }


        public bool RemarkNecessary { get; set; }

        public int SpeechRepeatTime { get; set; }

        public string SpeechTextTemplate{ get; set; }

        public bool PlaySoundFile { get; set; }


        public string SoundFileName { get; set; }

        public bool AutoClean { get; set; }

        public int KeepTime { get; set; }




    }
}
    