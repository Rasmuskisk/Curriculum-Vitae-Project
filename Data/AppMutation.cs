using Curriculum_Vitae_Project.Data.Service;
using Curriculum_Vitae_Project.Model.Items;
using GraphQL;
using GraphQL.Types;

namespace Curriculum_Vitae_Project.Data
{
	public class AppMutation : ObjectGraphType
	{
		public AppMutation() 
		{
			Field<AuthorType>("createAuthor")
				.Arguments(new QueryArguments(
					new QueryArgument<NonNullGraphType<AuthorInputType>> { Name = "input" }
				))
				.Resolve(context =>
				{
					var input = context.GetArgument<Person>("input");
					// Save the author to the database, typically via a service
					var authorService = context.RequestServices.GetRequiredService<IAuthorService>();
					return authorService.CreateAuthor(input);
				});
		}
	}
}
