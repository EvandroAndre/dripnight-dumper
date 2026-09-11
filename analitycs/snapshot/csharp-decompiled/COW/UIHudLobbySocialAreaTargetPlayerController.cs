using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudLobbySocialAreaTargetPlayerController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ResourceID> _003C_003E9__32_0;

		internal int _003CTryBuildDownloadResList_003Eb__32_0(ResourceID a, ResourceID b)
		{
			return 0;
		}
	}

	private UIHudLobbySocialAreaTargetPlayerView m_View;

	private UIHudLobbySocialAreaTargetPlayerInfoController m_TargetPlayerInfoCtrl;

	private Player m_BindPlayer;

	private bool m_IsFriend;

	private bool m_HasRequestedAddFriend;

	private bool m_HasInvitedToTeam;

	private UINewDownloadInfoController m_DownloadCtrl;

	private List<ResourceID> m_needDownLoadTeammateResList;

	private List<ResourceID> m_workingResList;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIModelGroup m_ModelGroup;

	private EventLogger.ESocialHubPersonalInfoTriggerSource m_Source;

	private ulong m_LastAddFriendTriggerAccountId;

	private ulong m_LastGroupInviteTriggerAccountId;

	private uint m_LastBindPlayerId;

	private EventLogger.ESocialHubPersonalInfoTriggerSource m_LastBindSource;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitUI()
	{
	}

	public void BindPlayer(uint playerID, EventLogger.ESocialHubPersonalInfoTriggerSource source)
	{
	}

	public void UnbindPlayer()
	{
	}

	private void RefreshPriorityUI()
	{
	}

	private bool CanShowTeamBtn()
	{
		return false;
	}

	private bool IsLobbySocialAreaRoomMode()
	{
		return false;
	}

	private void OnPlayerAddBtnClick()
	{
	}

	private void OnTeamBtnClick()
	{
	}

	private bool TryCreateGroupAndInvite()
	{
		return false;
	}

	private bool TryUpgradeGroupAndInvite()
	{
		return false;
	}

	private void SendGroupInvite()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnGroupInviteSent(object[] param)
	{
	}

	private bool TryBuildDownloadResList()
	{
		return false;
	}

	private void ApplyDownloadContent()
	{
	}

	private void EnsureDownloadCtrl()
	{
	}

	private static List<uint> GetItemIdsNeedDownLoadFromTeammate(BaseProfileInfo profile)
	{
		return null;
	}

	public float GetNeedDownloadSize()
	{
		return 0f;
	}

	public void DownLoadOneTeamateEquipment()
	{
	}

	private void DownLoadOneTeamateEquipmentClick()
	{
	}

	private void DownLoadAllTeamateEquipmentClick()
	{
	}

	private void OnClickDownloadBtn()
	{
	}

	private static bool IsSameResList(List<ResourceID> a, List<ResourceID> b)
	{
		return false;
	}

	private void RefreshCameraModeVisibility()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
