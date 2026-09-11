using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelAnnoucementReward : UIBaseModel
{
	public class NotifyArgs
	{
		public bool success;

		public uint signId;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<AttendanceItem> _003C_003E9__42_0;

		public static Predicate<AttendanceItem> _003C_003E9__43_0;

		internal int _003CProcessTurntableRes_003Eb__42_0(AttendanceItem x, AttendanceItem y)
		{
			return 0;
		}

		internal bool _003CRefreshTurntableSigninTips_003Eb__43_0(AttendanceItem e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public HttpManager.EHttpChannel channel;

		internal void _003CRequestGetVeteranRewardList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass45_0
	{
		public int AttendaceInfoIndex;

		public UIModelAnnoucementReward _003C_003E4__this;

		internal void _003CAttendanceSignin_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_AttendanceLisUpdate = 8u;

	public const uint PropID_GetReward = 16u;

	public const uint PropID_TurntableAttendanceListUpdate = 32u;

	public const uint PropID_TurntableSigned = 64u;

	private List<AttendaceItemInfo> m_AttendaceInfoList;

	public bool HaveGetAttendance;

	private DateTime m_AttendanceEndTime;

	private AwardItemInfo m_CurrentAwardInfo;

	private DateTimeOffset m_BeijingLastSignedTime;

	private int m_LastSignedIndex;

	private string m_SignPictureUrl;

	private string m_SignDesc;

	private bool m_WaitingForReponse;

	private bool m_IsSignedToday;

	private uint m_ConfigId;

	private AttendanceList m_TurntableAttendanceRes;

	private DateTime m_LastRefreshTurntableDateTime;

	private bool waitTurntableResponse;

	public List<AttendaceItemInfo> AttendaceInfoList => null;

	public DateTime AttendanceEndTime => default(DateTime);

	public AwardItemInfo CurrentAwardInfo => null;

	public DateTimeOffset LastSingedTime => default(DateTimeOffset);

	public int LastSignedIndex => 0;

	public string SignPictureUrl => null;

	public string SignDesc => null;

	public AttendanceList TurntableAttendanceRes => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public bool IsSignedToday()
	{
		return false;
	}

	public bool CheckIsNeedAutoSign()
	{
		return false;
	}

	public bool CheckNeedRefreshTurntableSign()
	{
		return false;
	}

	public override void Logout(object[] data)
	{
	}

	public void RequestAttendanceRes(uint httpOp = 0u, bool force = false, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestGetVeteranRewardList(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public HttpRequest RequestTurntableAttendance()
	{
		return null;
	}

	public void ProcessTurntableRes(AttendanceList rewards)
	{
	}

	public void RefreshTurntableSigninTips()
	{
	}

	public void ProcessAttendanceRes(AttendanceList res)
	{
	}

	public void AttendanceSignin(AwardItemInfo itemInfo, int AttendaceInfoIndex)
	{
	}

	public override void Login(object[] data)
	{
	}

	private void _003CRequestAttendanceRes_003Eb__38_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestTurntableAttendance_003Eb__41_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}
}
