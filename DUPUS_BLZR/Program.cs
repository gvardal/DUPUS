using DUPUS_BLZR.Extensions;
using MudBlazor.Services;
using Syncfusion.Blazor;

namespace DUPUS_BLZR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddMudServices();

            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.ConfigureSqlContext(builder.Configuration);
            builder.Services.ConfigureServiceManager();
            builder.Services.ConfigureRepositoryManager();

            builder.Services.AddSyncfusionBlazor();

            var app = builder.Build();

            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjU1MjcwNkAzMjMyMmUzMDJlMzBBT1BUbXp5QXRLMGxNZjVFRmgvM2JTcXlpVWhUSEV3b2RLbWlyYXZXS1NZPQ==");
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF5cXmRCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdgWXhfcHRWR2ZfUEJ0Vko=");

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }


            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}