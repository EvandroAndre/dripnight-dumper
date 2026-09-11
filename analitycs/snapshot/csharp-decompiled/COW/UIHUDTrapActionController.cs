using GCommon;

namespace COW;

public class UIHUDTrapActionController : UIBaseController
{
	private UIHUDTrapActionView m_View;

	private int m_RescureTrapID;

	private bool m_IsBeginInTrapAnim;

	private float m_InTrapEndTime;

	private float m_TrapDuration;

	private uint m_DelayRescureID;

	private float m_ResucreEndTime;

	private float m_ResucreUseTime;

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

	public void ShowInTrap(float endTime, float totalTime)
	{
	}

	public void EnterTrapRescureTrigger(int trapID)
	{
	}

	public void ExitTrapRescureTrigger()
	{
	}

	private bool IsInRescuring()
	{
		return false;
	}

	private void BeginRescure()
	{
	}

	private void CanclRescure()
	{
	}

	private void RequestServerRescure()
	{
	}

	private void OnCanclAction(GEvent param)
	{
	}

	private void Update()
	{
	}

	private void UpdateInTrapAnim()
	{
	}

	private void UpdateRescureAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
