using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{
    class Controller
    {
        private IList<FishyNote> fishyNotes = new List<FishyNote>();
        private FishyNotes fishyNote;

        public Controller()
        {
            Application.Run(new FishyNotes(fishyNotes));
        }
    }
}
