using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIPostMacthButtonTeammatesContainerController : UIBaseController
{
	private UIPostMacthButtonTeammatesContainerView m_View;

	private List<UIPostMatchButtonTeammateItemController> m_TeammateListItemControllers;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(List<UIPostMatchTeamUpCountDownController.PlayerData> playerDatas)
	{
	}

	private List<int> GetGroupChangeIndices(List<UIPostMatchTeamUpCountDownController.PlayerData> playerDatas)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
