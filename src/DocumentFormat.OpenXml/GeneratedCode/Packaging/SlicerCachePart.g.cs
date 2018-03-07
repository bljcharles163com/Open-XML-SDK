﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the SlicerCachePart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2010)]
    [ContentType("application/vnd.ms-excel.slicerCache+xml")]
    public partial class SlicerCachePart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.slicerCache+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2007/relationships/slicerCache";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

        /// <summary>
        /// Creates an instance of the SlicerCachePart OpenXmlType
        /// </summary>
        internal protected SlicerCachePart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "slicerCache";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "slicerCaches";

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
        {
            if (_dataPartReferenceConstraint is null)
            {
                _dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal) { };
            }

            return _dataPartReferenceConstraint;
        }

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetPartConstraint()
        {
            if (_partConstraint is null)
            {
                _partConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal) { };
            }

            return _partConstraint;
        }

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2010);
        }
    }
}