﻿// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

using System.Reflection;
using RESTFulSense.Brokers.Reflections;
using RESTFulSense.Models.Attributes;

namespace RESTFulSense.Services.Foundations.StreamContents
{
    internal class StreamContentService : IStreamContentService
    {
        private readonly IReflectionBroker reflectionBroker;

        public StreamContentService(IReflectionBroker reflectionBroker) =>
            this.reflectionBroker = reflectionBroker;

        public RESTFulFileContentStreamAttribute RetrieveStreamContent(PropertyInfo propertyInfo) =>
            throw new System.NotImplementedException();
    }
}
