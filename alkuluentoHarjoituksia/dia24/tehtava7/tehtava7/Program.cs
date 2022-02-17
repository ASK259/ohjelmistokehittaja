using System;

namespace Tehtava7
{
    class Program
    {
        static void Main()
        {
            /*var (a, b) = GetMultipleValue();
            Tuple<int, int> tuple = GetMultipleValue();
            public static Tuple<int, int> GetMultipleValue()
            {
                return Tuple.Create(1, 2);
            }*/
            static string alleKaky(string alKa)
            {
                char[] arr;
                arr = alKa.ToCharArray();
                switch (arr[0])
                {
                    case '1':
                        alKa = "yksitoista";
                        break;
                    case '2':
                        alKa = "kaksitoista";
                        break;
                    case '3':
                        alKa = "kolmetoista";
                        break;
                    case '4':
                        alKa = "neljätoista";
                        break;
                    case '5':
                        alKa = "viisitoista";
                        break;
                    case '6':
                        alKa = "kuusitoista";
                        break;
                    case '7':
                        alKa = "seitsämäntoista";
                        break;
                    case '8':
                        alKa = "kahdeksantoista";
                        break;
                    case '9':
                        alKa = "yhdeksäntoista";
                        break;
                    default:
                        alKa = "kymmenen";
                        break;
                }

                return alKa;
            }
            static string alleSata(string alSa)
            {
                char[] arr;
                arr = alSa.ToCharArray();
                if (arr[0] == '1')
                {   
                    switch(arr[1])
                    {
                        case '0':
                            alSa = "kymmenen";
                            break;
                        case '1':
                            alSa = "yksitoista";
                            break;
                        case '2':
                            alSa = "kaksitoista";
                            break;
                        case '3':
                            alSa = "kolmetoista";
                            break;
                        case '4':
                            alSa = "neljätoista";
                            break;
                        case '5':
                            alSa = "viisitoista";
                            break;
                        case '6':
                            alSa = "kuusitoista";
                            break;
                        case '7':
                            alSa = "seitsämäntoista";
                            break;
                        case '8':
                            alSa = "kahdeksantoista";
                            break;
                        case '9':
                            alSa = "yhdeksäntoista";
                            break;
                    }
                }
                else if (arr[0] == '2')
                {
                    alSa = "kaksikymmentä";
                    switch(arr[1])
                    { 
                        case '1':
                            string apu = arr[1].ToString();
                            string apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '2':
                             apu = arr[1].ToString();
                             apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '3':
                             apu = arr[1].ToString();
                             apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '4':
                             apu = arr[1].ToString();
                             apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '5':
                             apu = arr[1].ToString();
                             apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '6':
                             apu = arr[1].ToString();
                             apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '7':
                             apu = arr[1].ToString();
                             apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '8':
                             apu = arr[1].ToString();
                             apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '9':
                             apu = arr[1].ToString();
                             apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                    }
                }
                else if (arr[0] == '3')
                {
                    alSa = "kolmekymmentä";
                    switch (arr[1])
                    {
                        case '1':
                            string apu = arr[1].ToString();
                            string apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '2':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '3':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '4':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '5':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '6':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '7':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '8':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '9':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                    }
                }
                else if (arr[0] == '4')
                {
                    alSa = "neljäkymmentä";
                    switch (arr[1])
                    {
                        case '1':
                            string apu = arr[1].ToString();
                            string apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '2':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '3':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '4':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '5':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '6':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '7':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '8':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '9':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                    }
                }
                else if (arr[0] == '5')
                {
                    alSa = "viisikymmentä";
                    switch (arr[1])
                    {
                        case '1':
                            string apu = arr[1].ToString();
                            string apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '2':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '3':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '4':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '5':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '6':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '7':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '8':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '9':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                    }
                }
                else if (arr[0] == '6')
                {
                    alSa = "kuusikymmentä";
                    switch (arr[1])
                    {
                        case '1':
                            string apu = arr[1].ToString();
                            string apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '2':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '3':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '4':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '5':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '6':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '7':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '8':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '9':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                    }
                }
                else if (arr[0] == '7')
                {
                    alSa = "seitsämänkymmentä";
                    switch (arr[1])
                    {
                        case '1':
                            string apu = arr[1].ToString();
                            string apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '2':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '3':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '4':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '5':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '6':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '7':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '8':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '9':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                    }
                }
                else if (arr[0] == '8')
                {
                    alSa = "kahdeksankymmentä";
                    switch (arr[1])
                    {
                        case '1':
                            string apu = arr[1].ToString();
                            string apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '2':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '3':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '4':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '5':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '6':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '7':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '8':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '9':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                    }
                }
                else if (arr[0] == '9')
                {
                    alSa = "yhdeksänkymmentä";
                    switch (arr[1])
                    {
                        case '1':
                            string apu = arr[1].ToString();
                            string apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '2':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '3':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '4':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '5':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '6':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '7':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '8':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                        case '9':
                            apu = arr[1].ToString();
                            apu1 = alleKymmenen(apu);
                            alSa += apu1;
                            break;
                    }
                }
                return alSa;
            }
            static string alleTuhat(string alTu)
            {
                char[] arr;
                arr = alTu.ToCharArray();
                string apu1;
                string apu2;
                string apu3;
                string apu4;
                string apu5 = " kymmenen";
                if (arr[0] == '1')
                {
                    alTu = "sata";
                    switch (arr[1])
                    {
                        case '0':
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata";
                                    break;
                            }
                            break;
                        case '1':
                            switch (arr[2])
                            {
                                case '1':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '2':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '3':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '4':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '5':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '6':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '7':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '8':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '9':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                default:
                                    alTu += apu5;
                                    break;

                            }
                            break;
                        case '2':
                            alTu = "sata kaksikymmentä ";
                            switch (arr[2])
                            {   
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata kaksikymmentä";
                                    break;
                            }
                            break;
                        case '3':
                            alTu = "sata kolmekymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata kolmekymmentä";
                                    break;
                            }
                            break;
                        case '4':
                            alTu = "sata neljäkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata neljäkymmentä";
                                    break;
                            }
                            break;
                        case '5':
                            alTu = "sata viisikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata viisikymmentä";
                                    break;
                            }
                            break;
                        case '6':
                            alTu = "sata kuusikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata kuusikymmentä";
                                    break;
                            }
                            break;
                        case '7':
                            alTu = "sata seitsämänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata seitsämänkymmentä";
                                    break;
                            }
                            break;
                        case '8':
                            alTu = "sata kahdeksankymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata kahdeksankymmentä";
                                    break;
                            }
                            break;
                        case '9':
                            alTu = "sata yhdeksänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata yhdeksänkymmentä";
                                    break;
                            }
                            break;
                    }
                   
                }
                    
                else if (arr[0] == '2')
                {
                    alTu = "kaksisataa";
                    switch (arr[1])
                    {
                        case '0':
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata";
                                    break;
                            }
                            break;
                        case '1':
                            switch (arr[2])
                            {
                                case '1':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '2':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '3':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '4':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '5':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '6':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '7':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '8':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '9':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                default:
                                    alTu += apu5;
                                    break;
                            }
                            break;
                        case '2':
                            alTu = "kaksisataa kaksikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata kaksikymmentä";
                                    break;
                            }
                            break;
                        case '3':
                            alTu = "kaksisataa kolmekymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata kolmekymmentä";
                                    break;
                            }
                            break;
                        case '4':
                            alTu = "kaksisataa neljäkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata neljäkymmentä";
                                    break;
                            }
                            break;
                        case '5':
                            alTu = "kaksisataa viisikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata viisikymmentä";
                                    break;
                            }
                            break;
                        case '6':
                            alTu = "kaksisataa kuusikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata kuusikymmentä";
                                    break;
                            }
                            break;
                        case '7':
                            alTu = "kaksisataa seitsämänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata seitsämänkymmentä";
                                    break;
                            }
                            break;
                        case '8':
                            alTu = "kaksisataa kahdeksankymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata kahdeksankymmentä";
                                    break;
                            }
                            break;
                        case '9':
                            alTu = "kaksisataa yhdeksänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata yhdeksänkymmentä";
                                    break;
                            }
                            break;
                    }

                }
                else if (arr[0] == '3')
                {
                    alTu = "kolmesataa";
                    switch (arr[1])
                    {
                        case '0':
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata";
                                    break;
                            }
                            break;
                        case '1':
                            switch (arr[2])
                            {
                                case '1':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '2':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '3':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '4':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '5':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '6':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '7':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '8':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '9':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                default:
                                    alTu += apu5;
                                    break;
                            }
                            break;
                        case '2':
                            alTu = "kolmesataa kaksikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata kaksikymmentä";
                                    break;
                            }
                            break;
                        case '3':
                            alTu = "kolmesataa kolmekymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata kolmekymmentä";
                                    break;
                            }
                            break;
                        case '4':
                            alTu = "kolmesataa neljäkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata neljäkymmentä";
                                    break;
                            }
                            break;
                        case '5':
                            alTu = "kolmesataa viisikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata viisikymmentä";
                                    break;
                            }
                            break;
                        case '6':
                            alTu = "kolmesataa kuusikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata kuusikymmentä";
                                    break;
                            }
                            break;
                        case '7':
                            alTu = "kolmesataa seitsämänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata seitsämänkymmentä";
                                    break;
                            }
                            break;
                        case '8':
                            alTu = "kolmesataa kahdeksankymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata kahdeksankymmentä";
                                    break;
                            }
                            break;
                        case '9':
                            alTu = "kolmesataa yhdeksänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "sata yhdeksänkymmentä";
                                    break;
                            }
                            break;
                    }

                }
                else if (arr[0] == '4')
                {
                    alTu = "neljäsataa";
                    switch (arr[1])
                    {
                        case '0':
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "neljäsataa";
                                    break;
                            }
                            break;
                        case '1':
                            switch (arr[2])
                            {
                                case '1':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '2':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '3':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '4':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '5':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '6':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '7':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '8':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '9':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                default:
                                    alTu += apu5;
                                    break;
                            }
                            break;
                        case '2':
                            alTu = "neljäsataa kaksikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "neljäsataa kaksikymmentä";
                                    break;
                            }
                            break;
                        case '3':
                            alTu = "neljäsataa kolmekymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "neljäsataa kolmekymmentä";
                                    break;
                            }
                            break;
                        case '4':
                            alTu = "neljäsataa neljäkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "neljäsataa neljäkymmentä";
                                    break;
                            }
                            break;
                        case '5':
                            alTu = "neljäsataa viisikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "neljäsataa viisikymmentä";
                                    break;
                            }
                            break;
                        case '6':
                            alTu = "neljäsataa kuusikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "neljäsataa kuusikymmentä";
                                    break;
                            }
                            break;
                        case '7':
                            alTu = "neljäsataa seitsämänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "neljäsataa seitsämänkymmentä";
                                    break;
                            }
                            break;
                        case '8':
                            alTu = "neljäsataa kahdeksankymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "neljäsataa kahdeksankymmentä";
                                    break;
                            }
                            break;
                        case '9':
                            alTu = "neljäsataa yhdeksänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "neljäsataa yhdeksänkymmentä";
                                    break;
                            }
                            break;
                    }

                }
                else if (arr[0] == '5')
                {
                    alTu = "viisisataa";
                    switch (arr[1])
                    {
                        case '0':
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "viisisataa";
                                    break;
                            }
                            break;
                        case '1':
                            switch (arr[2])
                            {
                                case '1':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '2':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '3':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '4':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '5':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '6':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '7':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '8':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '9':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                default:
                                    alTu += apu5;
                                    break;
                            }
                            break;
                        case '2':
                            alTu = "viisisataa kaksikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "viisisataa kaksikymmentä";
                                    break;
                            }
                            break;
                        case '3':
                            alTu = "viisisataa kolmekymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "viisisataa kolmekymmentä";
                                    break;
                            }
                            break;
                        case '4':
                            alTu = "viisisataa neljäkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "viisisataa neljäkymmentä";
                                    break;
                            }
                            break;
                        case '5':
                            alTu = "viisisataa viisikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "viisisataa viisikymmentä";
                                    break;
                            }
                            break;
                        case '6':
                            alTu = "viisisataa kuusikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "viisisataa kuusikymmentä";
                                    break;
                            }
                            break;
                        case '7':
                            alTu = "viisisataa seitsämänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "viisisataa seitsämänkymmentä";
                                    break;
                            }
                            break;
                        case '8':
                            alTu = "viisisataa kahdeksankymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "viisisataa kahdeksankymmentä";
                                    break;
                            }
                            break;
                        case '9':
                            alTu = "viisisataa yhdeksänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "viisisataa yhdeksänkymmentä";
                                    break;
                            }
                            break;
                    }

                }
                else if (arr[0] == '6')
                {
                    alTu = "kuusisataa";
                    switch (arr[1])
                    {
                        case '0':
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kuusisataa";
                                    break;
                            }
                            break;
                        case '1':
                            switch (arr[2])
                            {
                                case '1':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '2':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '3':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '4':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '5':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '6':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '7':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '8':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '9':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                default:
                                    alTu += apu5;
                                    break;
                            }
                            break;
                        case '2':
                            alTu = "kuusisataa kaksikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kuusisataa kaksikymmentä";
                                    break;
                            }
                            break;
                        case '3':
                            alTu = "kuusisataa kolmekymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kuusisataa kolmekymmentä";
                                    break;
                            }
                            break;
                        case '4':
                            alTu = "kuusisataa neljäkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kuusisataa neljäkymmentä";
                                    break;
                            }
                            break;
                        case '5':
                            alTu = "kuusisataa viisikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kuusisataa viisikymmentä";
                                    break;
                            }
                            break;
                        case '6':
                            alTu = "kuusisataa kuusikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kuusisataa kuusikymmentä";
                                    break;
                            }
                            break;
                        case '7':
                            alTu = "kuusisataa seitsämänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kuusisataa seitsämänkymmentä";
                                    break;
                            }
                            break;
                        case '8':
                            alTu = "kuusisataa kahdeksankymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kuusisataa kahdeksankymmentä";
                                    break;
                            }
                            break;
                        case '9':
                            alTu = "kuusisataa yhdeksänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kuusisataa yhdeksänkymmentä";
                                    break;
                            }
                            break;
                    }

                }
                else if (arr[0] == '7')
                {
                    alTu = "seitsämänsataa";
                    switch (arr[1])
                    {
                        case '0':
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "seitsämänsataa";
                                    break;
                            }
                            break;
                        case '1':
                            switch (arr[2])
                            {
                                case '1':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '2':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '3':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '4':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '5':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '6':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '7':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '8':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '9':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                default:
                                    alTu += apu5;
                                    break;
                            }
                            break;
                        case '2':
                            alTu = "seitsämänsataa kaksikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "seitsämänsataa kaksikymmentä";
                                    break;
                            }
                            break;
                        case '3':
                            alTu = "seitsämänsataa kolmekymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "seitsämänsataa kolmekymmentä";
                                    break;
                            }
                            break;
                        case '4':
                            alTu = "seitsämänsataa neljäkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "seitsämänsataa neljäkymmentä";
                                    break;
                            }
                            break;
                        case '5':
                            alTu = "seitsämänsataa viisikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "seitsämänsataa viisikymmentä";
                                    break;
                            }
                            break;
                        case '6':
                            alTu = "seitsämänsataa kuusikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "seitsämänsataa kuusikymmentä";
                                    break;
                            }
                            break;
                        case '7':
                            alTu = "seitsämänsataa seitsämänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "seitsämänsataa seitsämänkymmentä";
                                    break;
                            }
                            break;
                        case '8':
                            alTu = "seitsämänsataa kahdeksankymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "seitsämänsataa kahdeksankymmentä";
                                    break;
                            }
                            break;
                        case '9':
                            alTu = "seitsämänsataa yhdeksänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "seitsämänsataa yhdeksänkymmentä";
                                    break;
                            }
                            break;
                    }

                }
                else if (arr[0] == '8')
                {
                    alTu = "kahdeksansataa";
                    switch (arr[1])
                    {
                        case '0':
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kahdeksansataa";
                                    break;
                            }
                            break;
                        case '1':
                            switch (arr[2])
                            {
                                case '1':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '2':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '3':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '4':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '5':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '6':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '7':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '8':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '9':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                default:
                                    alTu += apu5;
                                    break;
                            }
                            break;
                        case '2':
                            alTu = "kahdeksansataa kaksikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kahdeksansataa kaksikymmentä";
                                    break;
                            }
                            break;
                        case '3':
                            alTu = "kahdeksansataa kolmekymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kahdeksansataa kolmekymmentä";
                                    break;
                            }
                            break;
                        case '4':
                            alTu = "kahdeksansataa neljäkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kahdeksansataa neljäkymmentä";
                                    break;
                            }
                            break;
                        case '5':
                            alTu = "kahdeksansataa viisikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kahdeksansataa viisikymmentä";
                                    break;
                            }
                            break;
                        case '6':
                            alTu = "kahdeksansataa kuusikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kahdeksansataa kuusikymmentä";
                                    break;
                            }
                            break;
                        case '7':
                            alTu = "kahdeksansataa seitsämänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kahdeksansataa seitsämänkymmentä";
                                    break;
                            }
                            break;
                        case '8':
                            alTu = "kahdeksansataa kahdeksankymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kahdeksansataa kahdeksankymmentä";
                                    break;
                            }
                            break;
                        case '9':
                            alTu = "kahdeksansataa yhdeksänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "kahdeksansataa yhdeksänkymmentä";
                                    break;
                            }
                            break;
                    }

                }
                else if (arr[0] == '9')
                {
                    alTu = "yhdeksänsataa";
                    switch (arr[1])
                    {
                        case '0':
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "yhdeksänsataa";
                                    break;
                            }
                            break;
                        case '1':
                            switch (arr[2])
                            {
                                case '1':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '2':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '3':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '4':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '5':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '6':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '7':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '8':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                case '9':
                                    apu3 = arr[2].ToString();
                                    apu4 = alleKaky(apu3);
                                    alTu += apu4;
                                    break;
                                default:
                                    alTu += apu5;
                                    break;
                            }
                            break;
                        case '2':
                            alTu = "yhdeksänsataa kaksikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "yhdeksänsataa kaksikymmentä";
                                    break;
                            }
                            break;
                        case '3':
                            alTu = "yhdeksänsataa kolmekymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "yhdeksänsataa kolmekymmentä";
                                    break;
                            }
                            break;
                        case '4':
                            alTu = "yhdeksänsataa neljäkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "yhdeksänsataa neljäkymmentä";
                                    break;
                            }
                            break;
                        case '5':
                            alTu = "yhdeksänsataa viisikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "yhdeksänsataa viisikymmentä";
                                    break;
                            }
                            break;
                        case '6':
                            alTu = "yhdeksänsataa kuusikymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "yhdeksänsataa kuusikymmentä";
                                    break;
                            }
                            break;
                        case '7':
                            alTu = "yhdeksänsataa seitsämänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "yhdeksänsataa seitsämänkymmentä";
                                    break;
                            }
                            break;
                        case '8':
                            alTu = "yhdeksänsataa kahdeksankymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "yhdeksänsataa kahdeksankymmentä";
                                    break;
                            }
                            break;
                        case '9':
                            alTu = "yhdeksänsataa yhdeksänkymmentä ";
                            switch (arr[2])
                            {
                                case '1':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '2':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '3':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '4':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '5':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '6':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '7':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '8':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                case '9':
                                    apu1 = arr[2].ToString();
                                    apu2 = alleKymmenen(apu1);
                                    alTu += apu2;
                                    break;
                                default:
                                    alTu = "yhdeksänsataa yhdeksänkymmentä";
                                    break;
                            }
                            break;
                    }

                }
                return alTu;
            }
            Console.WriteLine("Kirjoita luku se tulostetaan kirjoitettuna.");
            tahan:
            Console.Write("Syötä luku(0-999): ");
            string lul;
            lul = Console.ReadLine();
            if(lul.Length < 2)
            {
                string tul = alleKymmenen(lul);
                Console.WriteLine("test2");
            }
            else if (lul.Length < 3)
            {
                string tul2 = alleSata(lul);
                Console.WriteLine("{0}", tul2);
            }
            else if (lul.Length < 4)
            {
                string tul3 = alleTuhat(lul);
                Console.WriteLine("{0}", tul3);
            }
            else
            {
                Console.WriteLine("Annettu väärän kokoinen luku!");
                goto tahan;
            }
            static string alleKymmenen(string alKy)
            {
                switch (alKy)
                {
                    case "0":
                        alKy = "nolla";
                        break;
                    case "1":
                        alKy = "yksi";
                        break;
                    case "2":
                        alKy = "kaksi";
                        break;
                    case "3":
                        alKy = "kolme";
                        break;
                    case "4":
                        alKy = "neljä";
                        break;
                    case "5":
                        alKy = "viisi";
                        break;
                    case "6":
                        alKy = "kuusi";
                        break;
                    case "7":
                        alKy = "seitsämän";
                        break;
                    case "8":
                        alKy = "kahdeksan";
                        break;
                    case "9":
                        alKy = "yhdeksän";
                        break;
                }
                return alKy;
            }
        }
    }
}
