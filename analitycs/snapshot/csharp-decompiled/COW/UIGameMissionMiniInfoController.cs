using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIGameMissionMiniInfoController : UIBaseController
{
	private UIGameMissionMiniInfoView m_View;

	private IPLIFLLGADH m_Mission;

	private MMDOMLCHMNA m_GlobalMission;

	private OIPAENADDML m_OniMissionUIData;

	private float m_TimeCount;

	private bool m_HasTimeWaring;

	private UITable m_ParentTable;

	private MutableString m_CountdownStr;

	public int SortPriority => 0;

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

	public void SetViewData(IPLIFLLGADH mission, UITable parentTable)
	{
	}

	public void SetViewData(MMDOMLCHMNA mission, UITable parentTable)
	{
	}

	public void SetViewData(OIPAENADDML mission, UITable parentTable)
	{
	}

	private void Update()
	{
	}

	private void UpdateOniMission()
	{
	}

	private void UpdateGlobalMission()
	{
	}

	private void UpdateMission()
	{
	}

	private void UpdateCountDown(float time, float timeLimit)
	{
	}

	private void OnMissionClose(object[] data)
	{
	}

	private void OnShowProgress()
	{
	}

	private void UpdateProgress()
	{
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
