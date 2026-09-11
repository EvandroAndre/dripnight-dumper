using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIReplayItemController : UIEasyListItemController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<TeammateStats> _003C_003E9__15_0;

		public static Comparison<TeammateStats> _003C_003E9__15_1;

		public static Comparison<TeammateStats> _003C_003E9__15_2;

		public static Comparison<MacthAchievementItem.ReplayFeedbackItemData> _003C_003E9__24_0;

		internal int _003CGetMvpPlayerAccount_003Eb__15_0(TeammateStats player1, TeammateStats player2)
		{
			return 0;
		}

		internal int _003CGetMvpPlayerAccount_003Eb__15_1(TeammateStats player1, TeammateStats player2)
		{
			return 0;
		}

		internal int _003CGetMvpPlayerAccount_003Eb__15_2(TeammateStats player1, TeammateStats player2)
		{
			return 0;
		}

		internal int _003CRefershMatchAchievementIcon_003Eb__24_0(MacthAchievementItem.ReplayFeedbackItemData a, MacthAchievementItem.ReplayFeedbackItemData b)
		{
			return 0;
		}
	}

	private UIReplayListItemView m_View;

	private MobileReplayInfo m_RecordData;

	private UIModelReplay m_Model;

	private const string COLOR_YELLOW = "ffba00";

	private const string COLOR_WHITE = "ffffff";

	private const string COLOR_GRAY = "bababa";

	private const int YELLOW_RANK = 3;

	private const string POSITIVE_DELTA_COLOR = "4cd5ad";

	private const string NEGATIVE_DELTA_COLOR = "ff0032";

	private List<MacthAchievementItem> mlistMacthAchievementItems;

	private bool m_IsShowDebugToggle;

	private bool m_IsDebugSelected;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void UpdateResultColumn()
	{
	}

	private void ShowMvp()
	{
	}

	private ulong GetMvpPlayerAccount(List<TeammateStats> players, uint mode)
	{
		return 0uL;
	}

	private void UpdateModeColumn()
	{
	}

	private void UpdateKillsColumn()
	{
	}

	private void UpdateTimeColumn()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnPlayClick()
	{
	}

	private void OnDelClick()
	{
	}

	private void OnSaveClick()
	{
	}

	public override void OnItemBtnClick()
	{
	}

	protected void RefershMatchAchievementIcon()
	{
	}

	private void OnDebugUploadToggle()
	{
	}

	private void InitDebugUploadState(int index)
	{
	}

	public void RefreshDebugUploadState()
	{
	}

	private void RefreshDebugUploadView()
	{
	}

	private bool _003CShowMvp_003Eb__14_0(MatchRecordPersonal v)
	{
		return false;
	}

	private void _003COnDelClick_003Eb__21_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
