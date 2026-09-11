using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIMatchResultZombieScreenshotController : UIBaseController
{
	public class MatchResultScreenshotData
	{
		public class TeammateData
		{
			public string Nickname;

			public uint Kills;

			public uint Damages;

			public uint Weapon_id;

			public ulong account_id;
		}

		public uint All_Damages;

		public string Defeater;

		public string WeaponDefeatedWith;

		public bool DefeaterIsZombie;

		public ulong mvp_id;

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

		public static Converter<TeammateStats, MatchResultScreenshotData.TeammateData> _003C_003E9__9_0;

		internal MatchResultScreenshotData.TeammateData _003CMakeScreenshot_003Eb__9_0(TeammateStats datum)
		{
			return null;
		}
	}

	private UIMatchResultZombieScreenshotView m_View;

	private MatchResultScreenshotData m_Data;

	private RenderTexture m_BackgroundRenderTexture;

	private RenderTexture m_ScreenShotRenderTexture;

	private int m_ScreenShotStepCount;

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

	private void UpdateHighlightRank()
	{
	}

	private void UpdateDetailData()
	{
	}

	private void UpdatePlayerCharacterImage()
	{
	}

	private void UpdateGameInfo()
	{
	}

	private void StartRenderBackground()
	{
	}

	private void LateUpdate()
	{
	}

	private void FinishRenderBackground()
	{
	}

	private void TakeScreenshot()
	{
	}

	private void _003CTakeScreenshot_003Eb__21_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
