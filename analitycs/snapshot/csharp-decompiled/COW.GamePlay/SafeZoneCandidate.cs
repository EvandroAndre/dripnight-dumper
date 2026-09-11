using UnityEngine;

namespace COW.GamePlay;

public class SafeZoneCandidate : MonoBehaviour
{
	public int SafeZoneCandidateID;

	public int Weight;

	public float Radius;

	public SafeZoneCandidateAirDrop[] AirDrops;

	public SafeZoneCandidateAirDrop[] TechAirDrops;

	public SafeZoneCandidateAirDrop[] MultipleAirDrops;

	public void SearchAirDropsInChildren()
	{
	}

	public void FixPositionToGround()
	{
	}
}
