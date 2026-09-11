using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudMetropolisAreaInfoController : UIBaseController
{
	private UIHudMetropolisAreaInfoView m_View;

	private CLKBJIJFFOK m_AreaInfo;

	private UITimeLabelHelper m_TimeHelper;

	public uint AreaID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetAreaInfo(CLKBJIJFFOK info)
	{
	}

	public void UpdateAreaState()
	{
	}

	public void UpdatePlayerCount()
	{
	}

	public void UpdateAreaStateEndTime()
	{
	}

	public void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
