using System;
using System.Collections.Generic;
using System.Text;

namespace Healthcare.Entity.ViewModels
{
    public class CredibleEvidenceOfAbuseNeglect
    {
        public string Id { get; set; }
        public DateTime CredibleEvidenceFillingDate { get; set; }
        public string Witness { get; set; }
        public string NotaryPublic { get; set; }
        public DateTime CommissionExpiresOn { get; set; }
    }
}
