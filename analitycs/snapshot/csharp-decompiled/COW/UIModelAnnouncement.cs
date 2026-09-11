using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelAnnouncement : UIBaseModel
{
	public enum DataState
	{
		None,
		Fetching,
		Fetched
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<AnnoucementInfo> _003C_003E9__18_1;

		public static Predicate<AnnoucementInfo> _003C_003E9__26_0;

		internal int _003CRequestAnnouncementSplashActivityData_003Eb__18_1(AnnoucementInfo a, AnnoucementInfo b)
		{
			return 0;
		}

		internal bool _003CUpdateSurveyAnnouncementData_003Eb__26_0(AnnoucementInfo data)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public UIModelAnnouncement _003C_003E4__this;

		public HttpManager.EHttpChannel channel;

		internal void _003CRequestAnnouncementSplashActivityData_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_AnnounceRetOK = 2u;

	public const uint PropID_AnnounceRetFailed = 4u;

	private const string ANNOUNCEMENT_READED_FORMAT = "Announcement{0}";

	public bool IsAnnouncementShowed;

	private DataState _003CCurrentDataState_003Ek__BackingField;

	private List<AnnoucementInfo> m_AnnouncementDataList;

	private UIModelLobbyAds.AdInfo m_SurveyAnnouncementData;

	public DataState CurrentDataState
	{
		get
		{
			return _003CCurrentDataState_003Ek__BackingField;
		}
		set
		{
			_003CCurrentDataState_003Ek__BackingField = value;
		}
	}

	public List<AnnoucementInfo> AnnouncementDataList => null;

	public UIModelLobbyAds.AdInfo SurveyAnnouncementData => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public override void Login(object[] data)
	{
	}

	public HttpRequest RequestAnnouncementSplashActivityData(float timeout = 0f, bool forceUpdate = false, LoadingType loadingType = LoadingType.CircleLoading, bool isLogin = false, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
		return null;
	}

	public static EAnnouncement.Os AnnouncementOs()
	{
		return EAnnouncement.Os.Os_DEFAULT;
	}

	public static EAnnouncement.AndroidChannel AnnouncementAndroidChannel()
	{
		return EAnnouncement.AndroidChannel.AndroidChannel_DEFAULT;
	}

	private void UpdateTipsNum()
	{
	}

	public bool IsUnreadAnnouncement(uint id)
	{
		return false;
	}

	public void SetReadAnnouncement(uint id)
	{
	}

	public bool CheckCanShowByQuality(EAnnouncement.PhoneQuality quality)
	{
		return false;
	}

	public bool CheckCanShowByAccountID(string lastNums)
	{
		return false;
	}

	public void UpdateSurveyAnnouncementData()
	{
	}

	private int SortSurveyAnnouncementData(AnnoucementInfo a, AnnoucementInfo b)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}
}
