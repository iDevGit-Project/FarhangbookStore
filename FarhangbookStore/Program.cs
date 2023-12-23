using FarhangbookStore.Common.PublicExtentions;
using NToastNotify;
using WebMarkupMin.AspNetCore7;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region سرویس مربوط به تاریخ شمسی
builder.Services.AddTransient<ConvertDate>();
#endregion

#region سرویس مربوط به بهینه سازی صفحات در پروژه
//WebMarkupMin.AspNetCore7  : استفاده از پکیج کاربری مخصوص ورژن 7 دات نت کور
//NuGet\Install-Package WebMarkupMin.AspNetCore7 -Version 2.14.1
builder.Services.AddWebMarkupMin(option =>
{
	option.AllowCompressionInDevelopmentEnvironment = true;
	option.AllowMinificationInDevelopmentEnvironment = true;
}).AddHtmlMinification(
			options =>
			{
				options.MinificationSettings.RemoveRedundantAttributes = true;
				options.MinificationSettings.RemoveHttpProtocolFromAttributes = true;
				options.MinificationSettings.RemoveHttpsProtocolFromAttributes = true;
			})
  .AddHttpCompression();

#endregion

#region PWA سرویس مربوط به
//builder.Services.AddProgressiveWebApp();

#endregion

#region متد های مربوط به نوتیفیکیشن
builder.Services.AddMvc().AddNToastNotifyToastr(new ToastrOptions()
{
	ProgressBar = true,
	PositionClass = ToastPositions.TopCenter
});
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseWebMarkupMin();

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseRouting();

app.UseNToastNotify();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "Administrator",
	pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
	name: "Users",
	pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.Run();
