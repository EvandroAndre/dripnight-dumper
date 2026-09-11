using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelLobbyAds : UIBaseModel
{
	public class AdInfo : IComparable<AdInfo>
	{
		public string url;

		public uint goPos;

		public string goSubPos;

		public uint sortId;

		public uint optGroupId;

		public uint optActivityId;

		public uint optAnnouncementId;

		public uint optCountdownStyle;

		public ulong optStartTime;

		public ulong optEndTime;

		public string lastNum;

		public object source;

		public uint ID => 0u;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public int CompareTo(AdInfo other)
		{
			return 0;
		}

		public AdInfo(AnnoucementInfo info, bool IsNewAnnouncement = false)
		{
		}

		public AdInfo(ActivityGroupDesc group)
		{
		}

		public AdInfo(AdvertDesc advert)
		{
		}

		public AdInfo(string cdnUrl, uint inGoPos, string inGoPosParam, uint inSortId)
		{
		}

		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return false;
		}

		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return 0;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<AdInfo> _003C_003E9__12_0;

		public static Comparison<AdvertDesc> _003C_003E9__17_0;

		public static Comparison<AdvertDesc> _003C_003E9__18_0;

		internal int _003Cget_AdList_003Eb__12_0(AdInfo x, AdInfo y)
		{
			return 0;
		}

		internal int _003CGetLobbyExtraAdRes_003Eb__17_0(AdvertDesc a, AdvertDesc b)
		{
			return 0;
		}

		internal int _003CGetLobbyShoppingMallBannerAdRes_003Eb__18_0(AdvertDesc a, AdvertDesc b)
		{
			return 0;
		}
	}

	private List<AdInfo> m_AnnouncementAdList;

	private List<AdInfo> m_EventAdList;

	private List<AdInfo> m_CDNAdList;

	private List<AdInfo> m_AllAdList;

	private List<OptCdnDesc> m_HideoutAdList;

	public bool AlreadyRequestHideOutData;

	public const int PropID_UpdateLobbyAds = 2;

	public const int PropID_UpdateHideoutAds = 4;

	private const string LOBBYEXTRAADS_ID_NEW = "LobbyExtraAds{0}";

	private const string LOBBYEXTRAADS_CLICKED = "LobbyExtraAdsClicked{0}";

	private const string LOBBYEXTRAADS_ACCOUNT_CLICKED = "LobbyExtraAdsClicked{0}{1}";

	public List<AdInfo> AdList => null;

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	private void UpdateAnnouncementAdList(object[] data)
	{
	}

	public void UpdateAnnouncementAdList()
	{
	}

	public void UpdateEventAdList()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public List<AdvertDesc> GetLobbyExtraAdRes()
	{
		return null;
	}

	public List<AdvertDesc> GetLobbyShoppingMallBannerAdRes()
	{
		return null;
	}

	public OptCdnDesc GetLobbyHideoutAd()
	{
		return null;
	}

	public bool IsLobbyExtraAdsNewID(uint cdnID)
	{
		return false;
	}

	public bool IsExtraAdTimeOut(uint cdnID)
	{
		return false;
	}

	public void SetExtraAdPrefNewID(uint cdnID, ulong value = 0uL)
	{
	}

	public ulong GetExtraAdPrefValue(uint cdnID)
	{
		return 0uL;
	}

	public override void Logout(object[] data)
	{
	}

	public void RequestHideoutData(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void _003CRequestHideoutData_003Eb__28_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
