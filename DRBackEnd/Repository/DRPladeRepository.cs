using DRBackEnd.Models;

namespace DRBackEnd.Repository;

public class DRPladeRepository
{
    private readonly List<DRPladeModel> DRPlader = new();

    public DRPladeRepository() { }
    public IEnumerable<DRPladeModel> Get()
    {
        IEnumerable<DRPladeModel> DRPlades = new List<DRPladeModel>(DRPlader);
        
        return DRPlades;
    }
}