

using DataModel;
using Util;

namespace Test.Auth
{
    [TestFixture]
    public class SampleTest
    {


        [TestCaseSource(nameof(GetTestCaseData))]
        public void TestWithTestCaseSourceInvisibleInTestExplorer(AuthCredential authCredential)
        {
            var data = authCredential;
        }


        [Test]
        public void TestWithoutTestCaseSource( )
        {
        }


        private static IEnumerable<AuthCredential> GetTestCaseData()
        {
            //Assigning empty array if value is null causes the test to become invisible in test explorer
            var authCredentialList = TestCaseDataReader.ReadJsonDataListForTestCases("somenotexistingfile.json")??[]; 
            return authCredentialList;
        }
    }
}