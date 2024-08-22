namespace Curriculum_Vitae_Project.Model.Items
{
	public class Project
	{
		public Guid Id { get; set; }

		public string Name { get; set; } = string.Empty;

		public string Description { get; set; } = string.Empty;

		public Grade Grade { get; set; }
		 
		public List<Person> Authors { get; set; } = [];

	}
}
