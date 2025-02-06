﻿namespace Open.Domain.Entities.Interfaces;

public interface IFullAuditedObject : IAuditedObject, IDeletionAuditedObject
{
    
}

public interface IFullAuditedObject<TUser> : IAuditedObject<TUser>, IFullAuditedObject, IDeletionAuditedObject<TUser>
{

}
