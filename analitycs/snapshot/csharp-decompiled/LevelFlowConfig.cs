using System.Collections.Generic;
using UnityEngine;
using message;

public class LevelFlowConfig : MonoBehaviour
{
	public int LevelID;

	public FINFLPILCEB LevelFinishType;

	public float LevelTimeMinute;

	public float LevelScore;

	public List<RankScore> RankScoreConifg;

	public List<Transform> LevelPlayerStartPoints;

	public List<Collider> FinishTriggers;

	public List<Collider> KillZones;

	public List<Collider> CheckPointTriggers;
}
