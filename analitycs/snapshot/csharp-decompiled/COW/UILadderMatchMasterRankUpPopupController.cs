using GCommon;
using UnityEngine;

namespace COW;

internal class UILadderMatchMasterRankUpPopupController : UIPopupWindowController
{
	private UILadderMatchMasterRankUpPopupView m_View;

	private uint m_DelayCallId;

	private Vector3 m_DefaultRankScale;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetData(PeakRankData data, string info)
	{
	}

	private void OnButtonClick()
	{
	}

	private void _003COnUIInit_003Eb__4_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
