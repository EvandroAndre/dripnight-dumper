using System.Collections.Generic;
using GCommon;

namespace COW;

public class UINewPlayerUnlockFeatureBannerController : UIBaseController
{
	private UINewPlayerUnlockFeatureBannerView m_View;

	private uint m_GameMode;

	private uint m_MatchMode;

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

	public void SetViewData(List<uint> AffixIDs, uint gameMode, uint matchMode)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
