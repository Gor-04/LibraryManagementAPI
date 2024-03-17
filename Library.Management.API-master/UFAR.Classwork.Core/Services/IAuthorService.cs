using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public interface IAuthorService
    {
        void AddAuthor(AuthorEntity author);
        void DeleteAuthor(int authorId);
        void UpdateAuthor(AuthorEntity author);
        List<AuthorEntity> GetAllAuthors();
        AuthorEntity GetAuthorById(int authorId);

    }
}
