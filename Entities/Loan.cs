using Cp1Biblioteca.Domain.Commons;
using Cp1Biblioteca.Domain.Entities;

namespace Cp1Biblioteca.Entities;

public class Loan : BaseEntity
{
    public DateTime Date { get; private set; }
    public DateTime ExpectedReturnDate { get; private set; }
    public DateTime ReturnDate { get; private set; }
    public Guid BookId { get; private set; }
    public Guid UserId { get; private set; }
    
    public Loan(DateTime date, DateTime expectedReturnDate, DateTime returnDate, Guid bookId, Guid userId)
    {
        Date = date;
        ExpectedReturnDate = expectedReturnDate;
        ReturnDate = returnDate;
        BookId = bookId;
        UserId = userId;
    }
}