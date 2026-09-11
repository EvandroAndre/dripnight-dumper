using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.LevelObject;

public class LevelUGCSupplyBoxTrigger : LevelUGCCustomizeTrigger
{
	public enum EUGCCSupplyBoxModelType
	{
		None,
		Normal,
		Zombie
	}

	private UGCEntityRepItem m_UGCEntityRepItem;

	private UGCSupplyBoxTriggerRepItem m_ComponentData;

	private GameObject m_Model;

	private int _modelOldValue;

	private bool _enableOldValue;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	public new void SetEntityID()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void OnModelChangeEvent(int newValue)
	{
	}

	private void OnEnableChangeEvent(bool newValue)
	{
	}

	private ResourceID GetResourceIDByType(EUGCCSupplyBoxModelType type)
	{
		return default(ResourceID);
	}

	public new string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
