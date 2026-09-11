using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UINinthSYSPrivilegeRewardWndController : UIPopupWindowController
{
	private struct ClaimedPrivilegeInfo
	{
		public uint id;

		public uint award_id;

		public NinthSysAwardDesc.ELevel level;

		public uint amount;

		public uint expire_time;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ClaimedPrivilegeInfo> _003C_003E9__21_0;

		internal int _003CSortClaimedPrivilegeInfoList_003Eb__21_0(ClaimedPrivilegeInfo x, ClaimedPrivilegeInfo y)
		{
			return 0;
		}
	}

	private UINinthSYSPrivilegeRewardWndView m_View;

	private UIModelNinthSYS m_ModelNinthSYS;

	private List<ClaimedPrivilegeInfo> m_ClaimedPrivilegeInfoList;

	private int m_Index;

	private Action m_OnPrivilegeAnimationCompleteCallback;

	private readonly List<UINinthSYSPrivilegePlayer> m_PrivilegePlayers;

	private List<UINinthSYSPrivilegeRewardItemController> m_SlotItemControllers;

	private const int MAX_PLAY_COUNT = 10;

	private const int MAX_BATCH_COUNT = 5;

	private uint m_FullScreenDelayCall;

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

	private void OnAnimEvtOccur(object[] param)
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void OnClickSkipBtn()
	{
	}

	public void SetCacheConsumeTokenRes(CSConsumeNinthSysTokenRes res, Action onComplete)
	{
	}

	private void PlayFullScreenAnimation()
	{
	}

	private void OnPrivilegeAnimationCompleteCallback()
	{
	}

	private void AddClaimedPrivilegeInfoList(uint id)
	{
	}

	private void SortClaimedPrivilegeInfoList()
	{
	}

	private void OnFullScreenAnimationComplete()
	{
	}

	private void PlayNextBatch()
	{
	}

	private UINinthSYSPrivilegePlayer GetPlayerByBatchCount(int batchCount)
	{
		return null;
	}

	private int GetPlayableCount()
	{
		return 0;
	}

	private void StopAllAnimations()
	{
	}

	private void ClearSlotItemControllers()
	{
	}

	private void StopAllPlayers()
	{
	}

	private void FinishAndClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
