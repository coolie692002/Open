namespace Open.Domain.Entities.Interfaces;

public interface IMayHaveCreator<TCreator>
{
    TCreator? Creator { get; }
}

public interface IMayHaveCreator
{
    Guid? CreatorId { get; }
}
