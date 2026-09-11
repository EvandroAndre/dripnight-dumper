using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudReconnectTipsController : UIBaseController
{
	private UIHudReconnectTipsView m_View;

	private List<string> DotStrs;

	private int m_curIndex;

	private float m_changeTime;

	private float m_lastTime;

	private bool m_dotInLeft;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetMessage(string message)
	{
	}

	private void ResetAnim()
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
