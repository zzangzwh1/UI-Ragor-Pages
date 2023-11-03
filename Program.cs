namespace UI_Ragor_Pages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddRazorPages();

            var app = builder.Build();
            app.UseStaticFiles(); //add for wwrooot
            app.UseRouting();
            app.MapRazorPages();

            // app.MapGet("/", () => "Hello World!");
            app.MapFallbackToPage("/wcho2Categories");

            app.Run();
        }
    }
}