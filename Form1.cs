using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsAppEyukinConventer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double value;
            // 1. Проверка ввода числа
            if (!double.TryParse(textBoxValue.Text, out value))
            {
                MessageBox.Show("Введите корректное число!");
                return;
            }
            string from = comboBoxFrom.Text;
            string to = comboBoxTo.Text;
            // 2. Проверка выбора единиц
            if (comboBoxFrom.SelectedIndex == -1 || comboBoxTo.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите единицы измерения!");
                return;
            }
            double result = 0, baseValue = 0;
            bool isLengthFrom = false, isMassFrom = false, isLengthTo = false, isMassTo = false;
            if (from == "Метры" || from == "Километры" || from == "Сантиметры" || from == "Миллиметры") isLengthFrom = true;
            else if (from == "Килограммы" || from == "Граммы" || from == "Миллиграммы" || from == "Тонны") isMassFrom = true;
            if (to == "Метры" || to == "Километры" || to == "Сантиметры" || to == "Миллиметры") isLengthTo = true;
            else if (to == "Килограммы" || to == "Граммы" || to == "Миллиграммы" || to == "Тонны") isMassTo = true;
            if ((isLengthFrom && isMassTo) || (isMassFrom && isLengthTo))
            {
                MessageBox.Show("Невозможно перевести длину в массу (или наоборот)!");
                return;
            }
            if (isLengthFrom)
            {
                if (from == "Метры") baseValue = value;
                else if (from == "Километры") baseValue = value * 1000;
                else if (from == "Сантиметры") baseValue = value / 100;
                else if (from == "Миллиметры") baseValue = value / 1000;
            }
            else if (isMassFrom)
            {
                if (from == "Килограммы") baseValue = value;
                else if (from == "Граммы") baseValue = value / 1000;
                else if (from == "Миллиграммы") baseValue = value / 1000000;
                else if (from == "Тонны") baseValue = value * 1000;
            }
            if (isLengthTo)
            {
                if (to == "Метры") result = baseValue;
                else if (to == "Километры") result = baseValue / 1000;
                else if (to == "Сантиметры") result = baseValue * 100;
                else if (to == "Миллиметры") result = baseValue * 1000;
            }
            else if (isMassTo)
            {
                if (to == "Килограммы") result = baseValue;
                else if (to == "Граммы") result = baseValue * 1000;
                else if (to == "Миллиграммы") result = baseValue * 1000000;
                else if (to == "Тонны") result = baseValue / 1000;
            }
            // Вывод результата
            labelResult.Text = "Результат: " + result;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxValue.Clear();
            comboBoxFrom.SelectedIndex = -1;
            comboBoxTo.SelectedIndex = -1;
            labelResult.Text = "Результат:  ";
        }
    }
}
