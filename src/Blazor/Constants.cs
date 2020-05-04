// Copyright (c) 2020 Allan Mobley. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Mobsites.Blazor
{
    /// <summary>
    /// Supported contrast modes.
    /// </summary>
    public enum ContrastModes
    {
        /// <summary>
        /// Normal color mode using BackgroundColor and Color members.
        /// </summary>
        Normal,

        /// <summary>
        /// Dark mode (Equivalent to BackgroundModes.Dark on main object).
        /// </summary>
        Dark,

        /// <summary>
        /// Light mode (Equivalent to BackgroundModes.Light on main object).
        /// </summary>
        Light
    }

    /// <summary>
    /// Supported background modes.
    /// </summary>
    public enum BackgroundModes
    {
        /// <summary>
        /// No background set.
        /// </summary>
        None,

        /// <summary>
        /// Dark mode (Equivalent to ContrastModes.Dark on child objects).
        /// </summary>
        Dark,

        /// <summary>
        /// Light mode (Equivalent to ContrastModes.Light on child objects).
        /// </summary>
        Light,

        /// <summary>
        /// Image mode.
        /// </summary>
        Image,

        /// <summary>
        /// Gradient mode.
        /// </summary>
        Gradient,

        /// <summary>
        /// Normal color mode using BackgroundColor and Color members.
        /// </summary>
        Color
    }

    /// <summary>
    /// Supported background color directions.
    /// </summary>
    public enum BackgroundColorDirections
    {
        /// <summary>
        /// Start color from bottom to end color on top.
        /// </summary>
        BottomToTop = 0,

        /// <summary>
        /// Start color from left to end color on right.
        /// </summary>
        LeftToRight = 90,

        /// <summary>
        /// Start color from top to end color on bottom.
        /// </summary>
        TopToBottom = 180,

        /// <summary>
        /// Start color from right to end color on left.
        /// </summary>
        RightToLeft = 270
    }
}