using Microsoft.EntityFrameworkCore;
using TMSAPI.api.Models.Domain;

namespace TMSAPI.api.Data
{
    public class XAMControlX4Context:DbContext
    {
        public XAMControlX4Context(DbContextOptions<XAMControlX4Context> options):base(options)
        {

        }
        public DbSet<X4AlarmConfigs> X4AlarmConfigs { get; set; }

        public DbSet<X4AlarmGroups> X4AlarmGroups { get; set; }
        public DbSet<X4InstanceRemarks> X4InstanceRemarks { get; set; }
    }
}
