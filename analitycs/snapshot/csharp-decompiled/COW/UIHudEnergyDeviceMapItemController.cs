using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudEnergyDeviceMapItemController : UIBaseController
{
	private UIHudEnergyDeviceMapItemView m_View;

	private uint m_BindId;

	private EUIHudEnergyDeviceMapItemState m_State;

	private LevelEnergyDevice m_EnergyDevice;

	private VisualInstanceHolder m_EnemyVfx;

	public Vector2 WorldPos;

	public EUIHudEnergyDeviceMapItemState State => EUIHudEnergyDeviceMapItemState.Default;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void OnUIReInit()
	{
	}

	public void BindEnergyDevice(LevelEnergyDevice energyDevice)
	{
	}

	public void SetProgress(float progress)
	{
	}

	public void SetArrowRotation(bool active, Quaternion rotation)
	{
	}

	public void SetInfo(EUIHudEnergyDeviceMapItemState state)
	{
	}

	private void OnObserverChanged(object[] data)
	{
	}

	private void OnChargeProgressChanged(object[] param)
	{
	}

	private void OnStateChanged(object[] param)
	{
	}

	public uint GetLevelObjectID()
	{
		return 0u;
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}
}
