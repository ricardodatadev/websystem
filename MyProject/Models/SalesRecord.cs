using System;
using MyProject.Models.Enums;

namespace MyProject.Models
{
    public class SalesRecord
    {
        public int Id { get; set; } // PascalCase
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }

        // FK explícita (muito importante)
        public int SellerId { get; set; }
        public Seller Seller { get; set; }

        // 🔹 Construtor vazio (OBRIGATÓRIO para o EF)
        public SalesRecord()
        {
        }

        // 🔹 Construtor para uso da aplicação
        public SalesRecord(DateTime date, double amount, SaleStatus status, int sellerId)
        {
            Date = date;
            Amount = amount;
            Status = status;
            SellerId = sellerId;
        }
    }
}
