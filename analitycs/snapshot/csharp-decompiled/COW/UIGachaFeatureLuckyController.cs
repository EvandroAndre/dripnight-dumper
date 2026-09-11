using GCommon;

namespace COW;

public class UIGachaFeatureLuckyController : UIBaseController
{
	private UIGachaFeatureLuckyView m_View;

	private GachaLuckyData m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(GachaLuckyData data)
	{
	}

	public void LogTriggerLuckyRemind(bool isGachaFeature = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
