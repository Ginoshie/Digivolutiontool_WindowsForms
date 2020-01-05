namespace DigimonWorldTools_WindowsForms.EvolutionTool.Common.MessageboxTextMessages
{
    public static class MessageBoxWarningTextMessages
    {
        private static readonly string NummericOnly = "You may only enter numbers in the textbox labeled: \"{0}\". \n ";

        public static string NumericOnly(string textBox)
        {
            return string.Format(NummericOnly, textBox);
        }
    }
}
