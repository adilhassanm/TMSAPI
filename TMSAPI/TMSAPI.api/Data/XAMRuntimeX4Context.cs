using Microsoft.EntityFrameworkCore;
using TMSAPI.api.Models.Domain;

namespace TMSAPI.api.Data
{
    public class XAMRuntimeX4Context:DbContext
    {
        public XAMRuntimeX4Context(DbContextOptions <XAMRuntimeX4Context> options) : base(options)
        {

        }
        public DbSet<X4Journals> X4Journals { get; set; }
    }
}
