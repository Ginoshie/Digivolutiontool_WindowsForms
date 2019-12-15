using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonWorldTools_WindowsForms.EvolutionTool.ReferenceValues.MessageboxTextMessages
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
