using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{
    public partial class FishyNotes : Form
    {
        private IList<FishyNote> _noteList;
        public FishyNotes(IList<FishyNote> pListOfNotes)
        {
            _noteList = pListOfNotes;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //This class is for creating a new note. It will only create one note and it will only create it if it is not existant
        private void AddNote_Click(object sender, EventArgs e)
        {
            //Create a new FishyNote
            _noteList.Add(new FishyNote());
            //Show it to the user
            for (int i = 0; i < _noteList.Count; i++)
            {
                _noteList[i].Show();
            }

        }
    }
}
