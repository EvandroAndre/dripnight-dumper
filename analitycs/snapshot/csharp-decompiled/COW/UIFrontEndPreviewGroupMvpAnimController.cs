using System;
using GCommon;

namespace COW;

public class UIFrontEndPreviewGroupMvpAnimController : UIPreviewPopUpWindowController
{
	private UIFrontEndPreviewZoomInWithCameraView m_View;

	private Action m_CloseAction;

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

	protected override void OnDestroy()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	public void ShowGroupAnim(uint groupAnimId, Action action = null)
	{
	}

	public void ShowCameraEmote(uint emoteId, Action action = null)
	{
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override void OpenPreview()
	{
	}

	protected override void ClosePreview()
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OpenPreview()
	{
	}

	public void _003C_003EiFixBaseProxy_ClosePreview()
	{
	}
}
