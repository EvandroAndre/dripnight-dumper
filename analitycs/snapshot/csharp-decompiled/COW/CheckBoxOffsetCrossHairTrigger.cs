using UnityEngine;

namespace COW;

internal class CheckBoxOffsetCrossHairTrigger : CheckBoxCrossHairTrigger
{
	private Vector3 m_DestPos;

	public override bool HasAgainstEntities()
	{
		return false;
	}

	public override void UpdateOffYWithDeg(float deg)
	{
	}

	protected override void CheckUpdateOff(float deg, float checkDeg)
	{
	}

	public override Vector3 GetSpawnPosition()
	{
		return default(Vector3);
	}

	public new bool _003C_003EiFixBaseProxy_HasAgainstEntities()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_UpdateOffYWithDeg(float P0)
	{
	}

	public void _003C_003EiFixBaseProxy_CheckUpdateOff(float P0, float P1)
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_GetSpawnPosition()
	{
		return default(Vector3);
	}
}
