using GCommon;
using proto;

namespace COW;

public class UINinthSYSGameplaySubTabItemController : UIBaseController
{
	private UINinthSYSGameplaySubTabItemView m_View;

	private NinthSysGamePlayDesc m_GamePlayDesc;

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

	public bool SetViewData(NinthSysGamePlayDesc gamePlayDesc, UIModelNinthSYS.INinthSYSGamePlayContext context)
	{
		return false;
	}

	public bool RefershView()
	{
		return false;
	}

	private void OnClickSubTabItem()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
