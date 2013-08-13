﻿namespace Headless
{
    using System;

    /// <summary>
    ///     The <see cref="HtmlFormExtensions" />
    ///     class provides extension methods for the <see cref="HtmlForm" /> class.
    /// </summary>
    public static class HtmlFormExtensions
    {
        /// <summary>
        /// Submits the specified form.
        /// </summary>
        /// <typeparam name="T">
        /// The type of page to return.
        /// </typeparam>
        /// <param name="form">
        /// The form.
        /// </param>
        /// <returns>
        /// A <typeparamref name="T"/> value.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">
        /// The <paramref name="form"/> parameter is <c>null</c>.
        /// </exception>
        public static T Submit<T>(this HtmlForm form) where T : Page, new()
        {
            if (form == null)
            {
                throw new ArgumentNullException("form");
            }

            throw new NotImplementedException();
        }
    }
}