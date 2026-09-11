using System.Collections.Generic;
using GCommon;
using LitJson;
using UnityEngine;

namespace COW;

public class InGameBattleBoardManager : SingletonModule<InGameBattleBoardManager>
{
	public enum BoardShowType
	{
		BoardShowTypeNone,
		BoardShowTypeSelf,
		BoardShowTypeCompare
	}

	public enum BoardShowCDNType
	{
		SelfMvpBG = 1,
		CompareMvpBG,
		AvatarCDNMaleLeft,
		AvatarCDNMaleRight,
		AvatarCDNFemaleLeft,
		AvatarCDNFemaleRight
	}

	public enum MVPContentType
	{
		MVP_CONTENT_KILL = 1,
		MVP_CONTENT_DAMAGE,
		MVP_CONTENT_ASSIST,
		MVP_CONTENT_REVIVE,
		MVP_CONTENT_HEAL,
		MVP_CONTENT_HEADSHOT
	}

	public class InGameBattleBoardPathConfigDataItem
	{
		public int ZoneIndex;

		public int TeamIndex;

		public Vector3 Position;

		public Vector3 EulerAngles;

		public float BoardScale;
	}

	public ResourceID BATTLEBOARD_ANIM_FEMALE_LEFT;

	public ResourceID BATTLEBOARD_ANIM_MALE_LEFT;

	public ResourceID BATTLEBOARD_ANIM_FEMALE_RIGHT;

	public ResourceID BATTLEBOARD_ANIM_MALE_RIGHT;

	private string m_CurMapName;

	private Dictionary<int, List<InGameBattleBoardPathConfigDataItem>> m_InGameBattleBoardPosConfigDataDict;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public bool CheckBattleBoardMatchMode()
	{
		return false;
	}

	private void InitInGameBattleBoardConfig(string mapName)
	{
	}

	private Vector3 JsonData2Vector3(JsonData jsonArray)
	{
		return default(Vector3);
	}

	private float JsonData2Float(JsonData jsonValue, float defaultValue = 0.004f)
	{
		return 0f;
	}

	public bool GetBattleBoardTransformData(int zoneIndex, int teamIndex, out Vector3 position, out Vector3 rotation, out float boardScale)
	{
		position = default(Vector3);
		rotation = default(Vector3);
		boardScale = default(float);
		return false;
	}
}
