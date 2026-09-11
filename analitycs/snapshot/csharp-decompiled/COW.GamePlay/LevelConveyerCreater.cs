using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

public class LevelConveyerCreater : MonoBehaviour
{
	public float StartMoment;

	public int MaxPlatformNum;

	public GameObject PlatformPrefab;

	public Transform PlatformRoot;

	public GameObject EmptyPointPrefab;

	public Transform PointRoot;

	public float TimeScalePara;

	public List<GameObject> CacheList;

	public List<LevelConveyerPlatform> PlatformList;

	public List<GameObject> CachePointList;

	public bool IsDebug;

	public float DirectSpeed;

	public float EdgeAngle;

	public float EdgeOffset;

	public Transform StartPoint;

	public Transform EndPoint;

	public Transform[] RectPoints;

	public List<Transform> EdgePoints;

	public Transform[] CentrePoints;

	public float EdgeLength;

	public float EdgeMoveTime;

	public float EdgeSpeed;

	public float PerRoundTime;

	public float[] MoveTimeArray;

	private void Start()
	{
	}

	private Transform AHBPMKIBPOO()
	{
		return null;
	}

	public void OnDrawGizmos()
	{
	}

	public void ChangeTriggerSizeForHippo()
	{
	}
}
