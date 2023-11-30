using System;
using System.Collections.Generic;
using System.Text;

namespace Healthcare.Entity.ViewModels
{
    public class HepatitisBSeriesInformation
    {
        public string Id { get; set; }
        public bool RefusedToTakeHepatitisBSeriesInPast { get; set; }
        public bool WantToHaveHepatitisBSeries { get; set; }
        public bool AlreadyHapititisBSeriesDone { get; set; }
    }
}
