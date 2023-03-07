using webapi.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Addmissioncontext>();
builder.Services.AddDbContext<StudentContext>();
builder.Services.AddDbContext<ClassContext>();
builder.Services.AddDbContext<FeesContext>();
builder.Services.AddDbContext<SessionContext>();
builder.Services.AddDbContext<SubjectContext>();
builder.Services.AddDbContext<AttendanceContext>();
builder.Services.AddDbContext<TeacherContext>();
builder.Services.AddDbContext<ExamContext>();
builder.Services.AddDbContext<ResultContext>();

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
