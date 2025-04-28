using DRBackEnd.Models;

namespace DRBackEnd.DRPladeRepository;

public class DRPladeRepository
{
    private readonly List<DRPladeModel> DRPlader = new();

    public IEnumerable<DRPladeModel> Get()
    {
        IEnumerable<DRPladeModel> DRPlades = new List<DRPladeModel>(DRPlader);
        
        return DRPlades;
    }
}