namespace DAL
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class VkladDb : DbContext
    {
        public VkladDb()
            : base("name=VkladDb")
        {
        }


        public DbSet<Vklad> Vklads { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Prog> Progs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Vklads)
                .WithMany(e => e.Clients)
                .Map(m => m.ToTable("VkladClient").MapLeftKey("ClietnId").MapRightKey("VkadId"));

            modelBuilder.Entity<Prog>()
                .HasMany(e => e.Vklads)
                .WithMany(e => e.Progs)
                .Map(m => m.ToTable("VkladProg").MapLeftKey("ProgId").MapRightKey("VkladId"));

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }

    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<VkladDb>
    {
        protected override void Seed(VkladDb db)
        {
            Client m = new Client { FIO = "������� ������� ���������" };
            db.Clients.Add(m);
            db.SaveChanges();
            Prog c = new Prog { name = "������ ��������", percent = 7 };
            db.Progs.Add(c);
            db.SaveChanges();
            db.Vklads.Add(new Vklad { Balance = 1244, DateOpen = new System.DateTime(1991, 12, 31) });
            db.SaveChanges();
        }
    }
}
