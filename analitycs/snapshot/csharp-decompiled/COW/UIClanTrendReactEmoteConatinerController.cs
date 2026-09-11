using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIClanTrendReactEmoteConatinerController : UIBaseController
{
	private UIClanTrendReactEmoteConatinerView m_View;

	private ClanTrendMsgInfo m_ReactToMsgInfo;

	private List<UIClanTrendReactEmoteItemController> m_emoteContianer;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitEmoteShow()
	{
	}

	public void RefreshMsgInfo(ClanTrendMsgInfo info)
	{
	}

	public ClanTrendMsgInfo GetMsgInfo()
	{
		return null;
	}

	public ulong GetMsgId()
	{
		return 0uL;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
