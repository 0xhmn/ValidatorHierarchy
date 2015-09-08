namespace ValidatorHierarchy
{
    public interface IPageValidator : IValidatorPipeline<IValidator<SectionValidationResult>>, IValidator<PageValidationResult>
    {
        string Name { get; }
    }
}
