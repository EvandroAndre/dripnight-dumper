using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILadderMatchSelectGameModePopupController : UIPopupWindowController
{
	private UILadderMatchSelectGameModePopupView m_View;

	private List<UILadderMatchSelectGameModeItemController> m_ListModes;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(List<LadderMatchSelectMode> selectModes)
	{
	}

	private void ClearGameModeItems()
	{
	}

	private void OnSelectGameMode(object[] data)
	{
	}

	private void OnClickBtnClose()
	{
	}

	private void OnClickBtnMask()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
