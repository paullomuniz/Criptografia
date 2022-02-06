using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia
{
    class Criptografia
    {

        public static string Encriptografar(string texto, int chave1, int chave2)
        {
            string strCrypt = String.Empty;
            string strCryptTemp = String.Empty;
            double dbCalculo;

            try
            {

                //Camada 1
                /////////////////////////////////////////////////////////////////////////

                foreach (char c in texto)
                {
                    dbCalculo = (int)c * chave1;
                    strCrypt = strCrypt + Convert.ToString(dbCalculo) + "/";
                }

                strCryptTemp = String.Empty;
                strCryptTemp = strCrypt.Remove(strCrypt.Length - 1);
                strCrypt = String.Empty;

                //Camada 2
                /////////////////////////////////////////////////////////////////////////

                foreach (char c in strCryptTemp)
                {
                    switch (c.ToString())
                    {
                        case "0":
                            strCrypt = strCrypt + "ss9+";
                            break;
                        case "1":
                            strCrypt = strCrypt + "u3n+";
                            break;
                        case "2":
                            strCrypt = strCrypt + "ssW+";
                            break;
                        case "3":
                            strCrypt = strCrypt + "nSQ+";
                            break;
                        case "4":
                            strCrypt = strCrypt + "KEA+";
                            break;
                        case "5":
                            strCrypt = strCrypt + "TBJ+";
                            break;
                        case "6":
                            strCrypt = strCrypt + "MNr+";
                            break;
                        case "7":
                            strCrypt = strCrypt + "UUN+";
                            break;
                        case "8":
                            strCrypt = strCrypt + "5qe+";
                            break;
                        case "9":
                            strCrypt = strCrypt + "HqD+";
                            break;
                        case "/":
                            strCrypt = strCrypt + "/";
                            break;
                    }
                }

                strCryptTemp = String.Empty;
                strCryptTemp = strCrypt.Remove(strCrypt.Length - 1);
                strCrypt = String.Empty;

                //Camada 3
                /////////////////////////////////////////////////////////////////////////

                foreach (char c in strCryptTemp)
                {
                    dbCalculo = (int)c * chave2;
                    strCrypt = strCrypt + Convert.ToString(dbCalculo) + "/";
                }

                strCryptTemp = String.Empty;
                strCrypt = strCrypt.Remove(strCrypt.Length - 1);
            }
            catch { }

            return strCrypt;
        }






























        public static string Descriptografar(string codigo, int chave1, int chave2)
        {
            string strCrypt = String.Empty;
            string strCryptTemp = String.Empty;
            string strTempChar;

            try
            {

                //Camada 3
                /////////////////////////////////////////////////////////////////////////

                IList<string> list4 = new List<string>(codigo.Split(new string[] { "/", }, StringSplitOptions.None));
                foreach (string element in list4)
                {
                    int intAscii = Convert.ToInt32(element);
                    intAscii = intAscii / chave2;
                    string asciichar = (Convert.ToChar(intAscii)).ToString();
                    strCrypt = strCrypt + asciichar;
                }

                strCryptTemp = strCrypt;
                strCrypt = String.Empty;

                //Camada 2
                /////////////////////////////////////////////////////////////////////////

                IList<string> list2 = new List<string>(strCryptTemp.Split(new string[] { "+", }, StringSplitOptions.None));
                foreach (string element in list2)
                {
                    switch (element)
                    {
                        case "ss9":
                            strCrypt = strCrypt + "0";
                            break;
                        case "u3n":
                            strCrypt = strCrypt + "1";
                            break;
                        case "ssW":
                            strCrypt = strCrypt + "2";
                            break;
                        case "nSQ":
                            strCrypt = strCrypt + "3";
                            break;
                        case "KEA":
                            strCrypt = strCrypt + "4";
                            break;
                        case "TBJ":
                            strCrypt = strCrypt + "5";
                            break;
                        case "MNr":
                            strCrypt = strCrypt + "6";
                            break;
                        case "UUN":
                            strCrypt = strCrypt + "7";
                            break;
                        case "5qe":
                            strCrypt = strCrypt + "8";
                            break;
                        case "HqD":
                            strCrypt = strCrypt + "9";
                            break;

                        default:

                            if (element.Contains(","))
                            {
                                strTempChar = element.Replace(",", "");
                                strCrypt = strCrypt + ",";

                                if (strTempChar == "ss9") { strCrypt = strCrypt + "0"; }
                                if (strTempChar == "u3n") { strCrypt = strCrypt + "1"; }
                                if (strTempChar == "ssW") { strCrypt = strCrypt + "2"; }
                                if (strTempChar == "nSQ") { strCrypt = strCrypt + "3"; }
                                if (strTempChar == "KEA") { strCrypt = strCrypt + "4"; }
                                if (strTempChar == "TBJ") { strCrypt = strCrypt + "5"; }
                                if (strTempChar == "MNr") { strCrypt = strCrypt + "6"; }
                                if (strTempChar == "UUN") { strCrypt = strCrypt + "7"; }
                                if (strTempChar == "5qe") { strCrypt = strCrypt + "8"; }
                                if (strTempChar == "HqD") { strCrypt = strCrypt + "9"; }
                            }
                            else if (element.Contains("/"))
                            {
                                IList<string> list3 = new List<string>(element.Split(new string[] { "/" }, StringSplitOptions.None));

                                string elemento1 = list3.ElementAt(0);
                                if (elemento1 == "ss9") { strCrypt = strCrypt + "0"; }
                                if (elemento1 == "u3n") { strCrypt = strCrypt + "1"; }
                                if (elemento1 == "ssW") { strCrypt = strCrypt + "2"; }
                                if (elemento1 == "nSQ") { strCrypt = strCrypt + "3"; }
                                if (elemento1 == "KEA") { strCrypt = strCrypt + "4"; }
                                if (elemento1 == "TBJ") { strCrypt = strCrypt + "5"; }
                                if (elemento1 == "MNr") { strCrypt = strCrypt + "6"; }
                                if (elemento1 == "UUN") { strCrypt = strCrypt + "7"; }
                                if (elemento1 == "5qe") { strCrypt = strCrypt + "8"; }
                                if (elemento1 == "HqD") { strCrypt = strCrypt + "9"; }

                                strCrypt = strCrypt + "/";

                                string elemento2 = list3.ElementAt(1);
                                if (elemento2 == "ss9") { strCrypt = strCrypt + "0"; }
                                if (elemento2 == "u3n") { strCrypt = strCrypt + "1"; }
                                if (elemento2 == "ssW") { strCrypt = strCrypt + "2"; }
                                if (elemento2 == "nSQ") { strCrypt = strCrypt + "3"; }
                                if (elemento2 == "KEA") { strCrypt = strCrypt + "4"; }
                                if (elemento2 == "TBJ") { strCrypt = strCrypt + "5"; }
                                if (elemento2 == "MNr") { strCrypt = strCrypt + "6"; }
                                if (elemento2 == "UUN") { strCrypt = strCrypt + "7"; }
                                if (elemento2 == "5qe") { strCrypt = strCrypt + "8"; }
                                if (elemento2 == "HqD") { strCrypt = strCrypt + "9"; }

                            }
                            break;
                    }
                }

                strCryptTemp = String.Empty;
                strCryptTemp = strCrypt;
                strCrypt = String.Empty;

                //Camada 1
                /////////////////////////////////////////////////////////////////////////

                IList<string> list = new List<string>(strCryptTemp.Split(new string[] { "/", }, StringSplitOptions.None));
                foreach (string element in list)
                {
                    int intAscii = Convert.ToInt32(element);
                    intAscii = intAscii / chave1;
                    string asciichar = (Convert.ToChar(intAscii)).ToString();
                    strCrypt = strCrypt + asciichar;
                }

            }
            catch { }

            return strCrypt;
        }
    }
}
