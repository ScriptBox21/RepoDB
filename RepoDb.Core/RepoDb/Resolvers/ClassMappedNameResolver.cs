﻿using RepoDb.Extensions;
using RepoDb.Interfaces;
using System;

namespace RepoDb.Resolvers
{
    /// <summary>
    /// A class that is used to resolve the database object name mappings of the data entity type.
    /// </summary>
    public class ClassMappedNameResolver : IResolver<Type, string>
    {
        /// <summary>
        /// Creates a new instance of <see cref="ClassMappedNameResolver"/> object.
        /// </summary>
        public ClassMappedNameResolver() { }

        /// <summary>
        /// Resolves the mapped database object name mappings of the data entity type.
        /// </summary>
        /// <param name="entityType">The type of the data entity.</param>
        /// <returns>The mapped database object name.</returns>
        public string Resolve(Type entityType) =>
            DataEntityExtension.GetMappedName(entityType);
    }
}
