using System.Collections.Generic;
using ValidatorHierarchy.Utilities;

namespace ValidatorHierarchy
{
    class MbaApplicationValidator : IApplicationValidator
    {
        public IEnumerable<IPageValidator> Validators
        {
            get
            {
                return new List<IPageValidator>
                {
                    new MbaApplicantValidator()
                };
            }
        }
        public List<PageValidationResult> Validate(CSOMContext dbContext, APPLICATION app)
        {
            throw new System.NotImplementedException();
        }

        // from IApplicationValidator
        public IProgram Program { get; private set; }
        public bool CanSubmit(CSOMContext dbContext, APPLICATION app)
        {
            throw new System.NotImplementedException();
        }

        public bool IsPatementComplete(CSOMContext dbContext, APPLICATION app)
        {
            throw new System.NotImplementedException();
        }
    }
}
