using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using MVCCRUD.DataAcces;

namespace MVCCRUD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DbConnection")));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AppDbContext>();
            //builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddSignInManager<SignInManager<IdentityUser>>();
            builder.Services.AddRazorPages();


            builder.Services.AddControllersWithViews();

            #region Concurrency Limiter
            //builder.Services.AddRateLimiter(options =>
            //{
            //    options.AddConcurrencyLimiter("Concurrency", opt => {
            //        opt.PermitLimit = 10;
            //        opt.QueueLimit = 2;
            //        opt.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
            //    });
            //});
            #endregion
            #region Token Bucket Limiter
            //builder.Services.AddRateLimiter(options =>
            //{
            //    options.AddTokenBucketLimiter("Token", opt =>
            //    {
            //        opt.TokenLimit = 4;
            //        opt.QueueLimit = 3;
            //        opt.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
            //        opt.ReplenishmentPeriod = TimeSpan.FromSeconds(10);
            //        opt.TokensPerPeriod = 4;
            //        opt.AutoReplenishment = true;
            //    });
            //});
            #endregion
            #region Sliding Window Limiter
            //builder.Services.AddRateLimiter(options =>
            //{
            //    options.AddSlidingWindowLimiter("Sliding", opt =>
            //    {
            //        opt.Window=TimeSpan.FromSeconds(10);
            //        opt.PermitLimit = 4;
            //        opt.QueueLimit = 3;
            //        opt.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
            //        opt.SegmentsPerWindow = 3;
            //    });
            //});
            #endregion

            builder.Services.AddRateLimiter(options =>
            {
                options.AddFixedWindowLimiter("Fixed", opt =>
                {
                    opt.Window = TimeSpan.FromSeconds(5);
                    opt.PermitLimit = 3;
                });
            });


            var app = builder.Build();


            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");

            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.MapRazorPages();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.UseRateLimiter();
            app.Run();
        }
    }
}