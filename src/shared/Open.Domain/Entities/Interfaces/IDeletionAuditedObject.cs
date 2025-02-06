﻿namespace Open.Domain.Entities.Interfaces;

public interface IDeletionAuditedObject : ISoftDelete
{
    DateTime? DeletionTime { get; set; }
    
    Guid? DeleterId { get; set; }
}

public interface IDeletionAuditedObject<TUser> : IDeletionAuditedObject
{
    TUser? Deleter { get; }
}
