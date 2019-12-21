using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class BMICalculatorForm : Form
    {
        // Properties
        public float HeightValue { get; set; }
        public float WeightValue { get; set; }
        public string HealthCondition { get; set; }
        public TextBox TextBoxToPlace { get; set; }
        public bool DecimalExist { get; set; }


        /// <summary>
        /// Constructor for TableLayoutPanel
        /// </summary>
        public BMICalculatorForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// TableLayoutPanel Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            ClearForm();
        }



        /// <summary>
        /// This event checks where the user input has to be entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            TextBoxToPlace = WeightTextBox;
        }
        private void HeightTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            TextBoxToPlace = HeightTextBox;
        }



        /// <summary>
        /// This switches the Label display that has to be shown depends on user's radion button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ImperialUnitBox.Visible = true;
            MetricUnitBox.Visible = false;
        }
        private void MetricUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetricUnitBox.Visible = true;
            ImperialUnitBox.Visible = false;
        }




        /// <summary>
        /// This stores the user input into textbox
        /// </summary>
        private void StoreInputTextBox()
        {
            try
            {
                HeightValue = float.Parse(HeightTextBox.Text);
                WeightValue = float.Parse(WeightTextBox.Text);

                // Calculate BMI using fomula
                Calculate();

                // Check Health Condition
                CheckHealthCondition();
            }
            // exception handler
            catch
            {
                ClearForm();
                ResultTextBox.Text = "Error: Enter Proper value";
            }

            ResultMultiLineTextBox.Text = $"{ResultTextBox.Text} ({HealthCondition}) \n {ResultMultiLineTextBox.Text}";
        }





        /// <summary>
        /// This checks Height, Weight TextBox input is float value otherwise disable Calculate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(HeightTextBox.Text);
                float.Parse(WeightTextBox.Text);
                CalculateResultButton.Enabled = true;
            }
            catch
            {
                CalculateResultButton.Enabled = false;
            }
        }



        
        /// <summary>
        /// This is clearForm used when the program starts or every time BMI calculated
        /// </summary>
        private void ClearForm()
        {
            WeightTextBox.Clear();
            HeightTextBox.Clear();
            ResultTextBox.Clear();
            ResultMultiLineTextBox.Clear();
            CalculateResultButton.Enabled = false;
            BMIProgressBar.Value = 0;
        }

        


        /// <summary>
        /// This is an event where one of the buttons clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClick(object sender, EventArgs e)
        {
            try
            {
                var _theButton = sender as Button;
                var _tag = _theButton.Tag.ToString();

                int _buttonValue;
                bool _resultCondition = int.TryParse(_tag, out _buttonValue);

                // If the user pressed a number button
                if (_resultCondition)
                {
                    // Blocks input if it exceed 3 digits or 5 digits with decimal points. 
                    int _maxTextSize = 3;
                    if (CheckDecimalExist())
                    {
                        _maxTextSize = 5;
                    }
                    if (TextBoxToPlace.Text.Count() < _maxTextSize)
                    {
                        TextBoxToPlace.Text += _tag;
                    }
                }

                if (!_resultCondition)
                {
                    switch (_tag)
                    {
                        case "clear":
                            ClearForm();
                            break;
                        case "back":
                            RemoveLastCharacterFromResultLabel();
                            break;
                        case "calculate":
                            StoreInputTextBox();
                            break;
                        case "decimal":
                            if (!CheckDecimalExist())
                            {
                                TextBoxToPlace.Text += _theButton.Text;
                            }
                            break;
                    }
                }
            }

            catch (Exception ButtonError)
            {
                ResultTextBox.Text = "You might have clicked the wrong place." + ButtonError.Message;
            }
        }


        /// <summary>
        /// This method checks whether last input character is .(decimal point)
        /// </summary>
        /// <returns></returns>
        private bool CheckDecimalExist()
        {
            DecimalExist = false;
            if (TextBoxToPlace.Text.Contains("."))
            {
                DecimalExist = true;
            }
            return DecimalExist;
        }


        /// <summary>
        /// This Calculates BMI depends on User Input
        /// </summary>
        private void Calculate()
        {
            // Imperial
            if (ImperialUnitRadioButton.Checked)
            {
                float HeightoutputValue = WeightValue * 703 / (HeightValue * HeightValue);
                ResultTextBox.Text = $"{HeightoutputValue:f2}";
                BMIProgressBar.Value = (int)HeightoutputValue;
            }
            // Metric
            else if (MetricUnitRadioButton.Checked)
            {
                float WeightoutputValue = WeightValue / (HeightValue * HeightValue);
                ResultTextBox.Text = $"{WeightoutputValue:f2}";
                BMIProgressBar.Value = (int)WeightoutputValue;
            }
        }



        /// <summary>
        /// This remove last char of textbox
        /// </summary>
        private void RemoveLastCharacterFromResultLabel()
        {
            if (TextBoxToPlace.Text.Length > 0)
            {
                TextBoxToPlace.Text = TextBoxToPlace.Text.Remove(TextBoxToPlace.Text.Length - 1);
            }
        }

        /// <summary>
        /// This Method decides the color where BMI progress bar will use depends on user's BMI
        /// </summary>
        private void CheckHealthCondition()
        {
            if (BMIProgressBar.Value < 18.5)
            {
                BMIProgressBar.ForeColor = Color.PaleTurquoise;
                HealthCondition = "less weight";
            }
            else if (BMIProgressBar.Value >= 18.5 && BMIProgressBar.Value < 25)
            {
                BMIProgressBar.ForeColor = Color.Green;
                HealthCondition = "perfect <3";
            }
            else if (BMIProgressBar.Value >= 25 && BMIProgressBar.Value < 30)
            {
                BMIProgressBar.ForeColor = Color.Orange;
                HealthCondition = "over weight";
            }
            else
            {
                BMIProgressBar.ForeColor = Color.Red;
                HealthCondition = "obese";
            }
        }

        /// <summary>
        /// This Terminates the application safely in the background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
