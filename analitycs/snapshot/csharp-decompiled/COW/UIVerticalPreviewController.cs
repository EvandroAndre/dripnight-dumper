using GCommon;
using UnityEngine;

namespace COW;

public class UIVerticalPreviewController : UIPreviewPopUpWindowController
{
	public enum VerticalPreviewState
	{
		None,
		BACKPACK,
		PERSONZOOMIN,
		PERSONZOOMOUT
	}

	private UIVerticalPreviewView m_View;

	private FrontEndPreviewComponent.ShowPreviewType m_ShowPreviewType;

	private bool m_IsZoomIn;

	private bool m_IsOpenZoomIn;

	private VerticalPreviewState m_VerticalPreviewState;

	private PreviewCameraMove m_PreviewCameraMove;

	private uint m_ItemId;

	private bool m_IsBackpack;

	private ECollectionLevel m_BackpackLevel;

	private PreviewShowAvatarParams m_ShowAvatarParams;

	private Vector3 m_VerticalPreviewShadowRoation;

	private Vector3 m_VerticalPreviewShadowPos;

	private Vector3 m_ZoomInCamPos;

	private Vector3 m_ZoomOutCamPos;

	public const float m_MoveTime = 0.8f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void SetBtnState(bool flag)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override bool IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override void OpenPreview()
	{
	}

	public override void OnPopupWindowListChange()
	{
	}

	public void SetData(FrontEndPreviewComponent.ShowPreviewType previewType, bool isZoomIn, uint itemId, ECollectionLevel backpackLevel, PreviewShowAvatarParams previewShowAvatarParams, bool adjustBackPackRotation)
	{
	}

	public void ShowVerticalPreview(bool adjustBackPackRotation)
	{
	}

	private void AdaptationBGSize()
	{
	}

	private void InitCameraMovePosData()
	{
	}

	private void OnExitBtnClicked()
	{
	}

	private void ChangeLayer(Transform trans, string targetLayer)
	{
	}

	private void OnZoomInOutBtnClicked()
	{
	}

	private void OnTakePhotoBtnClick()
	{
	}

	public void SetGravityAlignX()
	{
	}

	private void RefreshBGCDN()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OpenPreview()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
