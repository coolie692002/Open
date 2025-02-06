using System.Text.Json.Serialization;

namespace Open.Domain.Entities.Interfaces;

public interface ISoftDelete
{
    [JsonIgnore]
    bool IsDeleted { get; set; }

    void Delete();
}
