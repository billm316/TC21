using Microsoft.EntityFrameworkCore;

namespace TCEntities
{
    public class PatientContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public PatientContext()
        {
        }

        public PatientContext(DbContextOptions<PatientContext> options)
            : base(options)
        {
        }
    }
}
