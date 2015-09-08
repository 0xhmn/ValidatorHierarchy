using System.Collections.Generic;

namespace ValidatorHierarchy
{
    public interface IValidatorPipeline<out TValidator>
    {
        IEnumerable<TValidator> Validators { get; }
    }
}
