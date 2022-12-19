namespace DigimonWorldTools_WindowsForms.EvoTool.Common.MessageboxTextMessages;

public static class Warnings
{
    private static readonly string NummericOnly = "You may only enter numbers in the textbox labeled: \"{0}\". \n ";

    public static string NumericOnly(string textBox)
    {
        return string.Format(NummericOnly, textBox);
    }
}