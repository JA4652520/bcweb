namespace BCWeb.Models;

public class MusicModel
{
    public int Id;
    public string Usernumber;
    public string Name;
}

public static class MusicModelFakeDB
{
    public static Dictionary<string, MusicModel> _dictionary = new Dictionary<string, MusicModel>();

    static MusicModelFakeDB()
    {
        _dictionary.Add("bc01", new MusicModel()
        {
            Id = 1,
            Usernumber = "bc01",
            Name = "新造的人",
        });
        _dictionary.Add("bc02", new MusicModel()
        {
            Id = 2,
            Usernumber = "bc02",
            Name = "My City",
        });
        _dictionary.Add("bc03", new MusicModel()
        {
            Id = 3,
            Usernumber = "bc03",
            Name = "Sunflower",
        });
        _dictionary.Add("bc04", new MusicModel()
        {
            Id = 4,
            Usernumber = "bc04",
            Name = "Push",
        });
        _dictionary.Add("bc05", new MusicModel()
        {
            Id = 5,
            Usernumber = "bc05",
            Name = "Someone You Loved",
        });
    }
}
