using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Enum
{
    public class EnumConstant
    {
        public enum Status
        {
            InActive,
            Active
        }
        public enum OrderStatus
        {
            InProcess,
            Confirmed,
            Shipping,
            Success,
            Canceled
        }
        public enum TransactionStatus
        {
            Success,
            Failed
        }
    }
}
