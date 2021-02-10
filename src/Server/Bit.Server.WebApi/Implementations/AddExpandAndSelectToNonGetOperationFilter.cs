﻿using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace Bit.WebApi.Implementations
{
    public class AddExpandAndSelectToNonGetOperationFilter : IOperationFilter
    {
        public virtual void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation == null)
                throw new ArgumentNullException(nameof(operation));

            if (schemaRegistry == null)
                throw new ArgumentNullException(nameof(schemaRegistry));

            if (apiDescription == null)
                throw new ArgumentNullException(nameof(apiDescription));

            if (typeof(SingleResult).IsAssignableFrom(apiDescription.ResponseType()) && !apiDescription.ParameterDescriptions.Any(p => p.Name == "$select" || p.Name == "$expand"))
            {
                operation.parameters = operation.parameters ?? new List<Parameter>();

                operation.parameters.Add(new Parameter { name = "$expand", @in = "query", description = "Expands related entities inline.", type = "string", required = false });
                operation.parameters.Add(new Parameter { name = "$select", @in = "query", description = "Selects which properties to include in the response.", type = "string", required = false });
            }
        }
    }
}
