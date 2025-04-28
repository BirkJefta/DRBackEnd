using DRBackEnd.Repository;

namespace RepoTest;

[TestClass]
public class UnitTest1
{
    private DRPladeRepository _repo;
    [TestInitialize]
    public void Setup()
    {
         _repo = new();
    }
    
    [TestMethod]
    public void GetTest()
    {

        _repo.Initiation();

        Assert.AreEqual(1, _repo.Get().Count());
        Assert.AreEqual("Happy", _repo.Get().FirstOrDefault().Title);

    }
}