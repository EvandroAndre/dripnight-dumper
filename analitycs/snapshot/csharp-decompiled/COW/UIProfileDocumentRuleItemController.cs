using GCommon;

namespace COW;

public class UIProfileDocumentRuleItemController : UIBaseController
{
	public enum ProfileDocumentRuleType
	{
		BR,
		CS
	}

	public int AdIndex;

	private ProfileDocumentRuleType m_RuleType;

	private UIProfileDocumentRuleItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetType(ProfileDocumentRuleType ruleType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
