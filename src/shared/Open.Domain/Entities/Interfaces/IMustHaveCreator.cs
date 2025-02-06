﻿using System.Diagnostics.CodeAnalysis;

namespace Open.Domain.Entities.Interfaces;

public interface IMustHaveCreator<TCreator> : IMustHaveCreator
{
    [NotNull]
    TCreator Creator { get; }
}

public interface IMustHaveCreator
{
    Guid CreatorId { get; }
}
