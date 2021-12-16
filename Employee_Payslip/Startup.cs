using DataModel.Models;
using DataModel.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Employee_Payslip
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddLogging();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            string mySqlConnectionStr = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<PayRollManagementContext>(options =>options.UseSqlServer(mySqlConnectionStr));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddSingleton<IUnitOfWork, UnitOfWork>();
            //services.AddHttpContextAccessor();
            //services.AddMvcCore()
            //    .AddAuthorization(); // Note - this is on the IMvcBuilder, not the service collection);
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment() || env.IsProduction())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.Use((context, next) =>
            {
                context.Request.EnableBuffering();
                return next();
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=LogIn}/{action=LogIn}/{id?}");
            });
        }
    }
}
