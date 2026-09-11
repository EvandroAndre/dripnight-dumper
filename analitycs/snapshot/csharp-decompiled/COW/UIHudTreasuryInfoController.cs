using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudTreasuryInfoController : UIBaseController
{
	public static Color TreasuryBGOpened;

	public static Color TreasuryBG2Opened;

	public static Color TreasuryBGCanOpen;

	public static Color TreasuryBG2CanOpen;

	public static Color TreasuryBGSelf;

	public static Color TreasuryBG2Self;

	public static Color TreasuryBGEnemy;

	public static Color TreasuryBG2Enemy;

	public static Color TreasuryBGKey;

	public static Color TreasuryBG2Key;

	public static Color TreasuryIconOpened;

	public static Color TreasuryIconCanOpen;

	private Color TreasuryProgressNormal;

	private Color TreasuryProgressRed;

	private Vector3 m_InTriggerPosition;

	private const float DeltaHeight = 3f;

	private UIHudTreasuryInfoView m_View;

	private LevelTreasury m_CurrentTreasury;

	private float m_TreasuryShowDis;

	private int m_TreasuryDis;

	private MutableString m_CountStr;

	private int m_CurrentCountDown;

	private EUIHudTreasuryMapState m_State;

	private Dictionary<uint, LevelTreasury> m_Treasuries;

	private StringBuilder m_DistanceStr;

	private float m_Countdown;

	private int m_PlayerCount;

	private FollowCamera m_FollowCamera;

	protected Camera m_FollowCameraComponent;

	private Color m_CurrentColor;

	private bool m_IsFighting;

	private LevelTreasury CurrentTreasury
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(float distance)
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void ComputeDistance()
	{
	}

	private void OnObserverChanged(object[] data)
	{
	}

	private void SetTreasury(Player player)
	{
	}

	public void OnUpdateTreasuryState(object[] data)
	{
	}

	public void OnTreasuryUpgraded(uint treasuryID)
	{
	}

	private void UpdateTreasuryState(LevelTreasury levelTreasury, EUIHudTreasuryMapState state)
	{
	}

	private void UpdateNamePosition(Transform trans, Vector3 position)
	{
	}

	private void OnPlayerCountChanged()
	{
	}

	private void UpdateFightingState()
	{
	}

	private void ClearFightingState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
