using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kursova
{
    public partial class Form1 : Form
    {
        string picture = "puzzle.bmp";

        // 4х4 - размер игрового поля
        int nw = 4, nh = 4;

        // графическая поверхность формы
        System.Drawing.Graphics g;

        // картинка
        Bitmap pics;

        // размер (ширина и высота) клетки
        int cw, ch;

        // игровое поле: хранит номера фрагментов
        // картинки
        int[,] field;

        // координаты пустой клетки
        int ex, ey;

        // признак отображения номера фишки
        Boolean showNumbers = false;
        public Form1()
        {
            InitializeComponent();
            CreatePicture();
        }
        // новая игра
        private void newGame()
        { // располагаем фишки в правильном порядке
            for (int j = 0; j < nh; j++)
                for (int i = 0; i < nw; i++)
                    field[i, j] = j * nw + i + 1;

            // последняя фишка - пустая
            field[nw - 1, nh - 1] = 0;
            ex = nw - 1; ey = nh - 1;

            this.mixer();        // перемешиваем фишки
            this.drawField();    // выводим игровое поле

        }
        // перемешивает фишки
        private void mixer()
        {
            int d;    // положение (относительно пустой) перемещаемой
            // клетки: 0 - слева; 1 - справа; 2 - сверху; 3 - снизу.

            int x, y; // перемещаемая клетка

            // генератор случайных чисел
            Random rnd = new Random();

            for (int i = 0; i < nw * nh * 10; i++)
            // nw * nh * 10 - кол-во перестановок
            {
                x = ex;
                y = ey;

                d = rnd.Next(4);
                switch (d)
                {
                    case 0: if (x > 0) x--; break;
                    case 1: if (x < nw - 1) x++; break;
                    case 2: if (y > 0) y--; break;
                    case 3: if (y < nh - 1) y++; break;
                }
                // здесь определили фишку, которую
                // нужно переместить в пустую клетку
                field[ex, ey] = field[x, y];
                field[x, y] = 0;

                // запоминаем координаты пустой фишки
                ex = x; ey = y;
            }
        }
        // отрисовывает поле
        private void drawField()
        {
            // содержимое клеток
            for (int i = 0; i < nw; i++)
                for (int j = 0; j < nh; j++)
                {
                    if (field[i, j] != 0)
                        // выводим фишку с картинкой:
                        // ( ((field[i,j] - 1) % nw) * cw,
                        //   (int)((field[i,j] - 1) / nw) * ch ) -
                        // координаты левого верхнего угла
                        // области файла-источника картинки
                        g.DrawImage(pics,
                            new Rectangle(i * cw, j * ch + menuStrip1.Height, cw, ch),
                            new Rectangle(
                                ((field[i, j] - 1) % nw) * cw,
                                ((field[i, j] - 1) / nw) * ch,
                                cw, ch),
                            GraphicsUnit.Pixel);
                    else
                        // выводим пустую фишку
                        g.FillRectangle(SystemBrushes.Control,
                            i * cw, j * ch + menuStrip1.Height, cw, ch);
                    // рисуем границу
                    g.DrawRectangle(Pens.Black,
                        i * cw, j * ch + menuStrip1.Height, cw, ch);

                    // номер фишки
                    if ((showNumbers) && field[i, j] != 0)
                        g.DrawString(Convert.ToString(field[i, j]),
                            new Font("Tahoma", 10, FontStyle.Bold),
                            Brushes.Black, i * cw + 5, j * ch + 5 + menuStrip1.Height);
                }
        }
        // проверяет, расположены ли фишки в правильном порядке
        private Boolean finish()
        {
            // координаты клетки
            int i = 0;
            int j = 0;

            int c;       // число в клетке

            // фишки расположены правильно, если
            // числа в них образуют матрицу:
            //   1  2  3  4
            //   5  6  7  8
            //   9 10 11 12
            //  13 14 15

            for (c = 1; c < nw * nh; c++)
            {
                if (field[i, j] != c) return false;

                // к следующей клетке
                if (i < nw - 1) i++;
                else { i = 0; j++; }
            }
            return true;
        }
        // перемещает фишку, на которой сделан щелчок,
        // в соседнюю пустую клетку:
        // (cx, cy) - клетка, в которой сделан щелчок,
        // (ex, ey) - пустая клетка
        private void move(int cx, int cy)
        {
            // проверим, возможен ли обмен
            if (!(((Math.Abs(cx - ex) == 1) && (cy - ey == 0)) ||
                ((Math.Abs(cy - ey) == 1) && (cx - ex == 0))))
                return;
            // обмен. переместим фишку из (x, y) в (ex, ey)
            field[ex, ey] = field[cx, cy];
            field[cx, cy] = 0;

            ex = cx; ey = cy;

            // отрисовать поле
            this.drawField();

            if (this.finish())
            {
                field[nw - 1, nh - 1] = nh * nw;
                this.drawField();

                // игра закончена. сыграть еще раз?
                // No  - завершить работу программы,
                // Yes - новая игра
                if (MessageBox.Show("Поздравляю! Вы справились с поставленной задачей!\n" +
                         "Еще раз?", "Собери картинку",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question)
                          == System.Windows.Forms.DialogResult.No)
                    this.Close();
                else this.newGame();
            }
        }
        // обработка события Paint
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawField();

        }
        // щелчок кнопкой мыши на игровом поле
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // преобразуем координаты мыши в координаты клетки
            move(e.X / cw, (e.Y - menuStrip1.Height) / ch);

        }
        // команда Новая игра
        private void новаяИграToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void CreatePicture()
        {
            try
            {
                // загружаем файл картинки
                pics = new Bitmap(picture);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Файл " + picture + " не найден.\n",
                    "Собери картинку",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
                return;
            }

            field = new int[nw, nh];

            // определяем высоту и ширину клетки (фишки)
            cw = (int)(pics.Width / nw);
            ch = (int)(pics.Height / nh);

            // установить размер клиентской (внутренней) области формы
            this.ClientSize =
                new System.Drawing.Size(cw * nw + 1, ch * nh + 1 + menuStrip1.Height);
            // рабочая графическая поверхность
            g = this.CreateGraphics();

            this.newGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void оПрограмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            
        }

        private void выборКартинкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog file_dialog = new OpenFileDialog();

            file_dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.PNG)|*.bmp;*.jpg;*.gif; *.png";

            file_dialog.Title = "Выберите картинку для новой игры...";

            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                picture = file_dialog.FileName;
                CreatePicture();
            }
        }

        private void разбитьКартинкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(nw,nh);

            form3.ShowDialog(); 

            if (form3.DialogResult == DialogResult.OK)
            {
                nw = (int)form3.numericUpDown1.Value;
                nh = (int)form3.numericUpDown2.Value;

                CreatePicture();
            }

        }
    }
}

    
