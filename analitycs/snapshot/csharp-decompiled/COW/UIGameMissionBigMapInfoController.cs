using System;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIGameMissionBigMapInfoController : UIBaseController
{
	private UIGameMissionBigMapInfoView m_View;

	private IPLIFLLGADH m_Mission;

	private float m_TimeCount;

	private bool m_HasTimeWarning;

	private Action<uint> m_OnClose;

	private bool m_NeedUpdateCountDown;

	private bool m_UseCountStr;

	private MutableString m_CountStr;

	private MutableString m_ProgressStr;

	public uint MissionID;

	private bool m_IsMissionAffix;

	private uint m_AffixID;

	private float m_lastProgress;

	private int m_LastProgressPercent;

	private int m_LastCount;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetFakeViewData()
	{
	}

	public void SetViewData(IPLIFLLGADH mission, string description, Action<uint> onClose)
	{
	}

	public void SetMissionAffixViewData(GameplayAffixConfigData affixConfigData)
	{
	}

	public void ResetGlobalMission(uint missionID)
	{
	}

	private void OnGameMissionProgressChanged(uint missionID)
	{
	}

	private void Update()
	{
	}

	public void RefreshProgress()
	{
	}

	public void RefreshReward()
	{
	}

	public void UpdateCountDown(bool isForceUpdate = false)
	{
	}

	public void TableReposition()
	{
	}

	private void UpdateMissionCountDown(bool isForceUpdate = false)
	{
	}

	private void UpdateGlobalMissionCountDown(bool isForceUpdate = false)
	{
	}

	private void SetCountdownText(float time)
	{
	}

	private void OnMissionClose(object[] data)
	{
	}

	public UIWidget GetContainerWidget()
	{
		return null;
	}

	public uint GetMissionID()
	{
		return 0u;
	}

	public bool IsMissionAffix()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
