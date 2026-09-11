using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudWinterLandGameMissionController : UIBaseController, IGameMissionTopEventUI
{
	private UIHudWinterLandGameMissionView m_View;

	private UITimeLabelHelper m_TimeLabelHelper;

	private readonly Color ActiveColor;

	private readonly Color DisActiveColor;

	private const string Key_IslandMoveToMid = "T_51_YS_WL_STATE_MOVE_NEW";

	private const string Key_IslandMoveToEnd = "T_51_YS_WL_STATE_MOVE_NEW_2";

	private const string Key_IslandStayingEnd = "T_51_YS_WL_STATE_MOVE_NEW_3";

	private const string Key_IslandDreamTips = "T_51_YS_WL_DREAM_GOOG";

	private const string Key_IslandNightmareTips = "T_51_YS_WL_DREAM_BAD";

	private uint? m_IslandState;

	private float? m_IslandProgress;

	private float m_UpdateIntervalElapsedTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void InitDataOnOpenFromGameMissionUI(object data)
	{
	}

	public float NeedHeight()
	{
		return 0f;
	}

	private void Update()
	{
	}

	private void UpdateByInterval(float deltaTime)
	{
	}

	private void UpdateUIView()
	{
	}

	private float CalIslandProgress(int gameTimeMilliSec, CJILMLAAAKC islandState, COPHFAJPHMM islandTimeInfo)
	{
		return 0f;
	}

	private void SetIslandProgress(float value)
	{
	}

	private void SetIslandState(int gameTimeMilliSec, CJILMLAAAKC islandState, COPHFAJPHMM islandTimeInfo)
	{
	}

	private void SetTips2ByWinterlandType(LFDPLGFFOGE type)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
