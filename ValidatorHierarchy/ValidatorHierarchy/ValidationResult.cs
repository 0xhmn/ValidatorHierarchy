namespace ValidatorHierarchy
{
    public class ValidationResult
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public bool IsValid { get; set; }
        public bool IsRequired { get; set; }
    }
}
