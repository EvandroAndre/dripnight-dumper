using System.Text;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCClockEntityObject : BaseAutoGenIDLevelObject
{
	private enum State
	{
		Stop,
		Wait,
		Play,
		Pause
	}

	protected TextMesh m_textMesh;

	private bool m_isCountdown;

	private StringBuilder m_Timer;

	private State m_state;

	private int m_duration;

	private int m_endTime;

	private int m_lastSeconds;

	protected override string GetObjectTag()
	{
		return null;
	}

	public override bool CreateDynamicallyForUGC(string entityID)
	{
		return false;
	}

	public override void OnSyncUGCEntityProperty(long propertyIndex, UGCSimpleValue newValue)
	{
	}

	public void SetText(string value)
	{
	}

	private void Update()
	{
	}

	private void RefreshText(int seconds)
	{
	}

	private string GetTextString(int seconds)
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}
}
