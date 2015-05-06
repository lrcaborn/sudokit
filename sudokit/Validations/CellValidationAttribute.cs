namespace Lrc.Sudokit.Validations
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CellValidationAttribute : ValidationAttribute
    {
        public const int MinValue = 1;
        public const int MaxValue = 9;

        public CellValidationAttribute()
            : base("The value is not within a valid range")
        {
        }

        public override bool IsValid(object value)
        {
            int valueToCheck = (int)value;
            if (valueToCheck <= MinValue || valueToCheck >= MaxValue)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}