﻿namespace Microsoft.FeatureManagement
{
    /// <summary>
    /// An error that can occur during feature management.
    /// </summary>
    public enum FeatureManagementError
    {
        /// <summary>
        /// A feature filter that was listed for feature evaluation was not found.
        /// </summary>
        MissingFeatureFilter,

        /// <summary>
        /// A feature filter configured for the feature being evaluated is an ambiguous reference to multiple registered feature filters.
        /// </summary>
        AmbiguousFeatureFilter
    }
}
