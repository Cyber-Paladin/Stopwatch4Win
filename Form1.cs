using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_1_3_1_stopwatch
{
    public partial class Stopwatch4Win : Form
    {
        DateTime date;
        Timer timer;
        long tick2 = new long();
        uint hoursValue = 0;
        uint daysValue = 0;
        uint weeksValue = 0;
      public Stopwatch4Win()
      {

          InitializeComponent();
          date = DateTime.Now;
          timer = new Timer();
          timer.Interval = 25;
          timer.Tick += new EventHandler(tickTimer);
      }
        /// <summary>
        /// Инициализирует элементы при загрузке окна программы.
        /// </summary>
        /// <param name="sender">Объект,который вызвал событие.</param>
        /// <param name="e">Передача дополнительной информации обработчику событий.</param>
        private void Stopwatch4Win_Load( object sender, EventArgs e )
        {
            textCounter_label.Text = "HH : MM : SS  : FF";
            label1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;
            richTextBox1.Visible = false;
            comboBox1.Visible = false;
            button1.Enabled = false;// кнопка не доступна по умолчанию
            label2.Text = "Show available converted results";
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Italic);
            textBox1.Text = "Enter numbers";// серая подсказка внутри поля ввода
            textBox1.ForeColor = Color.Gray;
            comboBox1.Items.AddRange(new string[] { "Milisecond", "Second", "Minute", "Hour", "Day", "Week" });
            comboBox1.Text = (string)comboBox1.Items[0];
        }
     // ////////////// минимум 5 обработчиков
     // Реализация секундомера
          /// <summary>
          /// Инициализирует элемент запуска секундомера.
          /// </summary>
      private void startButton_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            timer.Start();
            
        }
          /// <summary>
          /// Инициализирует элемент отображения и изменения циферблата.
          /// </summary>
      private void tickTimer(object sender, EventArgs e)
        {
            long tick1 = (DateTime.Now.Ticks - date.Ticks) + tick2;
            DateTime stopwatch = new DateTime();
            stopwatch = stopwatch.AddTicks(tick1);
            mainCounter_label.Text = String.Format("{0:HH:mm:ss:ff}", stopwatch);
        }
          /// <summary>
          /// Инициализирует элемент остановки секундомера
          /// </summary>
      private void finishButton_Click(object sender, EventArgs e)
        {
            tick2 += DateTime.Now.Ticks - date.Ticks;
            timer.Stop();
        }
     // ///////////// минимум 5 обработчиков
     // Реализация преобразователя времени
          /// <summary>
          /// Инициализирует событие первого входа в элемент
          /// </summary>
      private void textBox1_Enter( object sender, EventArgs e )
        {
            //if (textBox1.Text!=String.Empty)
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style & FontStyle.Regular);
        }
          /// <summary>
          /// Инициализирует событие взаимодействия  элемента с клавиатурой
          /// </summary>
          /// <param name="e">Индикатор нажатия клавиши</param>
      private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 10;
            char controlInput = e.KeyChar;
            if (!Char.IsDigit(controlInput) && controlInput != 8)// 8 - код для <Backspace>
            {
                e.Handled = true;
            }
            if (textBox1.Text.Length == 0) button1.Enabled = true;
            try {
                  hoursValue = Convert.ToUInt32(textBox1.Text);
                  //if (hoursValue == UInt32.MaxValue)
                } catch (FormatException)
                      {
                        textBox1.Focus();
                      }
        }

      private void button1_Click(object sender, EventArgs e)
        {
            //CommonDialog selectDialog1 = new CommonDialog();
        }

      private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {

        }

      private void comboBox1_Click( object sender, EventArgs e )
        {
            
        }
        // ////////////// минимум 4 обработчика
        // Реализация меню окна
        private void stopwatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textCounter_label.Visible = true;   mainCounter_label.Visible = true;
            listBox1.Visible = true;            startButton.Visible = true;
            finishButton.Visible = true;
          //--------------------------------------------------------------------
            label1.Visible = false;     label2.Visible = false;
            button1.Visible = false;    textBox1.Visible = false;
            button2.Visible = false;    richTextBox1.Visible = false;
            comboBox1.Visible = false;
        }

      private void timeConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textCounter_label.Visible = false;     mainCounter_label.Visible = false;
            listBox1.Visible = false;              startButton.Visible = false;
            finishButton.Visible = false;
          //------------------------------------------------------------------------
            label1.Visible = true;      label2.Visible = true;
            button1.Visible = true;     textBox1.Visible = true;
            button2.Visible = true;     richTextBox1.Visible = true;
            comboBox1.Visible = true;
        }

      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }