using System.Collections.Generic;
using UnityEngine;

public class CSGameZoneAirDrop : MonoBehaviour
{
	public enum EAirDropType
	{
		NormalAirdrop,
		TechAirdrop
	}

	public bool IsMultiple;

	public static readonly Color AirDropGizmosColor;

	public static readonly Color TechAirDropGizmosColor;

	public EAirDropType type;

	public List<Transform> SpawnPointList;

	public List<bool> NormalAirdropCustomizedSpawnPosList;
}
