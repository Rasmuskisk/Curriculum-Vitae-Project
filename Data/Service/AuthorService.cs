using Curriculum_Vitae_Project.EFContext;
using Curriculum_Vitae_Project.Model.Items;

namespace Curriculum_Vitae_Project.Data.Service
{
	public class AuthorService : IAuthorService
	{
		private readonly DataContext _context;

		public AuthorService(DataContext context)
		{
			_context = context;
		}

		public Person CreateAuthor(Person author)
		{
			_context.Authors.Add(author);
			_context.SaveChanges();
			return author;
		}
	}
}
