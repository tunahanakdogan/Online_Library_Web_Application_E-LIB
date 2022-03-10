using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_business.Abstract;
using elib_business.Concrete;
using elib_data.Abstract;
using elib_data.Concrete;
using elib_data.Concrete.EfCore;
using elib_mvc.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace elib_mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //If database will change only second parameter changed here and new database will be implemented to project.
            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=ElibDb;Integrated Security=SSPI;"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<IdentityContext>().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
            });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
            });
            services.AddScoped<IBookRepository, EfCoreBookRepository>();
            services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
            services.AddScoped<IFavListRepository, EfCoreFavListRepository>();

            services.AddScoped<IBookService, BookManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IFavListService, FavListManager>();


            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "favlist",
                  pattern: "FavList/index",
                  defaults: new { controller = "FavList", action = "Index" }
                  );
                endpoints.MapControllerRoute(
                   name: "adminbooklist",
                   pattern: "admin/list",
                   defaults: new { controller = "Admin", action = "list" }
                   );
                endpoints.MapControllerRoute(
                  name: "admincategorylist",
                  pattern: "admin/categories",
                  defaults: new { controller = "Admin", action = "categorylist" }
                  );

                endpoints.MapControllerRoute(
                 name: "adminaddcategory",
                 pattern: "admin/categories/addcategory",
                 defaults: new { controller = "Admin", action = "addcategory" }
                 );

                endpoints.MapControllerRoute(
                name: "adminbookedit",
                pattern: "admin/editbook/{id?}",
                defaults: new { controller = "Admin", action = "EditBook" }
                );
                endpoints.MapControllerRoute(
                   name: "search",
                   pattern: "search",
                   defaults: new { controller = "Library", action = "search" }
                   );
                endpoints.MapControllerRoute(
                   name: "booksdetails",
                   pattern: "{url}",
                   defaults: new { controller = "Library", action = "details" }
                   );
                endpoints.MapControllerRoute(
                   name: "allbooks",
                   pattern: "library/{category?}",
                   defaults: new { controller = "Library", action = "list" }
                   );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
