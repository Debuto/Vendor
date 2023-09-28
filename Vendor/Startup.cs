app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "vendors",
        pattern: "vendors/{action=Index}/{id?}",
        defaults: new { controller = "Vendors" });
    endpoints.MapControllerRoute(
        name: "orders",
        pattern: "orders/{action=Index}/{id?}",
        defaults: new { controller = "Orders" });
});