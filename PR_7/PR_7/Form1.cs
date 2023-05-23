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

    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();
        }

        public class GeometricProgression
        {
            private double initialTerm;   // Початковий член прогресії
            private double commonRatio;   // Співвідношення прогресії

            public GeometricProgression(double initialTerm, double commonRatio)
            {
                this.initialTerm = initialTerm;
                this.commonRatio = commonRatio;
            }

            public double this[int n]
            {
                get
                {
                    if (n <= 0)
                    {
                        throw new ArgumentException("Недійсне значення. Введіть дійсне додатне ціле число.");
                    }

                    double term = initialTerm * Math.Pow(commonRatio, n - 1);
                    return term;
                }
            }

            public double SumOfTerms(int n)
            {
                if (n <= 0)
                {
                    throw new ArgumentException("Недійсне значення. Введіть дійсне додатне ціле число.");
                }

                double sum = (initialTerm * (Math.Pow(commonRatio, n) - 1)) / (commonRatio - 1);
                return sum;
            }
        }
        private GeometricProgression progression;
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
                progression = new GeometricProgression(initialTerm, commonRatio);

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