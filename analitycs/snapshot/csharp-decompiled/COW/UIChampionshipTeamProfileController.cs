using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIChampionshipTeamProfileController : UIBaseController
{
	public enum ContentType
	{
		Memebers,
		Record
	}

	public class InfoEasyListFactory : IEasyList
	{
		private UIChampionshipTeamProfileController teamProfile;

		public bool ShowPresence;

		public bool ShowPopupMenu;

		public InfoEasyListFactory(UIChampionshipTeamProfileController teamProfile)
		{
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	public class RecordEasyListFactory : IEasyList
	{
		private UIChampionshipTeamProfileController teamProfile;

		public RecordEasyListFactory(UIChampionshipTeamProfileController teamProfile)
		{
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<TeamChampionshipMatchData> _003C_003E9__18_0;

		internal int _003CUpdateRecordView_003Eb__18_0(TeamChampionshipMatchData a, TeamChampionshipMatchData b)
		{
			return 0;
		}
	}

	private UIChampionshipTeamProfileView m_View;

	protected InfoEasyListFactory m_InfoEasyListFactory;

	protected RecordEasyListFactory m_RecordEasyListFactory;

	protected Dictionary<int, GameObject> m_ContentUIs;

	protected UIChampionshipTeamOverviewController m_TeamOverviewUI;

	public List<TeamChampionshipMatchData> m_MatchData;

	protected uint m_ChampionshipType;

	private Vector3 m_RecruitInitPos;

	public static ResourceID UIResource()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected object GetView()
	{
		return null;
	}

	public T OpenChild<T>(Transform parent) where T : UIBaseController
	{
		return null;
	}

	public void UpdateTeamMemberView(TeamInfo teamInfo, List<TeamMemberWithAccountInfo> members, bool sortPresence = false)
	{
	}

	protected Bounds CalcPriceContainerBounds(Transform priceContainer)
	{
		return default(Bounds);
	}

	public void UpdateRecruitPosition(List<TeamMemberWithAccountInfo> list)
	{
	}

	public void UpdateRecordView(ulong teamID, List<TeamChampionshipMatchStats> matchStats)
	{
	}

	protected void UpdateContentUI(ContentType contentType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
