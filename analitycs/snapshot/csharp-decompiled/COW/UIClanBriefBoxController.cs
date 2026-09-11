using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIClanBriefBoxController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public UISecondConfirmContoller confirmWnd;

		public UIClanBriefBoxController _003C_003E4__this;

		internal void _003COnJoinButtonClick_003Eb__0()
		{
		}
	}

	private UIClanBriefBoxView m_View;

	private UIClanBriefBoxFriendItemController m_LeaderItem;

	private UIModelClan m_ModelClan;

	private ClanInfo m_Data;

	private UILeaderBoardTitleIconController m_TitleIconCtrl;

	private UIClanBriefBoxParentController.EClanBriefBoxType m_Type;

	private UIClanBriefBoxParentController.EClanBriefBoxParentType m_ParentType;

	private ulong m_AccountId;

	private List<UIClanBriefBoxFriendItemController> m_FriendItemCtrl;

	private readonly Vector3 m_TitleIconScale;

	private List<UIClanTagItemController> m_TagsCtrl;

	private int m_GloryCount;

	private bool m_IsInGame;

	public UIClanBriefBoxParentController.EClanBriefBoxType Type => UIClanBriefBoxParentController.EClanBriefBoxType.ClanInfo;

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

	public void SetViewData(ClanInfo info, UIClanBriefBoxParentController.EClanBriefBoxType type, ulong accountId = 0uL, UIClanBriefBoxParentController.EClanBriefBoxParentType parentType = UIClanBriefBoxParentController.EClanBriefBoxParentType.None)
	{
	}

	private void InitEvent()
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshProfileInfo()
	{
	}

	private void UpdateClanIcon()
	{
	}

	private void RefreshClanTitle()
	{
	}

	public Vector3 GetContainerPos()
	{
		return default(Vector3);
	}

	public float GetBGBorderHeight()
	{
		return 0f;
	}

	public Vector3 GetBriefBoxPopupPos()
	{
		return default(Vector3);
	}

	private void RefreshLeaderInfo()
	{
	}

	private void RefreshGlory()
	{
	}

	private void OnRequestAccountInfoFinish(object[] data)
	{
	}

	private void RefreshFriendsInfo()
	{
	}

	private void RefreshSloganInfo()
	{
	}

	private void RefreshTagsInfo()
	{
	}

	private void RefreshApplyLimit()
	{
	}

	private void UpdateRank(int rank)
	{
	}

	private void UpdateCSRank(int rank)
	{
	}

	private void RefreshJoinButtonState()
	{
	}

	public void OnJoinButtonClick()
	{
	}

	private void RequestJoinClan()
	{
	}

	public void OnGotoClanButtonClick()
	{
	}

	private void OnNoJoinBtnButtonClick()
	{
	}

	private void OnClickClanWarHistoryBtn()
	{
	}

	private void OnClickReportBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
