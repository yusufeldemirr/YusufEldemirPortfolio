//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CasgemPortfolio.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblMessage
    {
        public int MessageID { get; set; }
        public string NameSurname { get; set; }
        public string SenderMail { get; set; }
        public string MessageSubject { get; set; }
        public string Content { get; set; }
    }
}
