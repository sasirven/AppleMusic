namespace Model;

public interface ILoader
{
    IEnumerable<Album> Load();
}