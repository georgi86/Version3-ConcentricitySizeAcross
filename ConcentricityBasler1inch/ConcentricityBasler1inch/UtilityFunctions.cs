using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConcentricityBasler1inch
{

        public class MathConcentricity
        {
            private static bool Calculation(double dConcentricityExpression, double EPSILONE)
            {
                return System.Math.Abs(dConcentricityExpression) < EPSILONE;
            }

            public static bool Compare(double first, double second, double EPSILONE)
            {
                return Calculation(first - second, EPSILONE);
            }
        }
        public class MathSizeAcross
        {
            private static bool Calculation(double dConcentricityExpression, double EPSILONE)
            {
                return System.Math.Abs(dConcentricityExpression) < EPSILONE;
            }

            public static bool Compare(double first, double second, double EPSILONE)
            {
                return Calculation(first - second, EPSILONE);
            }
        }

        public class ReportAction
        {
            public static void RunPositiveResult()
            {
                //string Value = "Actual Value is: " + dActualValue;
                Ranorex.Report.Success("Sucessfully Performed ");
            }

            public static void RunNegativeResult(double dActualValue, double dHardcodedValue, int nErrorLine)
            {

                string errLine = "Error on line: " + (nErrorLine + 1);
                Ranorex.Report.Error(errLine);

                string ActualValue = "Actual Value is: " + dActualValue;
                Ranorex.Report.Error(ActualValue);

                string HardcodedValue = "Hardcoded value is: " + dHardcodedValue;
                Ranorex.Report.Error(HardcodedValue);


            }
        }

    class UtilityRun
    {
        public static void RunConcentricity(string Actual, string Hardcoded)
        {
            string[] readActualLines = File.ReadAllLines(Actual);
            string[] readHardcodedLines = File.ReadAllLines(Hardcoded);

            int iNumConcentricityRows = readActualLines.Length;
            int iNumHardcodedRows = readHardcodedLines.Length;

            bool bAllConcentricityResultsOK = true;

            for (int i = 0; i < iNumConcentricityRows; i++)
            {
                double dActualConcentricityValue;
                double dHardcodedConcentricityValue;
                Double.TryParse(readActualLines[i], out dActualConcentricityValue);               //Double is object and Try Parse is method in this object. The idea of this method is to convert the given string to value         
                Double.TryParse(readHardcodedLines[i], out dHardcodedConcentricityValue);


                try
                {
                    bool bVerySimilar = MathConcentricity.Compare(dActualConcentricityValue, dHardcodedConcentricityValue, 0.003);

                    if (!bVerySimilar)
                    {
                        bAllConcentricityResultsOK = false;

                        ReportAction.RunNegativeResult(dActualConcentricityValue, dHardcodedConcentricityValue, i);
                    }
                }
                catch (Exception)
                {
                }

            }
                if (bAllConcentricityResultsOK)

                {
                    ReportAction.RunPositiveResult();
                }

            
        }

        public static void RunSizeAcross(string Actual, string Hardcoded)
        {
            string[] readActualLines = File.ReadAllLines(Actual);
            string[] readHardcodedLines = File.ReadAllLines(Hardcoded);

            int iNumSizeAcrossRows = readActualLines.Length;
            int iNumHardcodedRows = readHardcodedLines.Length;

            bool bAllSizeAcrossResultsOK = true;

            for (int i = 0; i < iNumSizeAcrossRows; i++)
            {
                double dActualSizeAcrossValue;
                double dHardcodedSizeAcrossValue;
                Double.TryParse(readActualLines[i], out dActualSizeAcrossValue);               //Double is object and Try Parse is method in this object. The idea of this method is to convert the given string to value         
                Double.TryParse(readHardcodedLines[i], out dHardcodedSizeAcrossValue);


                try
                {
                    bool bVerySimilar = MathConcentricity.Compare(dActualSizeAcrossValue, dHardcodedSizeAcrossValue, 0.005);

                    if (!bVerySimilar)
                    {
                        bAllSizeAcrossResultsOK = false;

                        ReportAction.RunNegativeResult(dActualSizeAcrossValue, dHardcodedSizeAcrossValue, i);
                    }
                }
                catch (Exception)
                {
                }


                if (bAllSizeAcrossResultsOK)

                {
                    ReportAction.RunPositiveResult();
                }

            }
        }

    }
}

