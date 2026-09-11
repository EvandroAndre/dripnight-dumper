using System.Collections.Generic;
using UnityEngine;

public class SpawnGroup : MonoBehaviour
{
	public int GroupID;

	public float Speed;

	public Vector3 SpeedDirection;

	public int Num;

	public int Weight;

	public List<SpawnConfig> DropStartPoints;
}
