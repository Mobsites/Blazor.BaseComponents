// Copyright (c) 2020 Allan Mobley. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Mobsites.Blazor
{
    /// <summary>
    /// Abstract base representing options that can be saved in browser storage.
    /// </summary>
    public abstract class BaseComponentOptions
    {
        /************************************************************************
        *
        *   Non-null enum and int members with a zero value do not need to be
        *   serialized as they would default to zero on C# object initialization.
        *   
        *   (For nullable types...well null is null.)
        *
        *   Setting their options equivalent to null will keep them from
        *   being serialized.
        *
        *   This saves space in browser storage.
        *
        *   Caveat: If the options are passed into a javascript function,
        *   then, obviously, any such members depended on there will have to 
        *   be accounted for there as not defined or null and, thus,
        *   equivalent to zero.
        *
        ***********************************************************************/

        private BackgroundModes? backgroundMode;

        /// <summary>
        /// Option for the style of background to apply.
        /// </summary>
        public BackgroundModes? BackgroundMode
        {
            get => backgroundMode;
            set => backgroundMode = this.NullOnZero<BackgroundModes?>(value);
        }

        private ContrastModes? contrastMode;

        /// <summary>
        /// Option for switch for dark and light modes.
        /// </summary>
        public ContrastModes? ContrastMode
        {
            get => contrastMode;
            set => contrastMode = this.NullOnZero<ContrastModes?>(value);
        }

        /// <summary>
        /// Option for the foreground color for this component. Accepts any valid css color usage.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Option for whether to inherit a parent's colors (dark, light, or normal modes).
        /// </summary>
        public bool InheritParentColors { get; set; }

        /// <summary>
        /// Option for the background color for this component. Accepts any valid css color usage.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Option for whether to inherit a parent's background colors (dark, light, or normal modes).
        /// </summary>
        public bool InheritParentBackgroundColors { get; set; }

        /// <summary>
        /// Converts object values of zero to null to avoid serialization 
        /// and thereby conserve space in Browser storage.
        /// </summary>
        protected T NullOnZero<T>(object value) => (int)value == 0 ? default : (T)value;
    }
}