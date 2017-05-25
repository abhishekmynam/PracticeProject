using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class ValidParanthesis
    {
        public bool IsValid(string s)
        {
            bool isValid = false;
            List<int> thisList = new List<int>();
            int thisValue = 0;
            int charValue = 0;
            
                foreach (char c in s)
                {
                    switch (c)
                    {
                        case '(': charValue = 1; if (thisValue == 0) { thisValue = charValue; } break;
                        case ')': charValue = -1; if (thisValue == 0) { thisValue = charValue; } break;
                        case '[': charValue = 2; if (thisValue == 0) { thisValue = charValue; } break;
                        case ']': charValue = -2; if (thisValue == 0) { thisValue = charValue; } break;
                        case '{': charValue = 3; if (thisValue == 0) { thisValue = charValue; } break;
                        case '}': charValue = -3; if (thisValue == 0) { thisValue = charValue; } break;
                        default: thisValue = 0; break;
                    }
                    thisList.Add(charValue);

                    if (charValue + thisValue == 0)
                    {
                        if (thisList.Sum(x => x) == 0)
                        {
                            thisValue = 0;
                            isValid = true;
                        }
                    }
                    else if (thisValue < 0 && charValue < 0)
                    {
                        isValid = false;
                        break;
                    }
                    else isValid = false;
                }
            return isValid;
        }
    }
}
