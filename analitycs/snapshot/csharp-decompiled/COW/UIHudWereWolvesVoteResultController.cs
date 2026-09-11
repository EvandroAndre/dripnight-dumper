using GCommon;

namespace COW;

public class UIHudWereWolvesVoteResultController : UIBaseController
{
	public enum WereWolvesBannerType
	{
		Eject,
		Alert
	}

	private UIHudWereWolvesVoteResultView m_View;

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

	protected override void OnUIOpen()
	{
	}

	private void OnBannerInfo(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
