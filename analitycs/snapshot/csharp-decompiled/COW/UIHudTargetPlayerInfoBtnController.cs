using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudTargetPlayerInfoBtnController : UIBaseController
{
	private UIHudTargetPlayerInfoBtnView m_View;

	private uint m_DelayCallId;

	private BHGGAEEHJCO m_PlayerID;

	private bool m_ActionVisible;

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

	private void OnClickActionBtn()
	{
	}

	private void AimAtPlayerStart(uint playerID)
	{
	}

	private void AimAtPlayerEnd(float delayHideTime)
	{
	}

	private void SetActionVisible(bool visible)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
