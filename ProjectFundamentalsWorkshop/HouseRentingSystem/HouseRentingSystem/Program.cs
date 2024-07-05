namespace HouseRentingSystem
{
    public class Program
    {
        public static  void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddApllicationDbContext(builder.Configuration);

            builder.Services.AddApllicationIdentity(builder.Configuration);

            builder.Services.AddControllersWithViews();

            builder.Services.AddApllicationServices();

            var app = builder.Build();

           
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapDefaultControllerRoute();

            app.MapRazorPages();

            app.Run();
        }
    }
}