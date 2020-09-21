using Microsoft.AspNetCore.Mvc;
using sTest.Api.Models;
using sTest.Api.Responses.Version1.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.Extensions
{
    public static class BadRequestExtensions
    {
        public static void GenerateErrorResponse<TProperty>(this List<TProperty> validOptions, string fieldName,
   out BadRequestObjectResult requestObjectResult)
        {
            string formatted =
                $"{string.Join(", ", validOptions.Select(u => u.ToString()).ToArray(), 0, validOptions.Count - 1)} or {validOptions.Last()}";

            var errorResponse = new ErrorResponse();

            errorResponse.Errors.Add(new ErrorModel
            {
                FieldName = fieldName,
                Message = $"{fieldName} must be one of these values: {formatted}"
            });

            requestObjectResult = new BadRequestObjectResult(error: errorResponse);
        }


        public static void GenerateErrorResponseMultipleNull<TProperty>(this List<TProperty> validOptions, string fieldName,
           out BadRequestObjectResult requestObjectResult)
        {
            string formatted =
                $"{string.Join(", ", validOptions.Select(u => u.ToString()).ToArray(), 0, validOptions.Count - 1)} or {validOptions.Last()}";

            var errorResponse = new ErrorResponse();

            errorResponse.Errors.Add(new ErrorModel
            {
                FieldName = fieldName,
                Message = $"At least 1 of them must not be null.: {formatted}"
            });

            requestObjectResult = new BadRequestObjectResult(error: errorResponse);
        }
    }
}
