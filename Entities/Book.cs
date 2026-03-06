using Cp1Biblioteca.Domain.Commons;

namespace Cp1Biblioteca.Domain.Entities;

public class Book : BaseEntity
{
    public string Title { get; private set; }
    public DateTime PublicationDate { get; private set; }
    public Guid ? LoanId { get; private set; }
    public Guid AuthorId { get; private set; }
    public Guid PublisherId { get; private set; }

    public Book(string title, DateTime publicationDate, Guid loanId, Guid authorId, Guid publisherId)
    {
        Title = title;
        PublicationDate = publicationDate;
        LoanId = loanId;
        AuthorId = authorId;
        PublisherId = publisherId;
    }
}