using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angel.Client
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        public bool IsLoaded { get; internal set; }
        public int LoadedProgress { get; internal set; }
        public EventHandler OnClose { get; internal set; }

        internal int GetLoadedProgress()
        {
            throw new NotImplementedException();
        }

        internal void StartLoad()
        {
            throw new NotImplementedException();
        }
    }
}
