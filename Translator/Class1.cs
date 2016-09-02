using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_NDV
{
    public class Translator
    {
        public string Translate(string wordToTranslate)
        {
            string toTranslate = "apple";
            char[] array = toTranslate.ToCharArray();






            if (array[0] == 'a' ||
                array[0] == 'e' ||
                array[0] == 'i' ||
                array[0] == 'o' ||
                array[0] == 'u')
            {
                return toTranslate + "way";



            }




            else
            {
                String cont = toTranslate;





                String substring = cont.Substring(3);
                String substring2 = cont.Substring(0,2);



                return substring + "ay";


            }


        }


    }
}
