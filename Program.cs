using Curriculum_Vitae_Project.Data;
using Curriculum_Vitae_Project.Data.Service;
using Curriculum_Vitae_Project.EFContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//GraphQL
builder.Services.AddGraphQLServer()
	.AddQueryType<Query>()
	.AddProjections()
	.AddFiltering()
	.AddSorting();

// Register GraphQL types
builder.Services.AddSingleton<AuthorType>();
builder.Services.AddSingleton<AuthorInputType>();
builder.Services.AddSingleton<AppMutation>();
builder.Services.AddSingleton<AppSchema>();

builder.Services.AddSingleton<IAuthorService, AuthorService>();

//Database
builder.Services.AddDbContext<DataContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseGraphQLPlayground(); 

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapGraphQL("/graphql");

app.Run();
