﻿namespace Open.Domain.Entities.Interfaces;

public interface IModificationAuditedObject
{
    DateTime? LastModificationTime { get; set; }
    
    Guid? LastModifierId { get; set; }
}

public interface IModificationAuditedObject<TUser> : IModificationAuditedObject
{
    /// <summary>
    /// Reference to the last modifier user of this entity.
    /// </summary>
    TUser? LastModifier { get; }
}
