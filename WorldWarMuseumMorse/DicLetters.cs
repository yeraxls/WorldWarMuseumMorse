using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldWarMuseumMorse
{
    public class DictLetters
    {
        public static Dictionary<char, string> GetDictLetters()
        {
            return new Dictionary<char, string>()
            {
                { 'A', ".-"},
                { 'B', "-..."},
                { 'C', "-.-."},
                { 'D', "-.."},
                { 'E', "."},
                { 'F', "..-."},
                { 'G', "--."},
                { 'H', "...."},
                { 'I', ".."},
                { 'J', ".---"},
                { 'K', "-.-"},
                { 'L', ".-.."},
                { 'M', "--"},
                { 'N', "-."},
                { 'O', "---"},
                { 'P', ".--."},
                { 'Q', "--.-"},
                { 'R', ".-."},
                { 'S', "..."},
                { 'T', "-"},
                { 'U', "..-"},
                { 'V', "...-"},
                { 'W', ".--"},
                { 'X', "-..-"},
                { 'Y', "-.--"},
                { 'Z', "--.."}
            };
        }
    }
}
