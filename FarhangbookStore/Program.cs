using FarhangbookStore.Common.PublicExtentions;
using FarhangbookStore.PublicExtentions;
using NToastNotify;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using WebMarkupMin.AspNetCore7;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// در این مکان جهت ارتباط رشته اتصال به بانک اطلاعاتی و دیگر تنظیمات appsettings.json شناسایی فایل جیسون مربوط به 
var configuration = builder.Configuration.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(FileNamesExtentions.AppSettingName).Build();
// MS SQL Server سرویس تنظیمات مربوط به اتصال رشته مربوط به پایگاه داده در 

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
