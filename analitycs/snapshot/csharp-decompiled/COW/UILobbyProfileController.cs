using GCommon;

namespace COW;

public class UILobbyProfileController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public ulong id;

		internal void _003COnHeadClick_003Eb__0()
		{
		}
	}

	private UILobbyProfileView m_View;

	private UIBaseProfileInfoController m_Profile;

	private ulong m_Account;

	private UICommonGuideController m_CommonGuideCtrl;

	private UITipsNormalController m_TipsCtrl;

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

	protected override void OnVisibilityChanged()
	{
	}

	public void UpdateProfileData(ulong account = 0uL)
	{
	}

	private void OnBtnRenameClick()
	{
	}

	public void SetGuideVisable(object[] data)
	{
	}

	public void EnableHeadClick(bool enabled)
	{
	}

	private void OnHeadClick()
	{
	}

	private void OnRenameBtnStateChange(object[] data)
	{
	}

	private void OnShowRankChanged(object[] data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnShowProfileCustomGuide(object[] data)
	{
	}

	private void OnCloseCommonGuide()
	{
	}

	public bool CheckNeedShowTakePhotoTips()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
