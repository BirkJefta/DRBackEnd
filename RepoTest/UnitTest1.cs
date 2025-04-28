using DRBackEnd.Repository;

namespace RepoTest;

[TestClass]
public class UnitTest1
{
    [TestInitialize]
    public void Setup()
    {
        DRPladeRepository _repo = new();
    }
    
    [TestMethod]
    public void GetTest()
    {
        
    }
}