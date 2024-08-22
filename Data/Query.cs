using Curriculum_Vitae_Project.EFContext;
using Curriculum_Vitae_Project.Model.Items;
using GraphQL.Types;

namespace Curriculum_Vitae_Project.Data
{
    public class Query : ObjectGraphType
	{
		[UseProjection]
		[UseFiltering]
		[UseSorting]
		public IQueryable<Company> GetCompanies([Service] DataContext context) =>
			context.Companies;

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		public IQueryable<CurriculumVitae> GetCurriculumVitaes([Service] DataContext context) =>
			context.CurriculumVitaes;

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		public IQueryable<Person> GetPersons([Service] DataContext context) =>
			context.Authors;

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		public IQueryable<Project> GetProjects([Service] DataContext context) =>
			context.Projects;
	}
}
