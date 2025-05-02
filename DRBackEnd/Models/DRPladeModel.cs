namespace DRBackEnd.Models;

public class DRPladeModel
{
    public string Title { get; set; }

    public string Artist { get; set; }

    public int Duration { get; set; }
     
    public int PublicationYear { get; set; }

    public DRPladeModel(string title, string artist, int duration, int publicationYear)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
        PublicationYear = publicationYear;
    }
}