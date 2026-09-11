using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudReviveMissionMarkController : UIBaseController
{
	private UIHudReviveMissionMarkView m_View;

	private HLHJFCHJHIO m_HuntInfo;

	private float m_TickCount;

	private bool isPlayerDead;

	private uint m_DelayCallID;

	private const float TIME_TO_REFRESH = 1f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(HLHJFCHJHIO huntInfo)
	{
	}

	public void SetDeadInfo(float duration)
	{
	}

	private void Update()
	{
	}

	private void DeadEnd()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
