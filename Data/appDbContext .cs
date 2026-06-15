using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Data
{

    //DBContext ile DB ile bağlantı kurup DB'yi yönetebiliriz. Tıpkı ADO.NET'te olan sqlconnetion gibi. appDbContext Dbcontext sınıfını miras alarak DB'yi yönetebilir hale geliyor. 
    public class appDbContext: DbContext
    {

        //bu class sadece about me sınıfını  bağlı olacak about me tablosunu yöneteceğini DbSet<aboutMe> ile sölyemiş oluyoruz. EF buna göre tablo oluşturacak. 

        //about me sınıfnına bakarar DB'de bir tablo oluşacak.
        public DbSet<aboutMe> aboutMe { get; set; }

       public  appDbContext(DbContextOptions<appDbContext> options):base(options)
        { 


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            aboutMe about = new aboutMe();
            about.ID = 1;
            about.firstName = "ibrahim";
            about.lastName = "agrud";
            about.greeting = "Hi There!";
            about.description = "I'm a university student, currently pursuing my degree in Computer Engineering. My coding journey started with C++, and I spent a long time building projects with it. From there, I expanded into C#, MS SQL, Python, and other technologies. Lately, I've been diving into web technologies, and I'm excited to start my career as a Full Stack Developer. But don't think my life is all about writing code. I love cycling  — I usually join group rides — and I really enjoy playing table tennis  and meeting new people. So don't hesitate to reach out. I'd love to connect with you!";

            modelBuilder.Entity<aboutMe>().HasData(about);

        }
    }
}
