using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class ArithmeticProgression
        {
            private double initialTerm;
            private double commonDifference;

            public ArithmeticProgression(double initialTerm, double commonDifference)
            {
                this.initialTerm = initialTerm;
                this.commonDifference = commonDifference;
            }

            public double this[int termNumber]
            {
                get
                {
                    if (termNumber <= 0)
                        throw new ArgumentException("Term number must be a positive integer.");

                    return initialTerm + (termNumber - 1) * commonDifference;
                }
            }

            public double SumOfTerms(int termNumber)
            {
                if (termNumber <= 0)
                    throw new ArgumentException("Term number must be a positive integer.");

                return (termNumber / 2.0) * (2 * initialTerm + (termNumber - 1) * commonDifference);
            }
        }

        private ArithmeticProgression progression;
        private void calculateButton_Click(object sender, EventArgs e)
        {

            // Отримати значення номера члена прогресії з TextBox
            if (!int.TryParse(termNumberTextBox.Text, out int termNumber) || termNumber <= 0)
            {
                MessageBox.Show("Недійсне значення. Введіть дійсне додатне ціле число.");
                return;
            }

            // Задати початковий член та співвідношення прогресії
            double initialTerm = 2.0;
            double commonRatio = 3.0;

            try
            {
                // Створити об'єкт геометричної прогресії
                progression = new ArithmeticProgression(initialTerm, commonRatio);

                // Отримати значення n-го члена прогресії та суми геометричної прогрессії
                double termValue = progression[termNumber];
                double sum = progression.SumOfTerms(termNumber);

                // Вивести значення n-го члена прогресії у DataGridView, та суму в Label
                PopulateDataGridView(termNumber, termValue);
                sumLabel.Text = "Сума: " + sum.ToString();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateDataGridView(int termNumber, double termValue)
        {
            // Очистити DataGridView
            resultDataGridView.Rows.Clear();
            resultDataGridView.Columns.Clear();

            // Додати стовпці у DataGridView
            resultDataGridView.Columns.Add("Номер", "Номер");
            resultDataGridView.Columns.Add("Значення", "Значення");

            // Додати рядки з номерами членів та їх значеннями
            for (int i = 1; i <= termNumber; i++)
            {
                double value = progression[i];
                resultDataGridView.Rows.Add(i, value);
            }
        }
    }
}