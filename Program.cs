namespace checkers.Classes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            SettingsForm FormSetting = new SettingsForm();
            Application.Run(FormSetting);
            if (FormSetting.isCorrect == true)
            {
                CheckersForm checkersForm = new CheckersForm();
                checkersForm.ShowDialog();
            }
        }
    }
}