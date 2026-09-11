using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudEmotionController : UIBaseController, IUIModelDataChangeObserver
{
	protected UIHudEmotionView m_View;

	private List<Transform> m_NormalEmoteItemTransform;

	private List<Transform> m_BPEmoteItemTransform;

	protected readonly List<UIHudEmotionBaseItemController> m_ListBaseItemController;

	private UIHudAvatarTransformerEntryController m_TransformerEntryCtrl;

	public const uint VISIBILITY_STATE_LOBBY_SOCIAL_HUD = 67108864u;

	private bool m_ShowBpItem;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIInit()
	{
	}

	private void InitEmoteTransForm()
	{
	}

	private void RefreshBpInfoForSocialLobby()
	{
	}

	private void InitCtrl()
	{
	}

	protected virtual void InitItemInfo()
	{
	}

	public void RefreshItemInfoForSocialLobby()
	{
	}

	private void RefreshTransformerForSocialLobby()
	{
	}

	private void OnUIChangeFromWaitingToBattle()
	{
	}

	protected void InitTransformer()
	{
	}

	private void InitDownloadInfo()
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	private void OnLobbySocialHudStateChanged(bool visible)
	{
	}

	private void OnBtnPaintSprayerClick()
	{
	}

	private void OnBtnCameraModeClick()
	{
	}

	private void RefreshTitleBtn()
	{
	}

	private void OnBtnShowTitleClick()
	{
	}

	private bool TryShowLobbySocialAreaCommonTitle()
	{
		return false;
	}

	protected void InitPaintSprayer(object[] param)
	{
	}

	private void InitPaintSprayer()
	{
	}

	private void RefreshBtnCustomoAnimVisibility()
	{
	}

	protected void OnBtnCustomAnimClick()
	{
	}

	protected void OnBtnMaskClick()
	{
	}

	private void RefreshSocialLobbyDownloadState()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
