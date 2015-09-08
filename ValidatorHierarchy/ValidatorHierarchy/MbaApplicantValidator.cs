using System.Collections.Generic;
using ValidatorHierarchy.Utilities;

namespace ValidatorHierarchy
{
    public class MbaApplicantValidator : IPageValidator
    {
        public IEnumerable<IValidator<SectionValidationResult>> Validators { get; private set; }
        public PageValidationResult Validate(CSOMContext dbContext, APPLICATION app)
        {
            throw new System.NotImplementedException();
        }

        public string Name { get; private set; }
    }
}
