using Curriculum_Vitae_Project.Model.Items;
using GraphQL.Types;

namespace Curriculum_Vitae_Project.Data
{
	public class AuthorType : ObjectGraphType<Person>
	{
		public AuthorType()
		{
			Field(x => x.Id, type: typeof(IdGraphType)).Description("Author Id");
			Field(x => x.Name).Description("Author name");
			Field(x => x.Age).Description("Author age");
			Field(x => x.Occupation).Description("Author occupation");
			//Field<Project>("project", resolve: context => context.Source.Project);
		}
	}
}
