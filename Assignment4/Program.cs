using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public static class Program
    {
        /// <summary>
        /// Name : Yoonseop Lee
        /// Student number : 301037418
        /// Date last Modified : July 20th, 2019 
        /// Program description : This is BMI Calculater where users can calculate their BMI
        /// 
        /// Revision History : 
        ///     Ver1.0 Added UI and fundamental Calculation logic
        ///     Ver1.1 Added MultiLineTextBox function , read-only result TextBoxs with background and  foreground color ,and refactoring
        ///     Ver1.2 Added SplashForm, Progress bar, and clear button
        ///     Ver1.3 Fixed radio toggle buttons, Multi Line Text Box, Added touch pad and bunch of refactorings
        ///     Ver2.0 (COMPLETED) Added MouseDown event for textbox, HealthConditionIndex Image, backButton Image, UI Layout consitency, DecimalExist Function,  Input maxSize control
        ///     Ver2.1 Added dictionary instead of instantiation for each, fixed naming convention (instance variables) , fixed control name more intutive
        ///     Ver2.2 Fixed unappropriate name
        /// </summary>

        public static Dictionary<string, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<string, Form>();
            Forms.Add("splashForm", new SplashForm());
            Forms.Add("BMICalculatorForm", new BMICalculatorForm());

            Application.Run(Forms["splashForm"]);
        }
    }
}
