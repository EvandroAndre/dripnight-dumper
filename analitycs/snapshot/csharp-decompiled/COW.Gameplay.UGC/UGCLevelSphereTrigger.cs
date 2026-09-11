using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCLevelSphereTrigger : LevelUGCCustomizeTrigger, DDAFIHCLBBB
{
	public Transform right;

	public Transform center;

	public Transform left;

	public SphereCollider sphereCollider;

	private float m_radius;

	protected override string GetObjectTag()
	{
		return null;
	}

	public override void OnSyncUGCEntityProperty(long propertyIndex, UGCSimpleValue newValue)
	{
	}

	public void SetSphereRadius(float radius)
	{
	}

	public void SetSize()
	{
	}

	public new string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}
}
