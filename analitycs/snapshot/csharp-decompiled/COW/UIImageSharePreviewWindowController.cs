using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIImageSharePreviewWindowController : UIImageSharePreviewWindowBaseController
{
	private Vector3 InitalLandScapeFFlogoPos;

	private Vector3 InitalPortraitFFlogoPos;

	protected Vector3 InitalSharePreviewPos;

	protected UIImageSharePreviewWindowView m_View;

	private UITipsNormalController m_StickerBtnTipCtrl;

	private UITipsNormalController m_StickerBtnTipCtrl_P;

	private UITipsNormalController m_PhotoFrameBtnTipCtrl;

	private UITipsNormalController m_PhotoFrameBtnTipCtrl_P;

	private UIHudHighlightPhotoDescController m_HudHighlightPhotoDescCtrl;

	private UIImageShareQRCodeController m_QRCodeCtrl;

	private UIRoomBattleShareWinController m_RoomBattleShareWinCtrl;

	private bool m_IsFunResultPageVisible;

	private bool m_IsFunResultPageScreenshoting;

	private const string Share_Preview_QRCode_SWITCH_KEY = "share_preview_qrcode_switch";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void UpdateShareImage()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected virtual void OnLeftClick()
	{
	}

	protected virtual void OnRightClick()
	{
	}

	protected virtual void OnShowQRCodeBtnClick()
	{
	}

	public void RrefreshLeftAndRightArrow(bool isLeftShow, bool isRightShow)
	{
	}

	public void LoadTextureFromBytes(byte[] imageData)
	{
	}

	public void SetHighlightShareView(bool showPhoto = false, AlbumPhotoInfo photoInfo = null, bool showCloseBtn = false)
	{
	}

	public void SetFunResultPageVisible(bool visible, MatchStats matchStats = null)
	{
	}

	private void SetFunResultEditFlag()
	{
	}

	private bool IsFunResultPageVisible()
	{
		return false;
	}

	protected override int GetCurrentShareLogPageId()
	{
		return 0;
	}

	protected override void BeforeShareEditorScreenshot()
	{
	}

	protected override void AfterShareEditorScreenshot()
	{
	}

	protected override bool ShouldTakeScreenShotForEditorByPreviewRegion()
	{
		return false;
	}

	protected override void OnPosterPageBtnClick()
	{
	}

	protected override void OnOriginPageBtnClick()
	{
	}

	protected virtual void RefreshImageChangeView(bool isPosterPage)
	{
	}

	public void FixFFLogoPos()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public int _003C_003EiFixBaseProxy_GetCurrentShareLogPageId()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_BeforeShareEditorScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterShareEditorScreenshot()
	{
	}

	public bool _003C_003EiFixBaseProxy_ShouldTakeScreenShotForEditorByPreviewRegion()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnPosterPageBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnOriginPageBtnClick()
	{
	}
}
