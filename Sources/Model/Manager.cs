using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Model;

public class Manager: INotifyPropertyChanged
{
    public IReadOnlyCollection<Album> Albums { get; set; }
    private readonly List<Album> _albums = new();
    

    public Manager(ILoader loader)
    {
        _albums.AddRange(loader.Load());
        Albums = new ReadOnlyCollection<Album>(_albums);
    }
    
    public Album? CurrentAlbum
    {
        get => _currentAlbum;
        set => SetField(ref _currentAlbum, value);
    }
    private Album? _currentAlbum;
    
    public Music? CurrentMusic
    {
        get => _currentMusic;
        set => SetField(ref _currentMusic, value);
    }
    private Music? _currentMusic;

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) 
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}