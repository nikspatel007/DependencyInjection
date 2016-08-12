using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DependencyInjection.Tests
{
    public static class Data
    {
        public static IEnumerable<TestCaseData> RegisterNumbers
        {
            get
            {
                yield return new TestCaseData(0 , "Register Patient");
                yield return new TestCaseData(1, "1");
                yield return new TestCaseData(2, "2");
                yield return new TestCaseData(3, "Register");
                yield return new TestCaseData(5, "Patient");
                yield return new TestCaseData(15, "Register Patient");
            }
        }

        public static IEnumerable<TestCaseData> DiagnoseNumbers
        {
            get
            {
                yield return new TestCaseData(0, "Diagnose Patient");
                yield return new TestCaseData(1, "1");
                yield return new TestCaseData(2, "Diagnose");
                yield return new TestCaseData(3, "3");
                yield return new TestCaseData(7, "Patient");
                yield return new TestCaseData(14, "Diagnose Patient");
            }
        }
    }
}
