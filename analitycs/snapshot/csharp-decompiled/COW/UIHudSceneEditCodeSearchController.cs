using GCommon;

namespace COW;

public class UIHudSceneEditCodeSearchController : UIPopupWindowController
{
	private UIHudSceneEditCodeSearchView m_View;

	private UIModelSceneEdit m_Model;

	private SceneEditSlotInfo m_SlotInfo;

	private uint m_SlotID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnReportBtnClick()
	{
	}

	private void OnPreviewBtnClick()
	{
	}

	private void OnSubscribeBtnClick()
	{
	}

	private void OnEnterPreviewMode(object[] data)
	{
	}

	public void SetUIData(SceneEditSlotInfo info, uint id, bool gmMode = false)
	{
	}

	private void _003CSetUIData_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
