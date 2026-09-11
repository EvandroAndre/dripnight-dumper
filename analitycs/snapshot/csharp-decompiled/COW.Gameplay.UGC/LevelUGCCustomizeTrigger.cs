using COW.GamePlay;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class LevelUGCCustomizeTrigger : BaseAutoGenIDLevelObject, DDAFIHCLBBB
{
	private UGCEntityRepItem m_EntityRepItem;

	private bool m_bShowVFX;

	public GameObject EditOnlyModel;

	public bool BShowVfx => false;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	protected override void SetRigidbody4ClientEntity(string entityID, string archTypeID)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public void SetModelVisible(bool visble)
	{
	}

	public void SetEntityID()
	{
	}

	public override void SyncAction(object[] param)
	{
	}

	private void DoUgcLevelObjectDel()
	{
	}

	public void ProcessTriggerColliderInCrossHairState()
	{
	}

	private void OnEnableChangeEvent(bool newValue)
	{
	}

	public virtual void ShowVfx(bool show)
	{
	}

	public override bool CreateDynamicallyForUGC(string entityID)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_SetRigidbody4ClientEntity(string P0, string P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}
}
