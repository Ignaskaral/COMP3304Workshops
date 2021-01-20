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
        private Form _newNote;
        public FishyNotes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //This class is for creating a new note. It will only create one note and it will only create it if it is not existant
        private void AddNote_Click(object sender, EventArgs e)
        {
            //Check if note hasn't been created yet
            if (_newNote == null)
            {
                //Store new note inside instanced container
                _newNote = new FishyNote();
                //Show it on the screen
                _newNote.Show();
            }
            
        }
    }
}
