using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using LitJson;
using UnityEngine;

namespace COW;

public class InGameTeamGoalManager : SingletonModule<InGameTeamGoalManager>
{
	public class InGameTeamGoalPathConfigDataItem
	{
		public int ZoneIndex;

		public int TeamIndex;

		public List<Vector3> Position;
	}

	private string m_CurMapName;

	private Dictionary<int, List<InGameTeamGoalPathConfigDataItem>> m_InGameTeamGoalPathConfigDataDict;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public bool CheckTeamGoalOpen(DFMAGBNLCHD type = DFMAGBNLCHD.AirDropInteractTech)
	{
		return false;
	}

	public bool CheckEnemyMarkShow()
	{
		return false;
	}

	private void InitInGameTeamGoalPathConfig(string mapName)
	{
	}

	private Vector3 JsonData2Vector3(JsonData position)
	{
		return default(Vector3);
	}

	public List<Vector3> GetTeamGoalPathNodes(int zoneIndex, int teamIndex, Vector3 targetPos)
	{
		return null;
	}

	public bool CheckIsShowCSTeamGoalPath(uint id)
	{
		return false;
	}

	private DFMAGBNLCHD CSTeamGoalPathType2AirdropInteractType(uint type)
	{
		return DFMAGBNLCHD.AirDropInteractLock;
	}

	public byte AirdropInteractType2CSTeamGoalPathType(DFMAGBNLCHD type)
	{
		return 0;
	}
}
