using System;
using System.Collections.Generic;
using GCommon;
using message;
using proto;
using tcp;

namespace COW;

public class CreditPunishManager : SingletonModule<CreditPunishManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CreditPunishDesc> _003C_003E9__17_0;

		public static Action _003C_003E9__23_0;

		public static Predicate<CreditPunishDesc> _003C_003E9__25_0;

		public static Comparison<tcp.CreditPunishInfo> _003C_003E9__44_0;

		internal int _003CInitCreditPunishDesc_003Eb__17_0(CreditPunishDesc l, CreditPunishDesc r)
		{
			return 0;
		}

		internal void _003CShowPunishWindow_003Eb__23_0()
		{
		}

		internal bool _003CShowBanRoomWindow_003Eb__25_0(CreditPunishDesc value)
		{
			return false;
		}

		internal int _003CCheckSelectedModeTeamMemberCreditForbidGamePunish_003Eb__44_0(tcp.CreditPunishInfo l, tcp.CreditPunishInfo r)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public UINavigationUtil.UINavigationFrom navigationFrom;

		internal void _003CShowBanCupAndChampionshipWindow_003Eb__0()
		{
		}
	}

	private List<ForbidMode> m_ListForbidMode;

	private List<CreditPunishDesc> m_CreditPunishDesc;

	private uint m_CurCreditScore;

	private uint m_PunishScoreBase;

	private bool m_IsBanRoom;

	private bool m_IsBanCupMatch;

	private bool m_IsBanChampionship;

	private UISecondConfirmSmallContoller m_PunishWindowCacheSelf;

	private UISecondConfirmSmallContoller m_PunishWindowCacheOther;

	private bool m_PendingShowReturnPunishSolo;

	private bool m_PendingShowReturnPunishGroup;

	public void MarkPendingShowReturnPunish()
	{
	}

	public bool ConsumePendingShowReturnPunishSolo()
	{
		return false;
	}

	public bool ConsumePendingShowReturnPunishGroup()
	{
		return false;
	}

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public void LoginInit()
	{
	}

	private void InitCreditPunishDesc()
	{
	}

	private void InitCurCreditScore()
	{
	}

	private void InitCurCreditScorePunish()
	{
	}

	private bool UpdateCurPunishMent(uint creditScore, int credit_score_delta = 0, bool is_init = false)
	{
		return false;
	}

	public bool UpdateCurScoreAndPunishMent(uint creditScore, int credit_score_delta)
	{
		return false;
	}

	private string GetGroupModeNameByGroupMode(uint groupMode)
	{
		return null;
	}

	private void ShowPunishWindow(string gameModeName, List<string> groupMemeberNames = null, uint punishBaseScore = 0u, string groupModeName = "")
	{
	}

	public void ShowDefaultPunishWindow()
	{
	}

	public void ShowBanRoomWindow(List<string> groupMemeberNames = null)
	{
	}

	public void ShowBanCupAndChampionshipWindow(UINavigationUtil.UINavigationFrom navigationFrom, bool isSelf = true)
	{
	}

	public void ShowMatchMakingIsLowCredit()
	{
	}

	public void CheckForbidGamePunishChanged(out object[] param)
	{
		param = null;
	}

	public bool IsMemeberCreditForbidGamePunish(List<tcp.CreditPunishInfo> punishInfo)
	{
		return false;
	}

	private bool IsSelectedModeCreditForbidGamePunish(ForbidMode selectMode)
	{
		return false;
	}

	private uint CheckSelectedModeCreditForbidGamePunishScore(uint matchMode, uint groupModel, uint gameMode)
	{
		return 0u;
	}

	public bool CheckSelectedModeCreditForbidGamePunish(List<MapModeData> selectMapModes, uint groupMode = 0u)
	{
		return false;
	}

	public bool CheckSelectedModeCreditForbidGamePunish(MapModeData selectMapMode, uint groupMode = 0u, bool needShowPunishWindow = true)
	{
		return false;
	}

	public bool CheckCreditBanRoom()
	{
		return false;
	}

	public bool CheckCreditBanCupMatch()
	{
		return false;
	}

	public bool CheckCreditBanChampionship()
	{
		return false;
	}

	public bool CheckRecruitModeCreditForbidGamePunish(ForbidMode selectMode, GroupInfo groupInfo)
	{
		return false;
	}

	public bool CheckRoomRecruitModeCreditForbidGamePunish(ForbidMode selectMode)
	{
		return false;
	}

	private bool CheckSelectedModeCreditForbidGamePunish(ForbidMode selectMode)
	{
		return false;
	}

	public bool CheckSelectedModeCreditForbidGamePunish(GroupInfo groupInfo)
	{
		return false;
	}

	public bool CheckSelectedModeGroupCreditForbidGamePunish(GroupInfo groupInfo, MapModeData selectMapMode)
	{
		return false;
	}

	public bool CheckSelectedTeamModeCreditForbidGamePunish(MapModeData selectedMapData, CMDBIPLGLGA groupMode, GroupInfo groupInfo, bool needShowPunishWindow = true)
	{
		return false;
	}

	private List<string> GetSelectedModeCreditPunishTeamMembers(GroupInfo groupInfo, ForbidMode selectMode, out uint punishBaseScore)
	{
		punishBaseScore = default(uint);
		return null;
	}

	private bool CheckSelectedModeTeamMemberCreditForbidGamePunish(List<tcp.CreditPunishInfo> creditPunishInfo, ForbidMode selectMode, out uint punish_score)
	{
		punish_score = default(uint);
		return false;
	}
}
