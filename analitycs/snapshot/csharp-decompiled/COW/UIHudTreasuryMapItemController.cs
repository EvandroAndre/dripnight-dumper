using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudTreasuryMapItemController : UIBaseController
{
	private UIHudTreasuryMapItemView m_View;

	private int m_CurrentCountDown;

	private MutableString m_CountStr;

	private EUIHudTreasuryMapState m_State;

	private LevelTreasury m_Treasury;

	private const float m_VfxMaxWeight = 118f;

	private float m_VfxScale;

	private bool m_InTriggerAllIsEnemy;

	private VisualInstanceHolder m_SelfScanningBlueVfxHolder;

	private VisualInstanceHolder m_EnemyScanningRedVfxHolder;

	private VisualInstanceHolder m_InTriggerAllIsEnemyVfx;

	private uint m_UpgradeVfxDelayCall;

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

	protected override void OnUIDestory()
	{
	}

	public void SetData(float scale)
	{
	}

	private void Update()
	{
	}

	public void SetInfo(EUIHudTreasuryMapState state, LevelTreasury levelTreasury)
	{
	}

	private void OnObserverChanged(object[] data)
	{
	}

	private void OnSpectatorChanged(object[] data)
	{
	}

	private void OnTreasuryUpgraded(uint treasuryID)
	{
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	private void TryReleaseAllVfxHolders()
	{
	}

	private void SetVfxScale()
	{
	}

	public uint GetLevelObjectID()
	{
		return 0u;
	}

	private void InTriggerAllIsEnemyChanged(uint id, uint boolValue)
	{
	}

	private void ShowAllIsEnemyVfx(bool show)
	{
	}

	private void ShowUpgradeVFX()
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
