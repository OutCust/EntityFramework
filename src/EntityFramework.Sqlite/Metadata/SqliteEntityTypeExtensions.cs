﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Metadata;

namespace Microsoft.Data.Entity.Sqlite.Metadata
{
    public class SqliteEntityTypeExtensions : ReadOnlySqliteEntityTypeExtensions
    {
        public SqliteEntityTypeExtensions([NotNull] EntityType entityType)
            : base(entityType)
        {
        }

        public virtual new string Table
        {
            get { return base.Table; }
            [param: CanBeNull]
            set { EntityType[SqliteTableAnnotation] = value; }
        }

        protected virtual new EntityType EntityType => (EntityType)base.EntityType;
    }
}
