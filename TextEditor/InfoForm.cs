using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            Font font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
            lbl.Font = font;
            lbl.Text = "Author: Ivaylo Vasilev";
            this.BackColor = Color.Aqua;
            Random rand = new Random();
            int image = rand.Next(1, 4);
            switch (image)
            {
                case 1: pbAuthor.Image = Properties.Resources.ivaka;
                    break;
                case 2: pbAuthor.Image = Properties.Resources.ivaka2;
                    break;
                case 3: pbAuthor.Image = Properties.Resources.ivaka3;
                    break;

            }
            lblInfo.Font = font;
            lblInfo.Text = "ISV TextEditor 1.0";
            Font fnt = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic);
            lblTeacher.Text = "Преподавател: доц. Тодорка Терзиева";
            lblSubject.Text = "Дисциплина: Създаване на ГПИ";
            lblSpeciality.Text = "Специалност: Софтуерни технологии и дизайн";
            lblAssistant.Text = "Асистент: Тодор Иванов";
            lblTeacher.Font = fnt;
            lblSubject.Font = fnt;
            lblSpeciality.Font = fnt;
            lblAssistant.Font = fnt;
            pbToshko.Image = Properties.Resources.toshkata;
            
        }
    }
}
