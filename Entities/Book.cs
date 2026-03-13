using Cp1Biblioteca.Domain.Commons;

namespace Cp1Biblioteca.Entities;

public class Book : BaseEntity
{
    public string Title { get; private set; }
    public DateTime PublicationDate { get; private set; }

    public int PublisherId { get; private set; }
    public Publisher Publisher { get; private set; }
    public List<Loan>? Loans { get; private set; }
    public List<Author> Authors { get; private set; }
    public List<Category> Categories { get; private set; }

    public Book(string title, DateTime publicationDate, int publisherId)
    {
        Title = title;
        PublicationDate = publicationDate;
        PublisherId = publisherId;
    }
}