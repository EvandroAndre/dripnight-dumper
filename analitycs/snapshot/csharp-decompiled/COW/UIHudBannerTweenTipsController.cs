using GCommon;

namespace COW;

internal class UIHudBannerTweenTipsController : UIBaseController
{
	private UIHudBannerTweenTipsView m_View;

	private uint m_DelayCallID;

	private BannerTweenTipPriority m_Priority;

	private UITutorialIndicatorCharacterController m_CharacterCtrl;

	protected override void OnDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(string message, BannerTweenTipPriority priority, bool showCharacter, float duration, bool show, ResourceID iconRes)
	{
	}

	private void RefreshData(string message, BannerTweenTipPriority priority, bool showCharacter, ResourceID iconRes)
	{
	}

	private void AutoHide()
	{
	}

	private void CancelDelayCall()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
