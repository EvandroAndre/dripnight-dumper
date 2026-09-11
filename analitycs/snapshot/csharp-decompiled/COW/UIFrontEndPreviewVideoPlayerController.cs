using GCommon;

namespace COW;

public class UIFrontEndPreviewVideoPlayerController : UIBaseController
{
	private UIFrontEndPreviewVideoPlayerView m_View;

	private PreviewVideoParams m_PreviewVideoParams;

	private bool m_HasClickedPlayBtn;

	public bool IsPlaying => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetViewData(PreviewVideoParams videoParasms)
	{
	}

	private void OnStartPlayBtnClick()
	{
	}

	private void PrepareVideo()
	{
	}

	private void OnVideoPrepareCallback()
	{
	}

	private void SetTextureSize()
	{
	}

	private void CloseVideoPreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
