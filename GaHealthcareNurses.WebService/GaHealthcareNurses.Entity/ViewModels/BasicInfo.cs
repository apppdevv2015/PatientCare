using System;

namespace Healthcare.Entity.ViewModels
{
    public class BasicInfo
    {
        public string ContactTime { get; set; }
        public bool? ContactPresentEmployer { get; set; }
        public bool? LawfullyBecomingEmployed { get; set; }
        public DateTime? DateAvailableToWork { get; set; }
        public int? HoursPerWeek { get; set; }
        public string AvailableToWork { get; set; }
        public bool? Trasnportation { get; set; }
        public bool? IneligibleForParticipation { get; set; }
        public string ReasonForIneligible { get; set; }
        public bool? CriminalActivity { get; set; }
    }
}
