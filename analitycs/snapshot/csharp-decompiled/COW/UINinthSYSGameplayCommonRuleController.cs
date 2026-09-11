using GCommon;
using proto;

namespace COW;

public class UINinthSYSGameplayCommonRuleController : UINinthSYSGameplaySubRuleController
{
	private UINinthSYSGameplayCommonRuleView m_View;

	private NinthSysGamePlayDesc m_Desc;

	private UIModelNinthSYS.INinthSYSGamePlayContext m_Context;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(NinthSysGamePlayDesc desc, UIModelNinthSYS.INinthSYSGamePlayContext context)
	{
	}

	private void OnClickTutorialBtn()
	{
	}

	private void OnClickGoposBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
