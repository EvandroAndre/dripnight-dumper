using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudDirectionRulerController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal int _003C_002Ecctor_003Eb__73_0(UIHudDirectionRulerTeamMarkItem a, UIHudDirectionRulerTeamMarkItem b)
		{
			return 0;
		}
	}

	public const uint VISIBILITY_STATE_EighthLand = 1073741824u;

	public const uint VISIBILITY_STATE_GB_GPGulag = 536870912u;

	private UIHudDirectionRulerView m_View;

	private UILabel[] m_ScaleValues;

	private UISprite[] m_TeamMark;

	private float m_RulerPosY;

	private float m_MarkPosY;

	private int m_NumScaleInternal;

	private Vector3 m_SinglePlayerMarkPos;

	private Vector3 m_SaveZonePos;

	private SafeZone m_SafeZone;

	private float m_ScaleDisDelta;

	private const int m_AngleInterval = 15;

	private Vector3 hideMarkPosition;

	private Dictionary<int, string> m_ScaleStringDic;

	private bool isSolo;

	private Dictionary<uint, string> m_CurAngleStringDic;

	private Dictionary<uint, GameObject> m_TreasureMarkDict;

	private Dictionary<uint, Vector3> m_TreasureMarkPosDict;

	private HLHJFCHJHIO m_HuntReviveInfo;

	private Vector3 m_HuntReviveMarkPos;

	private float m_HuntReviveTickCount;

	private const float TIME_TO_REFRESH = 1f;

	private const float m_length = 432f;

	private float m_ruler1PosX;

	private float m_ruler2PosX;

	private UIHudDirectionRulerTeamMarkItem m_teamMarkOrig;

	private List<UIHudDirectionRulerTeamMarkItem> m_teamMarkInfos;

	private Queue<UIHudDirectionRulerTeamMarkItem> m_teamMarkInfoPool;

	private static readonly Comparison<UIHudDirectionRulerTeamMarkItem> s_teamMarkComparer;

	private UIHudDirectionRulerRetreatPointMarkItem m_retreatPointMarkOrigin;

	private Dictionary<uint, UIHudDirectionRulerRetreatPointMarkItem> m_hippoCrisisRetreatMarks;

	private Queue<UIHudDirectionRulerRetreatPointMarkItem> m_hippoCrisisRetreatMarksPool;

	private Dictionary<uint, UIReviveBoxRulerIconController> m_reviveBoxRulerMarks;

	private Queue<UIReviveBoxRulerIconController> m_reviveBoxRulerMarkPool;

	private HashSet<uint> m_visibleReviveBoxRulerMarkIDs;

	private List<uint> m_tmpReviveBoxRulerMarkIDs;

	private Dictionary<BHGGAEEHJCO, Vector3> m_reviveBoxMapMarkPositions;

	private const float ReviveBoxMapMarkMatchDistanceSqr = 25f;

	private void RemoveTeamMark(BHGGAEEHJCO playerID)
	{
	}

	private void ShowTeamMark(Vector3 pos, int teamIndex, BHGGAEEHJCO playerId)
	{
	}

	private void UpdateTeamMark(float rulerPosX, int startDirection, Player m_Player)
	{
	}

	private void ClipMarkPos(UIHudDirectionRulerTeamMarkItem item)
	{
	}

	private void OnRemoveMapMark(object[] data)
	{
	}

	private void OnUpdateMapMark(object[] data)
	{
	}

	private void UpdateReviveBoxMapMark(BHGGAEEHJCO playerId, object[] data)
	{
	}

	private bool TryGetUInt(object value, out uint result)
	{
		result = default(uint);
		return false;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	private float GetRotationAngleFromView(Player m_Player)
	{
		return 0f;
	}

	private float GetFinalRulerScaleByVector3(Vector3 v)
	{
		return 0f;
	}

	private void UpdateReviveBoxRulerMarks(int startDirection, Player m_Player)
	{
	}

	private bool ShouldShowReviveBoxRulerMark(LevelReviveBox reviveBox, Player m_Player)
	{
		return false;
	}

	private bool IsReviveBoxMapMarked(LevelReviveBox reviveBox, Player m_Player)
	{
		return false;
	}

	private UIReviveBoxRulerIconController GetOrCreateReviveBoxRulerMark(LevelReviveBox reviveBox)
	{
		return null;
	}

	private void RecycleInvisibleReviveBoxRulerMarks()
	{
	}

	private void ClearReviveBoxRulerMarks()
	{
	}

	private void UpdateMarkAndSaveZoneDirection(int startDirection, Player m_Player)
	{
	}

	private void InitCurAngleStringDic()
	{
	}

	private void RefreshCurAngleLabel(int angle)
	{
	}

	private void UpdateMarkUI(int startDirection, Vector3 markPos, Transform markSprite, Player m_Player, float markPosY, bool forceShow = false)
	{
	}

	private void OnTreasureMarked(object[] param)
	{
	}

	private void OnTreasureContainerDelete(object[] param)
	{
	}

	private void OnHuntRevivePlayerChanged(object[] data)
	{
	}

	private void OnRetreatPointChanged(object[] data)
	{
	}

	private void OnRetreatPointMarkShow(object[] data)
	{
	}

	private void UpdateRetreatPointMarks(int startDirection, Player m_Player)
	{
	}

	public Vector3 GetRetreatPointMarkPos(uint retreatPointID)
	{
		return default(Vector3);
	}

	private void UpdateHuntRevivePlayerMark(bool forceUpdateProgress = false)
	{
	}

	private void OnStartMatchEndShow(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
