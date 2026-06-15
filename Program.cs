
using Microsoft.EntityFrameworkCore;
using Portfolio.Data;


//Uygulama kurulumu buradan baþlar.
var builder = WebApplication.CreateBuilder(args);



// controller ve view baðlantýsýný saðlamak.
builder.Services.AddControllersWithViews();

//DB eriþimi uygulama tanýtmak
builder.Services.AddDbContext<appDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



var app = builder.Build();
//üst kýsým uygulam için gerekli olan servisleri kuruyoruz.
//__________________________________________________________________



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
