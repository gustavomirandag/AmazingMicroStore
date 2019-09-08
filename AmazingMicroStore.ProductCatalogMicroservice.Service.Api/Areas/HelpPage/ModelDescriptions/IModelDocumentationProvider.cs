using System;
using System.Reflection;

namespace AmazingMicroStore.ProductCatalogMicroservice.Service.Api.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}