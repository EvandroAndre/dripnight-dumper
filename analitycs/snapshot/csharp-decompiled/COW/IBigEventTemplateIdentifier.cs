namespace COW;

public interface IBigEventTemplateIdentifier
{
	EBigEventTemplateUseType TemplateUseType { get; }

	EBigEventTemplateType GetTemplateType();

	void OnTemplateUIInit();
}
