// Copyright (c) 2020 Allan Mobley. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Mobsites.Blazor
{
    /// <summary>
    /// Interface describing members a parent UI component should have.
    /// </summary>
    public interface IParentComponentBase
    {
        /// <summary>
        /// Switch for dark and light modes.
        /// </summary>
        ContrastModes ContrastMode { get; set; }

        /// <summary>
        /// The foreground color for this component. Accepts any valid css color usage.
        /// </summary>
        string Color { get; set; }

        /// <summary>
        /// The background color for this component. Accepts any valid css color usage.
        /// </summary>
        string BackgroundColor { get; set; }

        /// <summary>
        /// The foreground color for this component's dark mode. Default is #f2f2f2.
        /// Accepts any valid css color usage.
        /// </summary>
        string DarkModeColor { get; set; }

        /// <summary>
        /// The background color for this component's dark mode. Default is #121212.
        /// Accepts any valid css color usage.
        /// </summary>
        string DarkModeBackgroundColor { get; set; }

        /// <summary>
        /// The foreground color for this component's light mode. Default is #121212.
        /// Accepts any valid css color usage.
        /// </summary>
        string LightModeColor { get; set; }

        /// <summary>
        /// The background color for this component's light mode. Default is #f2f2f2.
        /// Accepts any valid css color usage.
        /// </summary>
        string LightModeBackgroundColor { get; set; }
    }
}