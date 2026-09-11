using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIAvatarInfoListItemController : UIEasyListItemController
{
	private uint m_DelayCallID;

	private uint m_AvatarID;

	private List<ResourceID> m_avatarRes;

	private bool m_NeedDownload;

	private UIAvatarInfoListItemView m_View;

	private AvatarProfile m_Profile;

	private UIModelEvoPass m_ModelEvoPass;

	private UIModelLoadout m_ModelLoadout;

	private UIChangeStatusController m_ChangeStatusCtrl;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UINewDownloadInfoController m_DownloadCtrl;

	public uint AvatarID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitIconState()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnLoveNodeUpdate(object[] data)
	{
	}

	private void OnNewVFXChanged(object[] data)
	{
	}

	private void OnTopRightReposition()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void SetTips()
	{
	}

	private void SetAvatarIcon()
	{
	}

	private void SetTags()
	{
	}

	private CSSharedAvatarData GetChangeStatusAvatarData()
	{
		return null;
	}

	private void SetAwakenIcon()
	{
	}

	public void SetSmallIconGrid()
	{
	}

	private void CloseCountDownLabel()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private uint GetAvatarID()
	{
		return 0u;
	}

	private void OnPinHoverIn()
	{
	}

	private void OnPinHoverOut()
	{
	}

	private void OnNewCharacterGuide(uint data)
	{
	}

	private void CheckNewCharacterGuide()
	{
	}

	private void ShowNewCharacterVFX()
	{
	}

	private void SetNewCharacterIcon(bool isFemale)
	{
	}

	private object _003COnUIInit_003Eb__14_0()
	{
		return null;
	}

	private object _003COnUIInit_003Eb__14_1()
	{
		return null;
	}

	private void _003COnLoveNodeUpdate_003Eb__17_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
