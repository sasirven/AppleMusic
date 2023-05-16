namespace Model;

public class Music
{
    public uint Number
    {
        get => _number;
        private init
        {
            if (_number < 1) throw new ArgumentOutOfRangeException(nameof(value), "Number must be greater than 0.");
            _number = value;
        }
    }
    private readonly uint _number;
    
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
    
    public Music(uint number, string name)
    {
        Number = number;
        Name = name;
    }
}