using System.Text;
using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudSignalController : UIBaseController
{
	private enum PingValueState
	{
		Low,
		Middle,
		High
	}

	private UIHudSignalView m_View;

	private float m_LastUpdateTime;

	private StringBuilder m_StringBuilder;

	private int mLastPing;

	private float m_FakePingRate;

	private bool m_HasSendNotHighPing;

	private float m_LastNotHighPingTime;

	private static readonly Color RED_COLOR;

	private static readonly Color YELLOW_COLOR;

	private int m_PingMax;

	private float pingTimer;

	private int pingSection;

	private int lastShowPing;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	private int GetShowPingValue()
	{
		return 0;
	}

	private PingValueState GetPingValueState(int pingValue)
	{
		return PingValueState.Low;
	}

	private int getCurPintSection(int showPing)
	{
		return 0;
	}

	private float getCurPintTimer(int section)
	{
		return 0f;
	}

	private string formatPingValue(int value)
	{
		return null;
	}

	private void UpdateAndSendNotHighPing(int pingValue)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
