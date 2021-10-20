using System;
using System.Collections.Generic;

namespace NomDuLogiciel
{
    class MathEngine
    {
        #region Variable et call
        private List<string> inColumn;
        private List<string> outColumn;
        public List<double> newinColumn = new List<double>();
        public List<double> newoutColumn = new List<double>();
        private double inX, outX;
        private int exposant;
        private String filename;
        private double result;
        #endregion
        public MathEngine(List<string> inColumn, List<string> outColumn, String Filename)
        {
            this.inColumn = inColumn;
            this.outColumn = outColumn;
            this.filename = Filename;
        }

        public List<Double> getIn( )
        {
            int i = 1;
            string split1, split2;
            foreach (String listElement in inColumn)
            {
                i++;
                if (listElement.Contains("-nan;") || listElement.Contains("-nan"))
                {
                    break;
                }
                try
                {
                    string[] splitValue = listElement.Split('e');
                    split1 = splitValue[0];
                    split2 = splitValue[1];
                }
                catch (Exception)
                {
                    break;
                }

                switch (split2)
                {
                    case "+01":
                        exposant = 1;
                        break;
                    case "+02":
                        exposant = 2;
                        break;
                    case "+03":
                        exposant = 3;
                        break;
                    case "+04":
                        exposant = 4;
                        break;
                    case "+05":
                        exposant = 5;
                        break;
                    case "+06":
                        exposant = 6;
                        break;
                    case "+07":
                        exposant = 7;
                        break;
                }
                try
                {
                    inX = Convert.ToDouble(split1);
                }
                catch (Exception)
                {
                }

                Console.WriteLine("#"+ i + "< < < FLUX IN > > > " +inX * Math.Pow(10, exposant) + "< " + filename);

                newinColumn.Add(inX * Math.Pow(10, exposant) /1024 /1024);

                
            }
return newinColumn;
        }
        public List<Double> getOut()
        {
            int i = 1;
            string split1, split2;
            foreach (String listElemnt in outColumn)
            {
                 i++;
                if (listElemnt.Contains("-nan;") || listElemnt.Contains("-nan"))
                {
                    break;
                }
                try
                {
                    String[] splitValue = listElemnt.Split('e');
                    split1 = splitValue[0];
                    split2 = splitValue[1];
                }
                catch (Exception)
                {
                    break;
                }

                switch (split2)
                {
                    case "+01":
                        exposant = 1;
                        break;
                    case "+02":
                        exposant = 2;
                        break;
                    case "+03":
                        exposant = 3;
                        break;
                    case "+04":
                        exposant = 4;
                        break;
                    case "+05":
                        exposant = 5;
                        break;
                    case "+06":
                        exposant = 6;
                        break;
                    case "+07":
                        exposant = 7;
                        break;
                }
                try
                {
                    outX = Convert.ToDouble(split1);

                }
                catch (Exception)
                {

                }
                Console.WriteLine("#" + i + "< < < FLUX OUT > > > " + outX * Math.Pow(10, exposant) + "< " + filename);
                newoutColumn.Add(-outX * Math.Pow(10, exposant) / 1024 / 1024);
            }
            return newoutColumn;
        }

        //1525.2365984 ---> 0,000190625 mb
        public String test(double value)
        { 
            String test = value.ToString();
            int lenght = test.Length;

            switch (lenght)
            { case 1:
                    return test;
                case 2:
                    return test;
                case 3:
                    return test;
                case 4:
                    return test.Insert(2, ".");
                case 5:
                    Console.WriteLine(test.Insert(2, "."));
                    return test.Insert(2, "."); 
                case 6:
                    Console.WriteLine(test.Insert(3, "."));
                    return test.Insert(3, ".");
                case 7:
                    Console.WriteLine(test.Insert(2, "."));
                    return test.Insert(1, ".").Insert(5,".");
                case 8:
                    return test.Insert(2, ".").Insert(6, ".");
            }
            return "";

        }

        public String SomeDoubleValueToLisibleValue(double value)
        {
            string[] _value = value.ToString().Split(','); 
            string finalSplitOne = "";

            string finalSplitTwo = _value[1];
            switch (_value[0].Length)
            {
                case 1:
                    finalSplitOne = _value[0];
                    break;
                case 2:
                    finalSplitOne = _value[0];
                    break;
                case 3:
                    finalSplitOne = _value[0];
                    break;
                case 4: 
                    finalSplitOne = _value[0].Insert(1, " ");
                    break;
                case 5:
                    finalSplitOne = _value[0].Insert(2, " ");
                    break;
                case 6:
                    finalSplitOne =_value[0].Insert(3, " ");
                    break;
                case 7:
                    finalSplitOne = _value[0].Insert(1, " ").Insert(5, " ");
                    break;
                case 8:
                    finalSplitOne = _value[0].Insert(2, " ").Insert(6, " ");
                    break;
            }
            switch (_value[1].Length)
            {
                case 1:
                    finalSplitTwo = _value[1];
                    break;
                case 2:
                    finalSplitTwo = _value[1];
                    break;
                case 3:
                    finalSplitTwo = _value[1];
                    break;
                case 4:
                    finalSplitTwo = _value[1].Insert(1, " ");
                    break;
                case 5:
                    finalSplitTwo = _value[1].Insert(2, " ");
                    break;
                case 6:
                    finalSplitTwo = _value[1].Insert(3, " ");
                    break;
                case 7:
                    finalSplitTwo = _value[1].Insert(1, " ").Insert(5, " ");
                    break;
                case 8:
                    finalSplitTwo = _value[1].Insert(2, " ").Insert(6, " ");
                    break;
                case 9:
                    finalSplitTwo = _value[1].Insert(3, " ").Insert(7, " ");
                    break;
                case 10:

                    finalSplitTwo = _value[1].Insert(2, " ").Insert(5, " ").Insert(9, "");
                    break;
                case 11:
                    finalSplitTwo = _value[1].Insert(3, " ").Insert(7, " ").Insert(9, " ") ;
                    break;
            }
            return finalSplitOne +","+ _value[1].Substring(0,3) ;


        }
    }

}

