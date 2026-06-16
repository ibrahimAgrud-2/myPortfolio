using Microsoft.EntityFrameworkCore;
using Portfolio.Models;


namespace Portfolio.Data
{

    //DBContext ile DB ile bağlantı kurup DB'yi yönetebiliriz. Tıpkı ADO.NET'te olan sqlconnetion gibi. appDbContext Dbcontext sınıfını miras alarak DB'yi yönetebilir hale geliyor. 
    //Köprü sınıfı
    public class appDbContext: DbContext
    {

        //bu class sadece about me sınıfını  bağlı olacak about me tablosunu yöneteceğini DbSet<aboutMe> ile sölyemiş oluyoruz. EF buna göre tablo oluşturacak. 

        //about me sınıfnına bakarar DB'de bir tablo oluşacak.
        public DbSet<aboutMe> aboutMe { get; set; }
        //Bu Dbsetler tabloyu EF'e tanıtan kısımlardır.
        public DbSet<education> education { get; set; }
        public DbSet<project> project { get; set; }
        public DbSet<skills> skill { get; set; }



        public appDbContext(DbContextOptions<appDbContext> options):base(options)
        { 


        }

        //neden
      
    }



}
