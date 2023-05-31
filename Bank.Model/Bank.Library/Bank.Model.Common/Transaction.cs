﻿using System;

namespace Bank.Model.Common
{
    public class Transaction : EntityBase
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }

    }
}
