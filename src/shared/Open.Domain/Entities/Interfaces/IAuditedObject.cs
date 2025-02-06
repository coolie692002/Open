namespace Open.Domain.Entities.Interfaces;

public interface IAuditedObject : ICreationAuditedObject, IModificationAuditedObject
{

}

public interface IAuditedObject<TUser> : IAuditedObject, ICreationAuditedObject<TUser>, IModificationAuditedObject<TUser>
{

}
