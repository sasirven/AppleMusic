using System.Collections.ObjectModel;

namespace Model;

public class Manager
{
    public IReadOnlyCollection<Album> Albums { get; set; }
    private readonly List<Album> _albums = new();

    public Manager(ILoader loader)
    {
        _albums.AddRange(loader.Load());
        Albums = new ReadOnlyCollection<Album>(_albums);
    }
}