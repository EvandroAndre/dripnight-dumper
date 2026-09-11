using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudTreasuryMarkShowController : UIBaseController
{
	private TreasuryMarkShowView m_View;

	private int m_CurrentCountDown;

	private MutableString m_CountStr;

	private EUIHudTreasuryMapState m_State;

	private LevelTreasury m_Treasury;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	public void SetInfo(EUIHudTreasuryMapState state, LevelTreasury levelTreasury)
	{
	}

	public void OnTreasuryUpgraded(uint treasuryID)
	{
	}

	private void OnObserverChanged(object[] data)
	{
	}

	private void OnSpectatorChanged(object[] data)
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
