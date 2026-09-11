using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCLevelCapsuleTrigger : LevelUGCCustomizeTrigger, DDAFIHCLBBB
{
	public Transform top;

	public Transform bottom;

	public Transform middle;

	public Transform parent;

	public CapsuleCollider capsuleCollider;

	public float radius;

	public float height;

	private float m_prop_radius;

	private float m_prop_height;

	protected override string GetObjectTag()
	{
		return null;
	}

	public override void OnSyncUGCEntityProperty(long propertyIndex, UGCSimpleValue newValue)
	{
	}

	public void SetCapsuleRH(float radius, float height)
	{
	}

	public void SetSize()
	{
	}

	private Vector3 GetAdjustAxle(Vector3 scale)
	{
		return default(Vector3);
	}

	public new string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}
}
