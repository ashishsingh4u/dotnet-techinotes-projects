//   ===================================================================================
//   <copyright file="TechieEventArgs.cs" company="TechieNotes">
//   ===================================================================================
//    TechieNotes Utilities & Best Practices
//    Samples and Guidelines for Winform & ASP.net development
//   ===================================================================================
//    Copyright (c) TechieNotes.  All rights reserved.
//    THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
//    OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
//    LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
//    FITNESS FOR A PARTICULAR PURPOSE.
//   ===================================================================================
//    The example companies, organizations, products, domain names,
//    e-mail addresses, logos, people, places, and events depicted
//    herein are fictitious.  No association with any real company,
//    organization, product, domain name, email address, logo, person,
//    places, or events is intended or should be inferred.
//   ===================================================================================
//   </copyright>
//   <author>Ashish Singh</author>
//   <email>mailto:ashishsingh4u@gmail.com</email>
//   <date>22-05-2015</date>
//   <summary>
//      The TechieEventArgs.cs file.
//   </summary>
//   ===================================================================================

using System;

namespace TechieSocket.Net.Common
{
    public class TechieEventArgs<T> : EventArgs
    {
        #region Constructors and Destructors

        public TechieEventArgs(T item)
        {
            Item = item;
        }

        #endregion

        #region Public Properties

        public T Item { get; set; }

        #endregion
    }
}