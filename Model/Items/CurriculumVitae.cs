namespace Curriculum_Vitae_Project.Model.Items
{
	public class CurriculumVitae
	{
		public Guid Id { get; set; }

		public string Name { get; set; } = string.Empty;

		public int Age { get; set; }

		public String ProfileText { get; set; } = String.Empty;

		public String Profession { get; set; } = String.Empty;

		public List<Company> Companies { get; set; } = [];

		public List<Project> Projects { get; set; } = [];

	}
}
