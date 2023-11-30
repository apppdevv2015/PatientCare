using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Healthcare.Entity.Models
{
    public class HiringAgreements
    {
        [Key]
        [ForeignKey("Nurse")]
        public string Id { get; set; }
        public bool? AcknowledgementOfPoliciesAndProcedures { get; set; }
        public bool? JobDescription { get; set; }
        public bool? GahRegulations { get; set; }
        public bool? ConfidientiallyStatement { get; set; }
        public bool? DeclinationOfInfluenzaVaccination { get; set; }
        public DateTime? DeclinationOfInfluenzaVaccinationFillingDate { get; set; }
        public bool? FireOrSafetyProcedure { get; set; }
        public bool? CodeOfEthics { get; set; }
        public bool? AbuseNeglectAndExploitationPolicy { get; set; }
        public bool? ClientCareInEmergency { get; set; }
        public bool? CredibleEvidenceOfAbuseStatement { get; set; }
        public DateTime? CredibleEvidenceFillingDate { get; set; }
        public string Witness { get; set; }
        public string NotaryPublic { get; set; }
        public DateTime? CommissionExpiresOn { get; set; }
        public bool? HepatitisBSeries { get; set; }
        public bool? RefusedToTakeHepatitisBSeriesInPast { get; set; }
        public bool? WantToHaveHepatitisBSeries { get; set; }
        public bool? AlreadyHapititisBSeriesDone { get; set; }
        public bool? PartnershipForHealth { get; set; }
        public bool? CnaAndPcaDutiesAndResponsibilities { get; set; }
        public bool? DocumentationOfTrainingAndOrientation { get; set; }
        public virtual Nurse Nurse { get; set; }
    }
}
