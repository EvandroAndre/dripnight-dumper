using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudGameShowInfoController : UIBaseController
{
	private uint m_ShowinfodelayCall;

	private UIHudGameShowInfoView m_View;

	public Dictionary<int, UIHudGameShowInfoStyleController> m_StyleCtrlDict;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIdata(EGameShowStyle style, string introKey = "", string introDeatil = "", float duration = 2f)
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void _003CSetUIdata_003Eb__5_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
