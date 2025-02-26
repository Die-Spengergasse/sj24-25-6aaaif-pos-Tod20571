using System;
using System.Collections.Generic;

namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public class Payment
    {
        public CashDesk CashDesk { get; set; }
        public DateTime PaymentDateTime { get; set; }
        public PaymentType PaymentType { get; set; }
        public Employee Employee { get; set; }
        public List<PaymentItem> PaymentItems { get; set; } = new List<PaymentItem>();
    }
}