using System.Windows.Forms;

namespace Plan_Gostin
{
    public partial class Ralation : Form
    {
        public Ralation()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Начальная позиция окна(центр)
            KeyPreview = true; // горячие клавиши
        }

        private void Ralation_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) // если нажата esc, то
            {
                Close(); // закрывается форма
            }
        }
    }
}
