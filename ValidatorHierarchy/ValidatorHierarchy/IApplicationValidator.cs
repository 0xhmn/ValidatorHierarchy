using System.Collections.Generic;
using ValidatorHierarchy.Utilities;

namespace ValidatorHierarchy
{
    public interface IApplicationValidator : IValidatorPipeline<IPageValidator> , IValidator<List<PageValidationResult>>
    {
        IProgram Program { get; }
        bool CanSubmit(CSOMContext dbContext, APPLICATION app);
        bool IsPatementComplete(CSOMContext dbContext, APPLICATION app);
    }
}
