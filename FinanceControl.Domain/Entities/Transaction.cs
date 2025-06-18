using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceControl.Domain.Entities;
public enum TransactionType
{
    Income,
    Expense
}
public class Transaction
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }

    public decimal Amount { get; set; }
    public string Description { get; set; } = default!;
    public TransactionType Type { get; set; }
    public DateTime Date {  get; set; }
}
