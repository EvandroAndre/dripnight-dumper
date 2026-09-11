using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelKolHud : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public UIModelKolHud _003C_003E4__this;

		public HudLikedInfo hudLikedInfo;

		public uint hud_index;

		public ulong account_id;

		internal void _003CRequestLikeHud_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public UIModelKolHud _003C_003E4__this;

		public string cmd;

		internal void _003CRequestKolHudList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public uint hotStd;

		public Dictionary<ulong, uint> sortIdMap;

		internal int _003CSortKolHudItemDataList_003Eb__0(KolHudItemData a, KolHudItemData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public UIModelKolHud _003C_003E4__this;

		public ulong[] kolIds;

		public uint[] kolHudIndexes;

		internal void _003CBatchRequestKolHudDetail_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public UIModelKolHud _003C_003E4__this;

		public ulong account_id;

		public uint hud_index;

		internal void _003CRequestKolHudDetail_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public UIModelKolHud _003C_003E4__this;

		public string cmd;

		internal void _003CRequestKolConfig_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public UIModelKolHud _003C_003E4__this;

		public string cmd;

		internal void _003CRequestKolUploadHudInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public UIModelKolHud _003C_003E4__this;

		public string cmd;

		internal void _003CRequestKolSelfHudDetail_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass75_0
	{
		public UIModelKolHud _003C_003E4__this;

		public string cmd;

		public int toggleIdx;

		internal void _003CRequestPublishHudUpload_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public UIModelKolHud _003C_003E4__this;

		public string cmd;

		public int toggleIdx;

		internal void _003CRequestDeleteHudUpload_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public uint SlcKolHudIndex;

	public ulong SlcKolHudAcoountId;

	public List<HudLikedInfo> HudLikedInfoList;

	private List<KolHudItemData> m_KolHudItemDataList;

	private KolHudItemData m_OfficialKolHudItemData;

	private KolHudDetail m_OfficialKolHudDetail;

	private List<KolHudDetail> m_KolHudDetailList;

	private List<KolHudRecommendDesc> m_KolConfigList;

	private KolHudRecommendLimitDesc m_KolConfigLimitDesc;

	public const uint PropID_KolHudItemDataListUpdate = 2u;

	public const uint PropID_KolHudDetailUpdate = 4u;

	public const uint PropID_KolConfigListUpdate = 8u;

	public const uint PropID_KolHudLikedUpdate = 16u;

	public const int PropID_PublishHudUploadOK = 32;

	public const int PropID_PublishHudUploadFail = 64;

	public const int PropID_KolSelfHudDetailUpdate = 128;

	public int HudUseSelectionIndex;

	public const string ShareCodeGuideKey = "KolHud_ShareCode_Guide";

	private List<HudTag> m_HudTagList;

	public Dictionary<int, string> HudTagDict;

	private List<HudUploadItem> m_HudUploadItems;

	private List<HudUploadItem> m_HudUploadItemsCache;

	private int m_HudUploadSelection;

	private bool m_HudTagDataLoaded;

	public const int GUIDE_CTRL_PANEL_DEPTH = 100;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private bool m_RequestedKolHudList;

	private bool m_HasLoadKolHudDetail;

	private List<HudLikedInfo> m_RequestingHudLikedInfoList;

	private List<HudLikedInfo> m_RunningHudDetailRequestList;

	public List<KolHudItemData> KolHudItemDataList => null;

	public List<KolHudRecommendDesc> KolConfigList => null;

	public KolHudRecommendLimitDesc KolConfigLimitDesc => null;

	public List<HudTag> HudTagList => null;

	public List<HudUploadItem> HudUploadItems => null;

	public List<HudUploadItem> HudUploadItemsCache => null;

	public int HudUploadSelection
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool HasLoadKolHudDetail => false;

	public bool RequestedKolHudList => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void LoadHudTagData()
	{
	}

	public bool HasHudLiked(uint hud_index, ulong account_id)
	{
		return false;
	}

	public void RequestLikeHud(uint hud_index, ulong account_id)
	{
	}

	public void RequestKolHudList()
	{
	}

	private void SortKolHudItemDataList()
	{
	}

	private void BatchRequestKolHudDetailInCache()
	{
	}

	public void TryRequestKolHudDetail(ulong account_id, uint hud_index)
	{
	}

	private void BatchRequestKolHudDetail()
	{
	}

	public void RequestKolHudDetail(ulong account_id, uint hud_index)
	{
	}

	public void RequestKolConfig()
	{
	}

	public KolHudDetail GetKolHudDetail(ulong account_id, uint hud_index)
	{
		return null;
	}

	public KolHudItemData GetKolHudItemData(ulong account_id, uint hud_index)
	{
		return null;
	}

	public List<KolHudItemData> GetTagKolHudItemDataList(uint tag_id)
	{
		return null;
	}

	public List<KolHudItemData> GetRandomKolHudItemDataList(int count = 3)
	{
		return null;
	}

	public List<KolHudItemData> GetSearchKolHudItemDataList(string searchText)
	{
		return null;
	}

	public void UseShareHudConfig(byte[] hud_settings, int presetIndex)
	{
	}

	public void UseShareHudSensitivity(float[] sensitivitySettings, bool isUseSensitivity)
	{
	}

	private void CreateHudUploadItemsSnapshot()
	{
	}

	public void RequestKolUploadHudInfo()
	{
	}

	public void RequestKolSelfHudDetail(List<ulong> account_ids, List<uint> hud_indexes)
	{
	}

	private HudUploadItem CreateHudUploadItemsSnapshot(HudUploadItem source)
	{
		return null;
	}

	public bool IsHudConfigsChanged(HudConfigs hudConfigs1, HudConfigs hudConfigs2)
	{
		return false;
	}

	public bool IsHudUploadItemsChanged(int toggleIdx, List<int> publishDisableReasonList)
	{
		return false;
	}

	public bool IsHudUploadItemsFull(int toggleIdx, List<int> publishDisableReasonList)
	{
		return false;
	}

	public void RequestPublishHudUpload(int toggleIdx)
	{
	}

	public void RequestDeleteHudUpload(int toggleIdx)
	{
	}

	public string GetHudUploadTagsDataByID(uint tagId)
	{
		return null;
	}

	public void RollBackHudUploadItems()
	{
	}

	public bool IsHudUploadSeletionDefault()
	{
		return false;
	}

	public HudConfigs GetHudConfigsByHudIdx(int hudIdx)
	{
		return null;
	}

	public HudConfigItem GetHudUploadConfigByNameAndIndex(string hudName, int index)
	{
		return null;
	}

	public bool IsUserKol()
	{
		return false;
	}

	public int GetHudUploadGrenadeDir(int toggleIdx)
	{
		return 0;
	}

	public string GetHudLikeNumTxt(long likeNum)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
