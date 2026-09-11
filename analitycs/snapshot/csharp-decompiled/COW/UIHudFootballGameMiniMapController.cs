using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFootballGameMiniMapController : UIBaseController
{
	private class PlayerIcon
	{
		public byte TeamID;

		public GameObject Icon;
	}

	private Player m_LocalPlayer;

	private UIHudFootballGameMiniMapView m_View;

	private Vector3 m_WorldCorner1;

	private Vector3 m_WorldCorner2;

	private Vector3 m_WorldCorner3;

	private Vector3 m_WorldAnchorUp;

	private Vector3 m_MapAnchorUp;

	private float m_WorldWidth;

	private float m_WorldHeight;

	private float m_MapWidth;

	private float m_MapHeight;

	private List<GameObject> m_FootballPool;

	private List<GameObject> m_TeammatePool;

	private List<GameObject> m_OpponentPool;

	private Dictionary<uint, GameObject> m_ActiveFootballs;

	private Dictionary<uint, PlayerIcon> m_ActivePlayers;

	private Vector3 m_FootballMatchRotate;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Init()
	{
	}

	private Player GetLocalPlayer()
	{
		return null;
	}

	private void Update()
	{
	}

	private void RotateMap(byte teamID)
	{
	}

	private void SetIconPosition(Vector3 worldPos, GameObject icon)
	{
	}

	private void SetIconRotation(Vector3 forward, GameObject icon)
	{
	}

	private void OnPlayerChange(object[] data)
	{
	}

	private void OnPlayerChange2(uint data, uint data2)
	{
	}

	private void OnPlayerChange(uint data)
	{
	}

	private void RemovePlayerIcon(BHGGAEEHJCO playerID)
	{
	}

	private void AddPlayerIconIfNeed(BHGGAEEHJCO playerID)
	{
	}

	private void OnFootballCreated(object[] data)
	{
	}

	private void AddFootballIcon(uint uniqueID)
	{
	}

	private GameObject PoolGet(GameObject template, List<GameObject> pool)
	{
		return null;
	}

	private void PoolReturn(GameObject go, List<GameObject> pool)
	{
	}

	private void OnShowHideChange(object[] data)
	{
	}

	private void OnTeamChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
