using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPrimePrivilegeController : UIPreviewBaseController, IUIModelDataChangeObserver
{
	private UIPrimePrivilegeView m_View;

	private UIModelPrime m_ModelPrime;

	private UIModelCollection m_ModelCollection;

	private UIModelInventory m_ModelInventory;

	private List<UIPrimePrivilegeLevelItemController> m_PrivilegeCtrls;

	private List<UIPrimePrivilegeLevelItemController> m_PrivilegeShrinkCtrls;

	private uint m_CurrentSelectedPrivilegeId;

	private uint m_CurrentSelectedLevel;

	private bool m_Expand;

	private bool m_HasExpandInit;

	private bool m_HasShrinkInit;

	private UIPrimePrivilegeBadgeController m_BadgeCtrl;

	private UIPrimePrivilegeSuperBadgeController m_SuperBadgeCtrl;

	private UIPrimePrivilegeBannerController m_BannerCtrl;

	private UIPrimePrivilegeExtraFriendsController m_ExtraFriendsCtrl;

	private UIPrimePrivilegeProfileAniController m_ProfileAniCtrl;

	private Vector3 EXPAND_CDN_POS;

	private Vector3 SHRINK_CDN_POS;

	private Vector3 EXPAND_CDN_SCALE;

	private const string SETSHARE_REMAIN_NUM_FORMAT = "{0}/{1}";

	private bool m_AvatarFrameSelectWndOpen;

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

	protected override void OnVisibilityChanged()
	{
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	private void InitExpandPrivileges()
	{
	}

	private void InitShrinkPrivileges()
	{
	}

	public void InitPrivileges()
	{
	}

	public void SelectPrivilege(uint privilegeId, uint level, uint expand = 0u, bool needScrollTo = false)
	{
	}

	public void RefreshPrivilegeShow()
	{
	}

	private void RefreshTopRight()
	{
	}

	private void RefreshAvatarFrameDisplayBtn()
	{
	}

	private void RefreshCenterPreview()
	{
	}

	private void RefreshCenterChargeDesc()
	{
	}

	private void RefreshCDNPreviewSize()
	{
	}

	private void OnCheckBtnClick()
	{
	}

	private void OnSwitchBtnClick()
	{
	}

	private void OnDoNotUseBtnChanged()
	{
	}

	private void OnGotoTopUpClick()
	{
	}

	private void OnDisplayBtnClick()
	{
	}

	private void OnAvatarFrameSelectWndClose()
	{
	}

	private void OnTabChanged(object[] param)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
