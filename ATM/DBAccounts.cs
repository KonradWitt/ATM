//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATM
{
    using System;
    using System.Collections.Generic;
    
    public partial class DBAccounts
    {
        public int Number { get; set; }
        public int Pin { get; set; }
        public double Balance { get; set; }
        public int RemainingLoginAttempts { get; set; }
        public bool Locked { get; set; }
    }
}