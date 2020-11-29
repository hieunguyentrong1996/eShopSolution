﻿using System;
using System.Collections.Generic;
using System.Text;
using static eShopSolution.Data.Enum.EnumConstant;

namespace eShopSolution.Data.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ExternalTransactionId { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        public TransactionStatus MyProperty { get; set; }
        public string Provider { get; set; }
        public Guid UserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}