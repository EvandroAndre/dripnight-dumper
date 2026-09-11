using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIBaseGroupMemberInfoController : UIBaseController
{
	public delegate void InviteClickCallBack(int member_idx, ulong account_id, string lock_region);

	protected static readonly float[] m_FakeMemberScale;

	protected static readonly float[] m_PentaFakeMemberScale;

	protected GroupMemberInfo m_MemInfo;

	protected UINewDownloadInfoController m_DownloadCtrl;

	protected GameObject TakePhotoMain;

	protected bool m_IsMute;

	protected bool m_IsReserveCtrl;

	protected bool m_IsRematchCtrl;

	public UINewDownloadInfoController DownloadCtrl => null;

	public bool IsReserveCtrl
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsRematchCtrl
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsMute
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool InVoiceRoom()
	{
		return false;
	}

	public virtual GroupMemberInfo GetMemberInfo()
	{
		return null;
	}

	public virtual void SetCallSignData(GroupMemberInfo memInfo)
	{
	}

	public virtual void RefreshTransferNodeView()
	{
	}

	public virtual void SetUIData(GroupMemberInfo memInfo, bool leader, int idx = 0)
	{
	}

	public virtual void SetReserveUIData(GroupReservationShowInfo info, int idx = 0)
	{
	}

	public virtual void SetRematchUIData(RematchPlayer player, int idx = 0)
	{
	}

	public virtual void SetMute(bool isMute)
	{
	}

	public virtual void RefreshProfile()
	{
	}

	public virtual void SetRelationshipState()
	{
	}

	public virtual void SetFastMessageIconActive(bool isActive)
	{
	}

	public virtual void SetReadyState(bool ready, bool leader, bool isMixedGroupMemberInGameOrResult)
	{
	}

	public virtual void SetFriendState(bool friend, InviteClickCallBack cb = null)
	{
	}

	public virtual void SetOptionalMapResState(EGroup.PlayerPatchOptionalResStatus status)
	{
	}

	public virtual void EnableInivte(bool v)
	{
	}

	public virtual bool NeedScroll()
	{
		return false;
	}

	public virtual uint GetScrollCount()
	{
		return 0u;
	}

	public virtual void StreakScroll(uint streakScrollIndex)
	{
	}

	public virtual void ResetScroll()
	{
	}

	public virtual void ResetMute()
	{
	}

	public virtual void SetChatBubbleWorldPosition(Vector3 position)
	{
	}

	public virtual void SetLaunchTagPosAndScale(Vector3 pos, float scale)
	{
	}

	public virtual void HideLaunchTag()
	{
	}

	public virtual void DownLoadOneTeamateEquipment()
	{
	}

	public virtual float GetNeedDownloadSize()
	{
		return 0f;
	}

	public void ShowTakePhotoMain(bool isShow)
	{
	}
}
