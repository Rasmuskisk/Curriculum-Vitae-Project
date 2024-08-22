using GraphQL.Types;

namespace Curriculum_Vitae_Project.Data
{
	public class AuthorInputType : InputObjectGraphType
	{
		public AuthorInputType()
		{
			Name = "AuthorInput";
			Field<NonNullGraphType<StringGraphType>>("name");
			Field<NonNullGraphType<IntGraphType>>("age");
			Field<NonNullGraphType<StringGraphType>>("occupation");
			Field<IdGraphType>("projectId");
		}
	}
}
