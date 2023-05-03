﻿// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using System;

namespace RESTFulSense.Models.Attributes
{
    [AttributeUsage(validOn: AttributeTargets.Property)]
    public sealed class RESTFulByteArrayContentAttribute : Attribute
    {
        public RESTFulByteArrayContentAttribute(string name) => Name = name;

        public string Name { get; }
    }
}
