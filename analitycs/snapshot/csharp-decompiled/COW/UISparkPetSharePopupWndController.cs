using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetSharePopupWndController : UIPopupWindowController
{
	private UISparkPetSharePopupWndView m_View;

	private UIModelSparkPet m_ModelSparkPet;

	private bool m_IsBGLoadSuccess;

	private bool m_IsSelfSparkPetCreated;

	private uint m_ScreenShotDelayCall;

	private UIWaitingForRequestCircleController m_WaitingCircleController;

	private UISparkPetAvatar m_SelfSparkPetAvatar;

	private uint m_AsyncCreateSelfSparkPetTicket;

	private RenderTexture m_OffscreenRT;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIOpen()
	{
	}

	public void ShareSparkPetPoster()
	{
	}

	private void RefreshLeftPanelInfo()
	{
	}

	private void CreateSparkPetAvatars()
	{
	}

	private void OnSparkPetCreated(uint ticket, UISparkPetAvatar sparkPetAvatar, uint sparkAvatarType)
	{
	}

	private void PositionSparkPet()
	{
	}

	private void CleanupSparkPetAvatars()
	{
	}

	private void SetupBGTexture()
	{
	}

	private void TryScreenShot()
	{
	}

	private void _003CSetupBGTexture_003Eb__20_0()
	{
	}

	private void _003CTryScreenShot_003Eb__21_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
