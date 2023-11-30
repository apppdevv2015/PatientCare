using System;
using System.Collections.Generic;

namespace Healthcare.Entity.ViewModels
{
    public class EducationViewModel
    {
        public virtual ICollection<EducationDto> EducationDto { get; set; }
        public virtual ICollection<CertificationDto> CertificationDto { get; set; }

    }
}
