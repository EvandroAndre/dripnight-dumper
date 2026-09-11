using GCommon;
using proto;

namespace COW;

public class UIAvatarAwakenNavigationController : UINavigationController, IUIModelDataChangeObserver
{
	private UIAvatarAwakenNavigationView m_View;

	private UIModelAvatarProfile m_Model;

	private AvatarProfile m_CurrentShowAvatar;

	private AvatarProfile m_AwakenAvatar;

	private UIAvatarAwakenController m_AwakenCtrl;

	private UIAvatarAwakenStoryReplayController m_AvakenStoryCtrl;

	private AvatarAwaken m_Awakeninfo;

	private uint m_CurrentShowStoryID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClickLeftArea()
	{
	}

	private void OnClickRightArea()
	{
	}

	private void OnClickBtnShare()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public void SetAvatar(uint curAvatarID)
	{
	}

	private void ShowAvatarInfo()
	{
	}

	private void ShowCurrentUI()
	{
	}

	private void ShowCurrentUI_V1()
	{
	}

	private void ShowCurrentUI_V2()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnShowAvatarAwakenStory(object[] data)
	{
	}

	private void OnRefreshAwakenUI(object[] data)
	{
	}

	private void OnExchangeActivityBtnClick(object[] data)
	{
	}

	private void ShowAvatarAwakenStory_V2(uint storyId)
	{
	}

	private void ShowAvatarAwakenStory(uint storyId)
	{
	}

	private void OnCDNBtnCloseClick()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void SetShareBgView(bool shareView)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
