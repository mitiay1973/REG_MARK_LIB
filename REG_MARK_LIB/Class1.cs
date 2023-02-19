using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REG_MARK_LIB
{
    public class Class1
    {
        public char[] Seria = {'А','В','Е','К','М','Н','О','Р','С','Т','У','Х'};
        public int[] Region = new int[135];
        public void Regions()
        {
            int i;
            for ( i=10; i <= 99; i++)
            {
                Region[i] = i;
            }
            Region[i + 1] = 102;
            Region[i + 2] = 113;
            Region[i + 3] = 116;
            Region[i + 4] = 716;
            Region[i + 5] = 121;
            Region[i + 6] = 123;
            Region[i + 7] = 124;
            Region[i + 8] = 125;
            Region[i + 9] = 126;
            Region[i + 10] = 134;
            Region[i + 11] = 136;
            Region[i + 12] = 138;
            Region[i + 13] = 142;
            Region[i + 14] = 150;
            Region[i + 15] = 190;
            Region[i + 16] = 750;
            Region[i + 17] = 152;
            Region[i + 18] = 154;
            Region[i + 19] = 159;
            Region[i + 20] = 161;
            Region[i + 21] = 163;
            Region[i + 22] = 164;
            Region[i + 23] = 196;
            Region[i + 24] = 173;
            Region[i + 25] = 174;
            Region[i + 26] = 177;
            Region[i + 27] = 197;
            Region[i + 28] = 199;
            Region[i + 29] = 777;
            Region[i + 30] = 799;
            Region[i + 31] = 977;
            Region[i + 32] = 178;
            Region[i + 33] = 198;
            Region[i + 34] = 186;
            Region[1] = 01;
            Region[2] = 02;
            Region[3] = 03;
            Region[4] = 04;
            Region[5] = 05;
            Region[6] = 06;
            Region[7] = 07;
            Region[8] = 08;
            Region[9] = 09;
        }
        public Boolean CheckMark(String mark)
        {
            Regions();
            int reg;
            if (mark.Length==8)
            {
                string one = Convert.ToString(mark[6]);
                string two=Convert.ToString(mark[7]);
                reg = Int32.Parse(one)*10 + Int32.Parse(two);
            }
            else
            {
                string one = Convert.ToString(mark[6]);
                string two = Convert.ToString(mark[7]);
                string three = Convert.ToString(mark[8]);
                reg = Int32.Parse(one) * 100 + Int32.Parse(two)*10 + Int32.Parse(three);
            }
            for (int i = 0; i < 12; i++)
            {
                if (mark[0] == Seria[i])
                {
                    string one1 = Convert.ToString(mark[1]);
                    string two1 = Convert.ToString(mark[2]);
                    string three1 = Convert.ToString(mark[3]);
                    if ((Int32.Parse(one1) >= 0 && Int32.Parse(one1) < 10) && (Int32.Parse(two1) >= 0 && Int32.Parse(two1) < 10) && (Int32.Parse(three1) >= 0 && Int32.Parse(three1) < 10))
                    {
                        if (!(Int32.Parse(one1) == 0 && Int32.Parse(two1) == 0 && Int32.Parse(three1) == 0))
                        {
                            for (int j = 0; j < 12; j++)
                            {
                                if (mark[4] == Seria[j])
                                {
                                    for (int y = 0; y < 12; y++)
                                    {
                                        if (mark[5] == Seria[y])
                                        {
                                            for (int x = 0; x < 132; x++)
                                            {
                                                if (reg == Region[x])
                                                {
                                                    return true;

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
                return false;
        }
       public String GetNextMarkAfter(String mark)
        {
            if (CheckMark(mark))
            {
                Regions();
                int reg;
                if (mark.Length == 8)
                {
                    string one = Convert.ToString(mark[6]);
                    string two = Convert.ToString(mark[7]);
                    reg = Int32.Parse(one) * 10 + Int32.Parse(two);
                }
                else
                {
                    string one = Convert.ToString(mark[6]);
                    string two = Convert.ToString(mark[7]);
                    string three = Convert.ToString(mark[8]);
                    reg = Int32.Parse(one) * 100 + Int32.Parse(two) * 10 + Int32.Parse(three);
                }
                char S3='.';
                char S2='.';
                char S1='.';
                string one1 = Convert.ToString(mark[1]);
                string two1 = Convert.ToString(mark[2]);
                string three1 = Convert.ToString(mark[3]);
                if (Int32.Parse(one1) == 9 && Int32.Parse(two1) == 9 && Int32.Parse(three1) == 9)
                {
                    if (mark[0] == Seria[11])
                    {
                        if (mark[4] == Seria[11])
                        {
                            if (mark[5] == Seria[11])
                            {
                                return "Это был последний номер";
                            }
                            else
                            {
                                for (int i = 0; i < 11; i++)
                                {
                                    if (mark[5] == Seria[i])
                                    {
                                        S3 = Seria[i + 1];
                                    }
                                }
                                return mark[0] + "001" + mark[4] + S3 + reg;
                            }
                        }
                    }
                    if (mark[0] == Seria[11])
                    {
                        if (mark[4] != Seria[11])
                        {
                            if (mark[5] == Seria[11])
                            {
                                for (int i = 0; i < 11; i++)
                                {
                                    if (mark[4] == Seria[i])
                                    {
                                        S2 = Seria[i + 1];
                                    }
                                }
                                return mark[0] + "001" + S2 + mark[5] + reg;
                            }
                        }
                    }
                    if (mark[0] != Seria[11])
                    {
                        if (mark[4] == Seria[11])
                        {
                            if (mark[5] == Seria[11])
                            {
                                for (int i = 0; i < 11; i++)
                                {
                                    if (mark[0] == Seria[i])
                                    {
                                        S1 = Seria[i + 1];
                                    }
                                }
                                return S1 + "001" + mark[4] + mark[5] + reg;
                            }
                        }
                    }
                    if (mark[0] != Seria[11])
                    {
                        if (mark[4] != Seria[11])
                        {
                            if (mark[5] != Seria[11])
                            {
                                for (int i = 0; i < 11; i++)
                                {
                                    if (mark[5] == Seria[i])
                                    {
                                        S3 = Seria[i + 1];
                                    }
                                }
                                return mark[0] + "001" + mark[4] + S3 + reg;
                            }
                        }
                    }
                    if (mark[0] == Seria[11])
                    {
                        if (mark[4] != Seria[11])
                        {
                            if (mark[5] != Seria[11])
                            {
                                for (int i = 0; i < 11; i++)
                                {
                                    if (mark[5] == Seria[i])
                                    {
                                        S3 = Seria[i + 1];
                                    }
                                }
                                return mark[0] + "001" + mark[4] + S3 + reg;
                            }
                        }
                    }
                    if (mark[0] != Seria[11])
                    {
                        if (mark[4] == Seria[11])
                        {
                            if (mark[5] != Seria[11])
                            {
                                for (int i = 0; i < 11; i++)
                                {
                                    if (mark[5] == Seria[i])
                                    {
                                        S3 = Seria[i + 1];
                                    }
                                }                             
                                return mark[0] + "001" + mark[4] + S3 + reg;
                            }
                        }
                    }
                }
                else
                {
                    
                    int nomer= Int32.Parse(one1)*100+ Int32.Parse(two1)*10+ Int32.Parse(three1);
                    nomer += 1;
                    if(nomer<10)
                    {
                        return mark[0] + "00"+Convert.ToString(nomer) + mark[4] + mark[5] + reg;
                    }
                    else if(nomer<100)
                    {
                        return mark[0] + "0"+Convert.ToString(nomer) + mark[4] + mark[5] + reg;
                    }
                    else
                    {
                        return mark[0] + Convert.ToString(nomer) + mark[4] + mark[5] + reg;
                    }
                }
            }
            return "";
            }
        }
    }

