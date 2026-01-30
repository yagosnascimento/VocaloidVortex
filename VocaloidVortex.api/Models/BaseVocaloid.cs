namespace VocaloidVortex.Models;
using VocaloidVortex.Models;

public abstract class BaseVocaloid : IVocaloid
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public int PowerLevel { get; set; }
}

