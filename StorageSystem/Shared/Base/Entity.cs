namespace StorageSystem.Shared.Base;

public abstract class Entity(Guid id, string name, DateTime created, DateTime updated, bool active )
{
    public Guid Id { get; } = id;
    public string Name { get; protected set; } = name;
    public DateTime Created { get; } = created;
    public DateTime Updated { get; protected set; } = updated;
    public bool Active { get; protected set; } = active;
    
    protected Entity(string name) : this(Guid.NewGuid(), name,
        DateTime.UtcNow, DateTime.UtcNow, true) {}
}