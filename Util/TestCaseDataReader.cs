
using System.Text.Json;
using DataModel;

namespace Util;

public static class TestCaseDataReader
{
    static public List<AuthCredential>? ReadJsonDataListForTestCases(string jsonFileName)
    {

        try
        {
            var currentDirectory = Environment.CurrentDirectory;
            var projectRootDirectory = Directory.GetParent(path: currentDirectory).Parent.Parent.FullName;
            var testCaseDataDir = Path.Combine(projectRootDirectory, "TestCaseData");
            var jsonFilePath = Path.Combine(testCaseDataDir, jsonFileName);
            var jsonString = File.ReadAllText(jsonFilePath);
            var testCaseDataList = JsonSerializer.Deserialize<List<AuthCredential>>(jsonString);
            return testCaseDataList;
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine("File not found exception caught and rethrown");
            Console.Error.WriteLine(e.ToString());
            return null;
        }

    }
}