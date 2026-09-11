using GCommon;
using proto;

namespace COW;

public class UIProfileCompensationItemController : UIEasyListItemController
{
	private UIProfileCompensationItemView m_View;

	private CreditCompensationInfo m_DataInfo;

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

	public override void SetViewData(object data, int data_index)
	{
	}

	private string GetGameModeName(uint gameMode)
	{
		return null;
	}

	private void OnCompensationNameBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
