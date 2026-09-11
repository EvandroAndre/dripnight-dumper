using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UMA;
using UnityEngine;
using proto;

namespace COW;

internal class UIMatchResultScreenshotController : UIBaseController
{
	public class MatchResultScreenshotData
	{
		public class TeammateData
		{
			public string Nickname;

			public uint Kills;
		}

		public string Defeater;

		public string WeaponDefeatedWith;

		public bool DefeaterIsZombie;

		public bool IsShowCsRanking;

		public uint CsRank;

		public uint CsRankPoint;

		public uint Kills;

		public uint Damages;

		public uint SurvivedTime_s;

		public uint Rank;

		public uint TotalPlayersCount;

		public TeammateData[] Teammates;

		public uint MatchMode;

		public uint GameMode;

		public uint MapID;

		public MatchStats MatchStats;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<TeammateStats, MatchResultScreenshotData.TeammateData> _003C_003E9__14_0;

		public static Func<MatchResultScreenshotData.TeammateData, bool> _003C_003E9__14_1;

		internal MatchResultScreenshotData.TeammateData _003CMakeScreenshot_003Eb__14_0(TeammateStats datum)
		{
			return null;
		}

		internal bool _003CMakeScreenshot_003Eb__14_1(MatchResultScreenshotData.TeammateData val)
		{
			return false;
		}
	}

	private UIMatchResultScreenshotView m_View;

	private MatchResultScreenshotData m_Data;

	private RenderTexture m_PlayerAvatarRenderTexture;

	private RenderTexture m_ScreenShotRenderTexture;

	private AvatarManager m_AvatarManager;

	private List<GameObject> m_ViewTeammates;

	private List<UILabel> m_ViewTeammateNames;

	private List<UILabel> m_ViewTeammateKills;

	private UIMatchResultShare3D m_Share3D;

	private bool m_originalShadowEnabled;

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

	public void MakeScreenshot(MatchResultScreenshotData data)
	{
	}

	private string MakeEndgameDescription(uint rank)
	{
		return null;
	}

	private void UpdatePlayerData()
	{
	}

	private void UpdateHeadshot()
	{
	}

	private void UpdateHeadshot(uint iid, ulong accountId, string externalIcon, EAccount.ExternalIconStatus externalIconStatus, EAccount.ExternalIconShowType externalIconShowType)
	{
	}

	private void UpdateHeadshot(HeadPicData data)
	{
	}

	private void UpdateCsSeasonRank()
	{
	}

	private void UpdateRankInfo(int rank)
	{
	}

	private void UpdateSeasonRank()
	{
	}

	private void UpdateHighlightRank()
	{
	}

	private void UpdateDetailData()
	{
	}

	private void UpdateGameInfo()
	{
	}

	private void StartRenderPlayerAvatar()
	{
	}

	private void RerenderAfterUMAChanged(UMAData data)
	{
	}

	private void TakeScreenshot()
	{
	}

	private void _003CTakeScreenshot_003Eb__28_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
