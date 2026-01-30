namespace VocaloidVortex.Models;
using VocaloidVortex.Models;

public interface IVocaloid
{
    int Id { get; set; }
    string Name { get; set; }
    string Color { get; set; }
    int PowerLevel { get; set; }
}