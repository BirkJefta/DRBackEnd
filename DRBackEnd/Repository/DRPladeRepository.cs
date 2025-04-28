using DRBackEnd.Models;

namespace DRBackEnd.Repository;

public class DRPladeRepository
{
    private readonly List<DRPladeModel> DRPlader = new();

    public void Initiation()
    {
        DRPlader.Add(new DRPladeModel("Happy", "Pharrell", 180, 2016));
    }

    public DRPladeRepository() { }
    public IEnumerable<DRPladeModel> Get()
    {
        IEnumerable<DRPladeModel> DRPlades = new List<DRPladeModel>(DRPlader);
        
        return DRPlades;
    }
}