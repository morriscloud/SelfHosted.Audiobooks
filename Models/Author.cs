using shortid.Configuration;

namespace SelfHosted.Audiobooks.Models;

public class Author
{
    public string Id { get; }
    public string Name { get; }
    public string Description { get; }
    public string Asin { get; }
    public string ImagePath { get; }
    public string RelativeImagePath { get; }
    public DateTime Created { get; }
    public DateTime Updated { get; }

    public Author(string id, string name, string description, string asin, string imagePath, string relativeImagePath, DateTime created, DateTime updated)
    {
        Id = id;
        Name = name;
        Description = description;
        Asin = asin;
        ImagePath = imagePath;
        RelativeImagePath = relativeImagePath;
        Created = created;
        Updated = updated;
    }

    public static Author Create(string name, string description, string asin, string imagePath, string relativeImagePath)
    {
        return new Author(
            id: shortid.ShortId.Generate(new GenerationOptions(false, false)),
            name: name,
            description: description,
            asin: asin,
            imagePath: imagePath,
            relativeImagePath: relativeImagePath,
            created: DateTime.UtcNow,
            updated: DateTime.UtcNow
        );
    }
}
