using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

public class IceWallCrossHairTrigger : MonoBehaviour
{
	public bool CheckPlayer;

	public bool CheckVehicle;

	public bool CheckCannon;

	public bool CheckPortal;

	public bool CheckDeIceWall;

	public bool CheckHelicopter;

	public bool CheckMountableAnimal;

	private Dictionary<BHGGAEEHJCO, List<Collider>> mPlayersInside;

	private Dictionary<uint, List<Collider>> mVehiclesInside;

	private Dictionary<uint, List<Collider>> mCannonsInside;

	private Dictionary<uint, List<Collider>> mPortalsInside;

	private Dictionary<uint, List<Collider>> mDeIceWallInside;

	private HashSet<uint> mHasPlayersInsideVehicles;

	private HashSet<uint> mHashelicopterInside;

	private HashSet<uint> mHasMountableAnimalInside;

	private bool mAreaOccupied;

	public bool AreaOccupied => false;

	public bool IsHitDeIceWall => false;

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	private void OnVehicleDead(object[] data)
	{
	}

	private void OnVehicleSeatChange(object[] data)
	{
	}

	private void OnDeIceWallRemoved(object[] data)
	{
	}

	private void OnPortalRemoved(object[] data)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void OnObjInsideChanged()
	{
	}
}
