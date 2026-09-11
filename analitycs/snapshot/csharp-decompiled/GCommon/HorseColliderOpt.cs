using COW.GamePlay;
using UnityEngine;

namespace GCommon;

public class HorseColliderOpt : MonoBehaviour
{
	public Collider[] collidersFor1p;

	public Collider[] collidersFor3p;

	public Collider[] collidersForEffect;

	private VehicleEffect[] collidersForWater;

	public Collider[] colliderForDust;

	private bool isLocalPlayerDriver;

	private bool hasDriver;

	public void OnDriverGetOn(bool localPlayer)
	{
	}

	public void OnDriverGetOff(bool localPlayer)
	{
	}

	private void EnableColliders(Collider[] colliders, bool enabled)
	{
	}

	public void OnAwake()
	{
	}

	public void SetEnterLevelTrigger(string tag, bool enter)
	{
	}
}
