﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    class BillingAcounts : Account
    {


        public BillingAcounts(int id,
            decimal balance, string firstName, string lastName, long pesel)
            : base(id, balance, firstName, lastName, pesel)
        {


        }
        public override string TypeName()
        {
            return "ROZLIECZNIOWE";
        }
    }
}
