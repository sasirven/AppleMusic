using System.Collections.ObjectModel;

namespace Model;

public class Album
{
    public string Name
    {
        get => _name;
        private init
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value), "Name must not be null or whitespace.");
            _name = value;
        }
    }
    private readonly string _name = string.Empty;
    
    public string Artist
    {
        get => _artist;
        private init
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value), "Artist must not be null or whitespace.");
            _artist = value;
        }
    }
    private readonly string _artist = string.Empty;
    
    public string Image
    {
        get => _image;
        private init
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value), "Image must not be null or whitespace.");
            _image = value;
        }
    }
    private readonly string _image = string.Empty;
    
    public string Genre
    {
        get => _genre;
        private init
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value), "Genre must not be null or whitespace.");
            _genre = value;
        }
    }
    private readonly string _genre = string.Empty;
    
    public DateTime ReleaseDate
    {
        get => _releaseDate;
        private init
        {
            if (value == default) throw new ArgumentNullException(nameof(value), "ReleaseDate must not be default.");
            _releaseDate = value;
        }
    }
    private readonly DateTime _releaseDate = DateTime.MinValue;
    
    public string RecordLabel
    {
        get => _recordLabel;
        private init
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value), "RecordLabel must not be null or whitespace.");
            _recordLabel = value;
        }
    }
    private readonly string _recordLabel = string.Empty;
    
    public string Lossless
    {
        get => _lossless;
        private init
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value), "Lossless must not be null or whitespace.");
            _lossless = value;
        }
    }
    private readonly string _lossless = string.Empty;
    
    public bool IsMasteredForApple { get; set; }
    
    public uint Duration
    {
        get => _duration;
        private init
        {
            if (_duration < 1) throw new ArgumentOutOfRangeException(nameof(value), "Duration must be greater than 0.");
            _duration = value;
        }
    }
    private readonly uint _duration;

    public IReadOnlyCollection<Music> Musics { get; set; }
    private readonly List<Music> _musics = new();
    
    public uint NumberOfTracks => (uint) _musics.Count;
    
    public Album(
        string name, 
        string artist, 
        string image, 
        string genre, 
        DateTime releaseDate, 
        string recordLabel, 
        string lossless,
        bool isMasteredForApple,
        uint duration, 
        params Music[] musics)
    {
        Name = name;
        Artist = artist;
        Image = image;
        Genre = genre;
        ReleaseDate = releaseDate;
        RecordLabel = recordLabel;
        Lossless = lossless;
        IsMasteredForApple = isMasteredForApple;
        Duration = duration;
        
        _musics.AddRange(musics);
        Musics = new ReadOnlyCollection<Music>(_musics);
    }
}