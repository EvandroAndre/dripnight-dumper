using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class TrainingShootTargetArea : MonoBehaviour
{
	public class BornArea
	{
		public List<Transform> points;
	}

	public static TrainingShootTargetArea Instance;

	public Transform[] areas;

	public GameObject AirWall;

	private BornArea[] bornAreas;

	public Transform NormalTargetPos;

	public Transform CanBeKilledTargetPos;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public BornArea GetBornArea(uint value)
	{
		return null;
	}
}
