using COW.GamePlay;
using UnityEngine;

namespace COW;

public class GameMissionPlayerRangeObject
{
	private GameMissionPlayerRangeView m_View;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private uint m_GameMissionID;

	private BHGGAEEHJCO m_WantedPlayerID;

	private Vector3 m_WantedDeltaPosition;

	private bool m_Recycled;

	private float m_CountDown;

	private float m_RefreshCD;

	public uint WantedGameMissionID => 0u;

	public void OnUIInit(GameMissionPlayerRangeView view, UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void OnUIDestroy()
	{
	}

	public void SetIconScale(Vector3 mapIconScale)
	{
	}

	public void StartMission(uint missionID, BHGGAEEHJCO playerID, Vector3 deltaPos, float refreshCD, uint realMissionID, Vector3 mapIconScale)
	{
	}

	public void UpdateMissionWantedPlayerPosition(float deltaTime)
	{
	}

	private void OnNeedWantedRangeChange(object[] data)
	{
	}

	private void OnPlayerIDChange(object[] data)
	{
	}

	private void OnMissionEnd(object[] data)
	{
	}

	public bool IsRecycled()
	{
		return false;
	}
}
