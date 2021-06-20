using AntiAircraftGameProject.Library.Concrete;
using System.Windows.Forms;

namespace AntiAircraftGameProject.Desktop
{
    public partial class MainForm : Form
    {
        private readonly Game _game = new Game();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _game.Start();
                    break;

                case Keys.Space:
                    _game.Fire();
                    break;

                case Keys.Right:
                    _game.MoveAircraft(Library.Enum.Direction.Right);
                    break;

                case Keys.Left:
                    _game.MoveAircraft(Library.Enum.Direction.Left);
                    break;
            }
        }
    }
}
