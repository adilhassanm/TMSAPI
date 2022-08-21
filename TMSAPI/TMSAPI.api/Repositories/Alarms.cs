using System.Linq;
using TMSAPI.api.Data;
using TMSAPI.api.Models.Domain;

namespace TMSAPI.api.Repositories
{
    public class Alarms : IAlarms
    {
        private readonly XAMRuntimeX4Context xAMRuntimeX4Context;
        private readonly XAMControlX4Context xAMControlX4Context;

        public Alarms(XAMRuntimeX4Context xAMRuntimeX4Context, XAMControlX4Context xAMControlX4Context )
        {
            this.xAMRuntimeX4Context = xAMRuntimeX4Context;
            this.xAMControlX4Context = xAMControlX4Context;
        }
        public IEnumerable<FinalAlarm> GetFinalAlarms()
        {
            /*var finalAlarm = xAMRuntimeX4Context.X4Journals.Join(xAMControlX4Context.X4InstanceRemarks,
                j => j.InstanceID, i => i.Instance_ID, (j, i) => new { j, i }).Join(xAMControlX4Context.AutomationControlPropertyRemarks,
                 ppc => ppc.j.PropertyID, p => p.Property_ID, (ppc, p) => new { ppc, p }).Join(xAMControlX4Context.X4AlarmConfigs,
                  (ppc2 => ppc2.ppc.j.InstanceID, a => a.X4Instance_ID) && (ppc2 => ppc2.ppc.j.PropertyID, a => a.X4Property_ID),
                  (ppc2, a) => new { ppc2, a });*/
            /*
            var finalAlarm = xAMRuntimeX4Context.X4Journals
    .Join(xAMControlX4Context.X4InstanceRemarks,
            j => j.InstanceID, i => i.Instance_ID, (j, i) => new { j, i })
    .Join(xAMControlX4Context.AutomationControlPropertyRemarks,
            ppc => ppc.j.PropertyID, p => p.Property_ID, (ppc, p) => new { ppc.j, ppc.i, p })
    .Join(xAMControlX4Context.X4AlarmConfigs,
            ppc2 => (ppc2.j.InstanceID, ppc2.j.PropertyID), a => (a.X4Instance_ID, a.X4Property_ID),
            (ppc2, a) => new { ppc2.j, ppc2.i, ppc2.p, a })
    .Join(xAMControlX4Context.X4AlarmGroups,
            ppc3 => ppc3.a.X4AlarmGroup_ID, g => g.ID, (ppc3, g) => new { ppc3.j, ppc3.i, ppc3.p, ppc3.a, g })
    .Where(ppc4 => ppc4.i.Language == "iv" && ppc4.p.Language == "iv")
.OrderBy(ppc4 => ppc4.j.OnTime)
.Select(x => new {
    x.j.ID,
    AlarmAppearTime = x.j.OnTime,
    AlarmDisappearTime = x.j.OffTime,
    AlarmAckTime = x.j.OnNoticeTime,
    AlarmCloseTime = x.j.OffNoticeTime,
    AssetID = x.j.InstanceID,
    Asset = x.i.RemarkPath,
    MessageID = x.j.PropertyID,
    AlarmMessage = x.p.Remark,
    PriorityID = x.a.X4AlarmGroup_ID,
    PriorityGroup = x.g.Name
});
            */


            var finalAlarm2 = xAMRuntimeX4Context.X4Journals
            .Join(xAMControlX4Context.X4InstanceRemarks,
            j => j.InstanceID, i => i.Instance_ID, (j, i) => new { j, i })
            .Join(xAMControlX4Context.AutomationControlPropertyRemarks,
            ppc => ppc.j.PropertyID, p => p.Property_ID, (ppc, p) => new { ppc.j, ppc.i, p })
            .Join(xAMControlX4Context.X4AlarmConfigs,
            ppc2 => new { k1 = ppc2.j.InstanceID, k2 = ppc2.j.PropertyID },
            a => new { k1 = a.X4Instance_ID, k2 = a.X4Property_ID },
            (ppc2, a) => new { ppc2.j, ppc2.i, ppc2.p, a })
            .Join(xAMControlX4Context.X4AlarmGroups,
            ppc3 => ppc3.a.X4AlarmGroup_ID, g => g.ID, (ppc3, g) => new { ppc3.j, ppc3.i, ppc3.p, ppc3.a, g })
            .Where(ppc4 => ppc4.i.Language == "iv" && ppc4.p.Language == "iv")
            .OrderBy(ppc4 => ppc4.j.OnTime)
            .Select(x => new {
                    x.j.ID,
                    AlarmAppearTime = x.j.OnTime,
                    AlarmDisappearTime = x.j.OffTime,
                    AlarmAckTime = x.j.OnNoticeTime,
                    AlarmCloseTime = x.j.OffNoticeTime,
                    AssetID = x.j.InstanceID,
                    Asset = x.i.RemarkPath,
                    MessageID = x.j.PropertyID,
                    AlarmMessage = x.p.Remark,
                    PriorityID = x.a.X4AlarmGroup_ID,
                    PriorityGroup = x.g.Name
                            }
            );


            return (IEnumerable<FinalAlarm>)finalAlarm2.ToList();

            /*var finalAlarm1 = from j in xAMRuntimeX4Context.X4Journals
                             from i in xAMControlX4Context.X4InstanceRemarks.Where(x => x.Language == "iv")
                             from p in xAMControlX4Context.AutomationControlPropertyRemarks.Where(x => x.Language == "iv")
                             from a in xAMControlX4Context.X4AlarmConfigs
                             from g in xAMControlX4Context.X4AlarmGroups
                             select new
                             {
                                 ID = j.ID,
                                 AlarmAppearTime = j.OnTime,
                                 AlarmDisappearTime = j.OffTime,
                                 AlarmAckTime = j.OnNoticeTime,
                                 AlarmCloseTime = j.OffNoticeTime,
                                 AssetID = j.InstanceID,
                                 Asset = i.RemarkPath,
                                 MessageId = j.PropertyID,
                                 AlarmMessage = p.Remark,
                                 PriorityID = a.X4AlarmGroup_ID,
                                 PriorityGroup = g.Name
                             };

            */

        }
    }
}

