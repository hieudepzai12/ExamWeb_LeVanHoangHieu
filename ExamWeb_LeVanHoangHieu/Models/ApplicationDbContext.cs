using Microsoft.EntityFrameworkCore;

namespace ExamWeb_LeVanHoangHieu.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<DiaNhac> DiaNhacs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Tạo dữ liệu cho bảng DiaNhacs
            modelBuilder.Entity<DiaNhac>().HasData(
                new DiaNhac { Id = 1, TuaCD = "Album 1", NgheSi = "Nghệ sĩ A", TrongNuoc = true, GiaBan = 150000, SoLuong = 3 },
                new DiaNhac { Id = 2, TuaCD = "Album 2", NgheSi = "Nghệ sĩ B", TrongNuoc = false, GiaBan = 200000, SoLuong = 6 },
                new DiaNhac { Id = 3, TuaCD = "Album 3", NgheSi = "Nghệ sĩ C", TrongNuoc = true, GiaBan = 100000, SoLuong = 10 }
            );
        }
    }
}
