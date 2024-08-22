namespace Curriculum_Vitae_Project.Data;
using GraphQL.Types;
public class AppSchema : Schema
{
	public AppSchema(IServiceProvider provider) : base(provider)
	{
		Query = provider.GetRequiredService<Query>();
		Mutation = provider.GetRequiredService<AppMutation>();
	}
}

