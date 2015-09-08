using System.Collections.Generic;

namespace ValidatorHierarchy
{
    public class SectionValidationResult : ValidationResult
    {
        IEnumerable<ItemValidationResult> Items { get; set; }
    }
}
