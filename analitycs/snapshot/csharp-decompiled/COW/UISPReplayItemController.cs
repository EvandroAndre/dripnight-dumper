using System;
using GCommon;

namespace COW;

public class UISPReplayItemController : UIEasyListItemController
{
	private UISPReplayItemView m_View;

	private TimeSpan m_Span;

	private ReplayInfo m_CurInfo;

	private UIModelReplay m_Model;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnPlayClick()
	{
	}

	private void OnDelClick()
	{
	}

	private string Replace(string origin)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
