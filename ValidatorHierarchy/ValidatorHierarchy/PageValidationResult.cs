using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorHierarchy
{
    public class PageValidationResult : ValidationResult
    {
        public IEnumerable<SectionValidationResult> Sections { get; set; } 
    }
}
