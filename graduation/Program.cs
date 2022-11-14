using graduation.Interface;
using graduation.Model;
using graduation.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<AppDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("dbConnection")));

builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IUser, UserRepo>();
builder.Services.AddTransient<IClinic, ClinicRepo>();
builder.Services.AddTransient<IClinicReservation, ClinicResRepo>();
builder.Services.AddTransient<IConsultation, ConsultationRepo>();
builder.Services.AddTransient<IMRI_Results, MRI_ResultsRepo>();
builder.Services.AddTransient<IDoctor, DoctorRepo>();
builder.Services.AddTransient<IBanner, BannerRepo>();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
