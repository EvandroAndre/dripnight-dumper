using System;
using GCommon;

namespace COW;

public class PhotographModeController : UIBaseController
{
	private enum PhotoHideMode
	{
		PhotoHideMode_ShowAll,
		PhotoHideMode_TeammateOnly,
		PhotoHideMode_HideAll
	}

	private PhotographModeView m_View;

	private Action m_TakePhotoCallBack;

	private ResourceID m_SoundId;

	private bool m_IsCoverDefaultSound;

	private PhotoHideMode m_CurHideMode;

	public static readonly string PARTY_PHOTOGRAPH_HIDEMODE_SHOW_ALL;

	public static readonly string PARTY_PHOTOGRAPH_HIDEMODE_TEAMMATE_ONLY;

	public static readonly string PARTY_PHOTOGRAPH_HIDEMODE_HIDE_ALL;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void OnPlayerStateChange(GEvent data)
	{
	}

	public void SetTakePhotoParam(Action takePhotoCallBack, ResourceID soundId, bool isCoverDefaultSound)
	{
	}

	private void TakePhoto()
	{
	}

	private void FromSharePage()
	{
	}

	private void OnHideOthersClick()
	{
	}

	private void UpdateHideOthersBtnIcon()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	private void ScaleCamera()
	{
	}

	private void ExitPhotographMode()
	{
	}

	private void OpenEmotePanel()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}
}
