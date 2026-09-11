using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelPreVeteran : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__25_1;

		internal CommonRewardItemInfo _003CRequestClaimTaskRewards_003Eb__25_1(BaseItemInfo item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public uint taskId;

		internal bool _003CGetTaskInfo_003Eb__0(VeteranTaskInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public UIModelPreVeteran _003C_003E4__this;

		public HttpManager.Priority priority;

		internal void _003CRequestTaskDesc_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public UIModelPreVeteran _003C_003E4__this;

		public uint taskId;

		internal void _003CRequestClaimTaskRewards_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public VeteranTaskUpdateInfo newTaskInfo;

		internal bool _003COnTcpUpdateTaskInfos_003Eb__0(ClientVeteranTaskDesc desc)
		{
			return false;
		}

		internal bool _003COnTcpUpdateTaskInfos_003Eb__1(VeteranTaskInfo x)
		{
			return false;
		}
	}

	public const uint PropID_ClaimTaskRewards = 2u;

	public const uint PropID_PreVeteranInfoUpdate = 4u;

	private bool m_IsPreVeteran;

	private uint m_PreVeteranTaskId;

	private EAttendance.PreVeteranActionType m_PreVeteranType;

	private CSGetPreVeteranTaskDescRes m_TaskDesc;

	private List<VeteranTaskInfo> m_TaskInfosList;

	private ulong m_PreVeteranStartTime;

	private ulong m_PreVeteranEndTime;

	public override void Logout(object[] data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void SetPreVeteran()
	{
	}

	public bool IsPreVeteran()
	{
		return false;
	}

	public void ProcessPreVeteranInfo(CSGetVeteranRewardListRes res)
	{
	}

	public List<ClientVeteranTaskDesc> GetTaskDescList()
	{
		return null;
	}

	public string GetTaskTimeStr()
	{
		return null;
	}

	public ulong GetPreVeteranEndTime()
	{
		return 0uL;
	}

	public uint GetTaskState(uint taskid)
	{
		return 0u;
	}

	public VeteranTaskInfo GetTaskInfo(uint taskId)
	{
		return null;
	}

	public ClientVeteranTaskDesc GetCurTaskDesc()
	{
		return null;
	}

	public bool IsAbleToClaimeReward()
	{
		return false;
	}

	public bool IsAllTaskDone()
	{
		return false;
	}

	public EAttendance.PreVeteranActionType GetAttendanceType()
	{
		return EAttendance.PreVeteranActionType.PreVeteranActionType_NONE;
	}

	public void RequestTaskDesc(HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void RequestTaskInfo(HttpManager.Priority priority)
	{
	}

	public void RequestClaimTaskRewards(uint taskId)
	{
	}

	private void RefreshTipsNum()
	{
	}

	public void OnTcpUpdateTaskInfos(List<VeteranTaskUpdateInfo> taskInfoList)
	{
	}

	private bool _003CGetCurTaskDesc_003Eb__19_0(ClientVeteranTaskDesc desc)
	{
		return false;
	}

	private void _003CRequestTaskInfo_003Eb__24_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
