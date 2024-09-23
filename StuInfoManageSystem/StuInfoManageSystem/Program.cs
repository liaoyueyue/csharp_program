using Microsoft.AspNetCore.Identity;
using StuInfoManageSystem.Data;
using StuInfoManageSystem.Identity;
using StuInfoManageSystem.Repositories;
using StuInfoManageSystem.Services;

namespace StuInfoManageSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            IServiceCollection services = builder.Services;
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>();
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
            });

            services.AddScoped<MajorRepo>();
            services.AddScoped<GradeRepo>();
            services.AddScoped<ClassRepo>();
            services.AddScoped<StudentRepo>();

            services.AddScoped<MajorService>();
            services.AddScoped<GradeService>();
            services.AddScoped<ClassService>();
            services.AddScoped<StudentService>();

            services.AddScoped<SearchService>();

            services.AddTransient<IdentityDataSeeder>();

            var app = builder.Build();
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var identityDataSeeder = serviceProvider.GetRequiredService<IdentityDataSeeder>();
                identityDataSeeder.Seed().Wait();
            }
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePagesWithReExecute("/error/{0}");
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
