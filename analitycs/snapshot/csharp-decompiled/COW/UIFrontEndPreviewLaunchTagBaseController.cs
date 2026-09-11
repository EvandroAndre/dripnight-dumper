using GCommon;

namespace COW;

public abstract class UIFrontEndPreviewLaunchTagBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewLaunchTagBaseView>, IUIModelDataChangeObserver
{
	private UIModelInventory m_ModelInventory;

	private UILaunchTagFrameController m_LaunchTag;

	private uint m_ItemID;

	private uint m_TagID;

	private bool m_IsCommonLaunchTag;

	private bool m_DisplayServerProgress;

	private bool m_CheckTimeIfOwnThisTag;

	protected override void OnUIInit()
	{
	}

	private void InitTagCtrl()
	{
	}

	public bool ShowLaunchTag(uint itemID, uint tagID, bool displayServerProgress, bool checkTimeIfOwnThisTag)
	{
		return false;
	}

	private bool _ShowLaunchTag()
	{
		return false;
	}

	private void OnObtainLaunchTag()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
