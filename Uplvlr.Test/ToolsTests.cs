using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uplvlr.Test
{
    [TestClass]
    public class ToolsTests
    {
        [TestMethod]
        public void GetFileNameTest()
        {
            List<string> testFileNames = new List<string>();

            testFileNames.Add("D:\\Dev\\Uplvlr\\Uplvlr\\bin\\Debug\\netcoreapp2.1\\Uplvlr.dll");
            testFileNames.Add("C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\2.1.9\\System.Runtime.dll");
            testFileNames.Add("C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\2.1.9\\System.IO.FileSystem.dll");
            testFileNames.Add("C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\2.1.9\\System.Console.dll");
            testFileNames.Add("C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\2.1.9\\System.Runtime.Extensions.dll");
            testFileNames.Add("C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\2.1.9\\System.Linq.dll");
            testFileNames.Add("C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\2.1.9\\System.Memory.dll");
            testFileNames.Add("C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\2.1.9\\System.Buffers.dll");
            testFileNames.Add("C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\2.1.9\\System.Threading.dll");
            testFileNames.Add("C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\2.1.9\\System.Collections.dll");


            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("Uplvlr.dll");
            expectedOutput.Add("System.Runtime.dll");
            expectedOutput.Add("System.IO.FileSystem.dll");
            expectedOutput.Add("System.Console.dll");
            expectedOutput.Add("System.Runtime.Extensions.dll");
            expectedOutput.Add("System.Linq.dll");
            expectedOutput.Add("System.Memory.dll");
            expectedOutput.Add("System.Buffers.dll");
            expectedOutput.Add("System.Threading.dll");
            expectedOutput.Add("System.Collections.dll");

            for(int i = 0; i < testFileNames.Count; i++)
            {
                Assert.AreEqual(expectedOutput[i], Uplvlr.Tools.GetFileName(testFileNames[i]));
            }

        }
    }
}
