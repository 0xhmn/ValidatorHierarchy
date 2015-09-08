using System.Net.Mime;
using ValidatorHierarchy.Utilities;

namespace ValidatorHierarchy
{
    public interface IValidator<out T>
    {
        T Validate(CSOMContext dbContext, APPLICATION app);
    }
}
