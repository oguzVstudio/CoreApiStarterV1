using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.Extensions
{
    public static class ListContainsValidatorExtension
    {
        public static IRuleBuilderOptions<T, TProperty> In<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder,
           List<TProperty> validOptions)
        {
            string formatted;

            if (validOptions == null || validOptions.Count == 0)
                throw new ArgumentException("At least one valid option is expected", nameof(validOptions));

            else if (validOptions.Count == 1)
                formatted = validOptions[0].ToString();

            else
                formatted =
                    $"{string.Join(", ", validOptions.Select(u => u.ToString()).ToArray(), 0, validOptions.Count - 1)} or {validOptions.Last()}";

            return ruleBuilder
                .Must(validOptions.Contains)
                .WithMessage($"{{PropertyName}} must be one of these values: {formatted}");
        }

        public static IRuleBuilderOptions<T, TProperty> InWhenNotEqualZeroOrNull<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder,
            List<TProperty> validOptions, ref string message)
        {
            string formatted;

            if (validOptions == null || validOptions.Count == 0)
                throw new ArgumentException("At least one valid option is expected", nameof(validOptions));

            else if (validOptions.Count == 1)
                formatted = validOptions[0].ToString();

            else
                formatted =
                    $"{string.Join(", ", validOptions.Select(c => c.ToString()).ToArray(), 0, validOptions.Count - 1)} or {validOptions.Last()}";

            message = $"{{PropertyName}} must be one of these values: {formatted}";

            return ruleBuilder
                .Must(validOptions.Contains)
                .WithMessage($"{{PropertyName}} must be one of these values: {formatted}");
        }
    }
}
