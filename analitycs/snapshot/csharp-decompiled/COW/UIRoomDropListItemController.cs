using GCommon;

namespace COW;

public class UIRoomDropListItemController : UIBaseController
{
	private UIRoomDropListItemView m_View;

	private DropListConfigInfo m_Info;

	private UIModelCustomRoom m_ModelRoom;

	public bool IsPreset;

	private UICreateRoomTagController m_TagCtrl;

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

	public void SetData(DropListConfigInfo info)
	{
	}

	public UIToggleButton GetToggleButton()
	{
		return null;
	}

	public uint GetConfigInfoID()
	{
		return 0u;
	}

	private void OnBtnClick()
	{
	}

	public void SetPresetViewData()
	{
	}

	private void OnGameModeSelected(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
