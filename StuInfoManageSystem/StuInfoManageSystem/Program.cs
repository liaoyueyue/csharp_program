using StuInfoManageSystem.Data;
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

            services.AddScoped<MajorRepo>();
            services.AddScoped<GradeRepo>();
            services.AddScoped<ClassRepo>();
            services.AddScoped<StudentRepo>();

            services.AddScoped<MajorService>();
            services.AddScoped<GradeService>();
            services.AddScoped<StudentService>();

            var app = builder.Build();
            app.UseStatusCodePagesWithReExecute("/error/{0}");
            app.UseStaticFiles();
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
