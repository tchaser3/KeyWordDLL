/* Title:           Key Word Seach Class
 * Date:            3-13-16
 * Author:          Terry Holmes
 *
 * Description:     This class is the keyword search */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWordDLL
{
    public class KeyWordClass
    {
        public bool FindKeyWord(string strKeyWordForSearch, string strKeyWordFromTable)
        {
            bool blnItemNotFound = true;
            int intKeyWordLengthFromTable = 0;
            char[] chaKeyWordInputArray = new char[strKeyWordFromTable.Length];
            int intKeywordCounter = 0;
            int intKeywordLengthForSearch = 0;
            int intCharacterCounter = 0;
            int intCounter = 0;
            string strTempString = "";
            int intStringCounter = 0;

            //getting lengths
            intKeywordLengthForSearch = strKeyWordForSearch.Length - 1;
            intKeyWordLengthFromTable = strKeyWordFromTable.Length - 1;
            intCharacterCounter = intKeywordLengthForSearch;

            //loading the character array
            chaKeyWordInputArray = strKeyWordFromTable.ToCharArray();

            //beginning if statements for testing
            if (intKeywordLengthForSearch <= intKeyWordLengthFromTable)
            {
                for (intCounter = 0; intCounter <= intKeyWordLengthFromTable; intCounter++)
                {
                    //Beginning second loop for character counter
                    for (intKeywordCounter = intCounter; intKeywordCounter <= intCharacterCounter; intKeywordCounter++)
                    {
                        strTempString = strTempString + Convert.ToString(chaKeyWordInputArray[intKeywordCounter]);
                    }

                    //Setting up for the next loop
                    if (intCharacterCounter < intKeyWordLengthFromTable)
                    {
                        intCharacterCounter++;
                    }

                    if (strTempString == strKeyWordForSearch)
                    {
                        blnItemNotFound = false;
                    }

                    intStringCounter = strTempString.Length - 1;
                    if (intKeywordLengthForSearch == intStringCounter)
                    {
                        strTempString = "";
                    }
                }

                //clearing the temp variable
                strTempString = "";
            }
            else
            {
                //Checking to see if the keywords match
                if (strKeyWordForSearch == strKeyWordFromTable)
                {
                    blnItemNotFound = false;
                }
            }

            //returning value to calling sup routine
            return blnItemNotFound;
        }
    }
}
