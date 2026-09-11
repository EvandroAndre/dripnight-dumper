using System;
using System.Collections;
using System.Collections.Generic;
using COW.OpSysExt;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIModelTakePhoto : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<GroupPhotoTemplateData> _003C_003E9__38_0;

		public static Comparison<PhotoFrameWithResConfig> _003C_003E9__44_0;

		public static Comparison<StickerWithResConfig> _003C_003E9__47_0;

		public static Comparison<AlbumPhotoInfo> _003C_003E9__70_0;

		public static Comparison<AlbumPhotoInfo> _003C_003E9__73_0;

		public static Func<AlbumPhotoInfo, string> _003C_003E9__74_0;

		public static Action<Dictionary<string, bool>, string> _003C_003E9__74_1;

		public static Func<AlbumPhotoInfo, long> _003C_003E9__98_0;

		internal int _003CGetAllCanShowGroupPhotoTemplate_003Eb__38_0(GroupPhotoTemplateData a, GroupPhotoTemplateData b)
		{
			return 0;
		}

		internal int _003CGetAllCanShowPhotoFrames_003Eb__44_0(PhotoFrameWithResConfig a, PhotoFrameWithResConfig b)
		{
			return 0;
		}

		internal int _003CGetAllCanShowStickers_003Eb__47_0(StickerWithResConfig a, StickerWithResConfig b)
		{
			return 0;
		}

		internal int _003CReadAlbumInfo_003Eb__70_0(AlbumPhotoInfo a, AlbumPhotoInfo b)
		{
			return 0;
		}

		internal int _003CAddAlbumPhotoInfo_003Eb__73_0(AlbumPhotoInfo a, AlbumPhotoInfo b)
		{
			return 0;
		}

		internal string _003CRemoveAlbumPhotoInfoForSystem_003Eb__74_0(AlbumPhotoInfo info)
		{
			return null;
		}

		internal void _003CRemoveAlbumPhotoInfoForSystem_003Eb__74_1(Dictionary<string, bool> results, string _error)
		{
		}

		internal long _003CUpdateVideoMemory_003Eb__98_0(AlbumPhotoInfo p)
		{
			return 0L;
		}
	}

	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public GroupPhotoTemplateDesc desc;

		internal bool _003CProcessLoginDesc_003Eb__0(GroupPhotoTemplateConfigDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public AlbumPhotoInfo info;

		internal bool _003CRemoveAlbumPhotoInfoForSystem_003Eb__2(AlbumPhotoInfo p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public UIModelTakePhoto _003C_003E4__this;

		public List<AlbumPhotoInfo> needDeleteSystemPhoto;

		public bool showtips;

		internal void _003CRemoveAlbumPhotoInfo_003Eb__0(MediaMgr.MediaType mediaType, MediaMgr.MediaAccessType accessType, MediaMgr.MediaAuthStatus authStatus, string error)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_1
	{
		public AlbumPhotoInfo info;

		internal bool _003CRemoveAlbumPhotoInfo_003Eb__1(AlbumPhotoInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_0
	{
		public AlbumPhotoInfo info;

		internal bool _003COnlyRemoveAlbumPhotoInfoFromJson_003Eb__0(AlbumPhotoInfo p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public KeyValuePair<string, MediaMgr.MediaMetaData> kv;

		internal bool _003CTryGetAlbumPhotoInfosInternal_003Eb__1(AlbumPhotoInfo p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public string native_identifier;

		internal bool _003CCheckSystemPhotoFileIsModed_003Eb__0(AlbumPhotoInfo p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass92_0
	{
		public UIModelTakePhoto _003C_003E4__this;

		public Action<bool, MediaMgr.IAlbumImageTexture, string> callback;

		public AlbumPhotoInfo info;

		public Action<string, MediaMgr.IAlbumImageTexture, string> _003C_003E9__1;

		internal void _003CGetAlbumPhotoTexByAlbumPhotoInfo_003Eb__0(Dictionary<string, MediaMgr.MediaMetaData> mediaExistence, string error)
		{
		}

		internal void _003CGetAlbumPhotoTexByAlbumPhotoInfo_003Eb__1(string nativeIdentifier, MediaMgr.IAlbumImageTexture albumImageTexture, string _error)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass94_0
	{
		public UIModelTakePhoto _003C_003E4__this;

		public Action<bool, string> callback;

		public byte[] photoBytes;

		internal void _003CRequestUploadPhotoWall_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass94_1
	{
		public CSGetPhotoWallUploadURLRes urlRes;

		public _003C_003Ec__DisplayClass94_0 CS_0024_003C_003E8__locals1;

		internal void _003CRequestUploadPhotoWall_003Eb__1(bool success, string error)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass95_0
	{
		public UIModelTakePhoto _003C_003E4__this;

		public Action<bool, string> callback;

		internal void _003CRequestReportPhotoWallUploadSuss_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private static string AlbumDir;

	private IEnumerator m_DeleteFilePathsFCoroutine;

	private Queue<AlbumPhotoInfo> NeedDeleteFilePaths;

	private Dictionary<string, Texture2D> ThumbnailBytesCache;

	private AlbumPhotoInfos mAlbumPhotoInfos;

	public int LobbyFilterIdCache;

	public int ProfileFilterIdCache;

	public int LobbyFxIdCache;

	public int ProfileFxIdCache;

	private const string STICKER_PLAYERPREF_KEY = "Sticker_{0}";

	private const string PHOTO_FRAME_PLAYERPREF_KEY = "PhotoFrame_{0}";

	private const string BACKGROUND_TAB_CLICKED_KEY = "BackgroundTabClicked_{0}";

	public const uint PropID_AlbumPhotoInfos_Ready = 1u;

	public const uint PropID_GotCurrentSelectBigEventPhotoFrame = 2u;

	public bool IsTakePhotoUIExist;

	private Dictionary<uint, PhotoFrameWithResConfig> PhotoFrameConfigDicHorizontal;

	private Dictionary<uint, PhotoFrameWithResConfig> PhotoFrameConfigDicVertical;

	private Dictionary<uint, GroupPhotoTemplateData> GroupPhotoTemplateDic;

	private Dictionary<uint, StickerWithResConfig> StickerConfigDic;

	private Dictionary<uint, PhotoEditBackgroundData> PhotoDecoretonsConfigDic;

	private List<GroupPhotoModelSettingData> GroupPhotoModelSettingList;

	private Dictionary<uint, bool> m_PhotoFrameNewStatusDic;

	private bool m_IsNeedUpdatePhotoFramePlayerPref;

	private Dictionary<uint, bool> m_StickerNewStatusDic;

	private bool m_IsNeedUpdateStickerPlayerPref;

	private uint[] m_CurrentSelectBigEventPhotoFrameIDList;

	private bool m_IsGotCurrentSelectBigEventPhotoFrameID;

	private Dictionary<int, PhotoFilterSettingDesc> m_PhotoFilterSettingDataDic;

	private bool IsQueryingAlbumPhotoInfos;

	private HashSet<string> m_CheckFileExistSet;

	private MediaMgr.IAlbumImageTexture IAlbumImageTextureCache;

	public const uint PropID_GotBigEventBackGrounds = 4u;

	protected PhotoBgDataContainer m_PhotoBgDataContainer;

	private AlbumPhotoInfos AlbumPhotoInfos => null;

	public Dictionary<int, PhotoFilterSettingDesc> PhotoFilterSettingDataDic => null;

	public void ClearLobbyFilterIdCache()
	{
	}

	public void ClearProfileFilterIdCache()
	{
	}

	public void ClearLobbyFxIdCache()
	{
	}

	public void ClearProfileFxIdCache()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public List<GroupPhotoTemplateData> GetAllCanShowGroupPhotoTemplate(bool isVertical, uint minMemberCount = 1u)
	{
		return null;
	}

	public GroupPhotoTemplateData GetGroupPhotoTemplateById(uint template_id)
	{
		return null;
	}

	public override void Logout(object[] data)
	{
	}

	public void RequestCurrentSelectBigEventPhotoFrameID()
	{
	}

	public void ProcessLoginDesc(List<GroupPhotoTemplateDesc> groupPhotoTemplateDescs, List<PhotoFrameConfigDesc> photoFrameConfigDescs, List<StickerConfigDesc> stickerConfigDescs, List<PhotoDecoretonsConfigDesc> photoDecoretonsConfigDescs, List<GroupPhotoModelSettingDesc> groupPhotoModelSettingDescs, List<GroupPhotoTemplateConfigDesc> groupPhotoTemplateConfigs)
	{
	}

	public PhotoFrameWithResConfig GetPhotoFrameConfigById(uint id, bool isVertical = false)
	{
		return null;
	}

	public List<PhotoFrameWithResConfig> GetAllCanShowPhotoFrames(bool isVertical)
	{
		return null;
	}

	public void SetCurrentSelectBigEventPhotoFrameIDList(uint[] curSelectBigEventFrameIDList)
	{
	}

	public StickerWithResConfig GetStickerConfigById(uint stickerId)
	{
		return null;
	}

	public List<StickerWithResConfig> GetAllCanShowStickers(uint type)
	{
		return null;
	}

	public List<StickerWithResConfig> GetNeedDefaultShowStickerConfigs(uint type)
	{
		return null;
	}

	public bool IsPhotoFrameGot(PhotoFrameConfigDesc desc)
	{
		return false;
	}

	private bool IsBigEventPhotoFrameGot(uint itemID)
	{
		return false;
	}

	public void UpdatePhotoFrameBtnRedTip(bool isVertical)
	{
	}

	public bool IsPhotoFrameNew(PhotoFrameConfigDesc frameConfig)
	{
		return false;
	}

	public void MarkPhotoFrameAsNotNew(PhotoFrameConfigDesc frameConfig)
	{
	}

	public bool IsStickerGot(StickerConfigDesc desc)
	{
		return false;
	}

	private bool IsActivityStickerGot(uint activityID)
	{
		return false;
	}

	public void UpdateStickerBtnRedTip(uint type)
	{
	}

	public bool IsStickerNew(StickerConfigDesc stickerConfig)
	{
		return false;
	}

	public void MarkStickerAsNotNew(StickerConfigDesc stickerConfig)
	{
	}

	private void GetPhotoFrameAndStickerNewStatusFromPlayerPref()
	{
	}

	public void UpdatePhotoFrameNewStatusPlayerPref()
	{
	}

	public void UpdateStickerNewStatusPlayerPref()
	{
	}

	public bool CheckOutGameTakephotoGuideIsDone()
	{
		return false;
	}

	public bool IsGroupPhotoTemplateNew(GroupPhotoTemplateData templateData)
	{
		return false;
	}

	public void MarkGroupPhotoTemplateAsNotNew(GroupPhotoTemplateData templateData)
	{
	}

	public bool ShouldShowBackgroundTabRedDot()
	{
		return false;
	}

	public void MarkBackgroundTabAsClicked()
	{
	}

	public List<PhotoEditBackgroundData> GetAllCanShowPhotoEditBackgrounds()
	{
		return null;
	}

	public List<GroupPhotoModelSettingData> GetGroupPhotoModelSettingDataByTemplateId(uint templateId)
	{
		return null;
	}

	public List<GroupPhotoModelSettingData> GetGroupPhotoModelSettingDataByTemplateIdAndPosId(uint templateId, uint posId)
	{
		return null;
	}

	private void ReadAlbumInfo()
	{
	}

	private string GetAlbumJsonPath()
	{
		return null;
	}

	public static string GetAlbumDir()
	{
		return null;
	}

	public void AddAlbumPhotoInfo(AlbumPhotoInfo info)
	{
	}

	private void RemoveAlbumPhotoInfoForSystem(List<AlbumPhotoInfo> deleteInfos)
	{
	}

	public void CheckAndDeleteExtraHighlightPhoto()
	{
	}

	public void CheckScreenShotFileIsExpired()
	{
	}

	public void RemoveAlbumPhotoInfo(List<AlbumPhotoInfo> deleteInfos, bool showtips = true)
	{
	}

	public void OnlyRemoveAlbumPhotoInfoFromJson(AlbumPhotoInfo info, bool isDeleteThumbnail = true)
	{
	}

	private void UpdateLocalJson()
	{
	}

	private void TryGetAlbumPhotoInfosInternal()
	{
	}

	private bool CheckSystemPhotoFileIsModed(string native_identifier, MediaMgr.MediaMetaData metaData)
	{
		return false;
	}

	private bool CheckScreenShotFileIsModed(AlbumPhotoInfo info)
	{
		return false;
	}

	public void TryDeleteFileAndThumbnail(string file, string thumbnail)
	{
	}

	public void TryGetAlbumPhotoInfos()
	{
	}

	public void DestoryThumbnailTextureCache(string path)
	{
	}

	public Texture2D GetThumbnailTexture(string path)
	{
		return null;
	}

	public bool OnSavePhotoAlbum(string native_identifier, string originalFilePath, Texture2D screenshotTex, out AlbumPhotoInfo info, bool isThumbnailNeedUseBytes = false, bool isScreenshot = false, bool isVertical = false, uint matchEventID = 0u, uint curRound = 0u, bool isUGCSave = false, bool isCutiingResult = false)
	{
		info = null;
		return false;
	}

	public bool OnSaveHighlightPhotoAlbum(string native_identifier, string originalFilePath, Texture2D screenshotTex, bool isThumbnailNeedUseBytes = false, bool isScreenshot = false, bool isVertical = false, AlbumPhotoInfo highlightAlbumPhotoInfo = null)
	{
		return false;
	}

	public void GetAlbumPhotoTexByAlbumPhotoInfo(AlbumPhotoInfo info, Action<bool, MediaMgr.IAlbumImageTexture, string> callback)
	{
	}

	private void TryCreateAlbumImageTexturePool()
	{
	}

	public void RequestUploadPhotoWall(byte[] photoBytes, string fileName, Action<bool, string> callback)
	{
	}

	private void RequestReportPhotoWallUploadSuss(long uploadTime, Action<bool, string> callback)
	{
	}

	private void FinishPhotoWallUpload(Action<bool, string> callback, bool success, string error)
	{
	}

	public void ClearAllPhotoCache()
	{
	}

	public void UpdateVideoMemory(UILabel lblMemory, UISprite iconCurMemory, UISprite iconTotalMemory, bool isAlbum = false)
	{
	}

	private float FormatPlatformMemory(long value)
	{
		return 0f;
	}

	public List<AlbumPhotoInfo> GetVaildAlbumPhotoInfos()
	{
		return null;
	}

	public List<AlbumPhotoInfo> GetHighlightPhotosByMatchId(ulong matchId)
	{
		return null;
	}

	public void RefreshSelfBackpak(bool show, UIMaleAvatar avatar, bool isTryStopAnim = true)
	{
	}

	public void RefreshSelfWeapon(bool show, UIMaleAvatar avatar, bool isTryStopAnim = true)
	{
	}

	protected void InitPhotoBgDataContainer()
	{
	}

	public PhotoBgDataContainer GetPhotoBgDataContainer()
	{
		return null;
	}

	public Type GetBigEventBgItemController()
	{
		return null;
	}

	public void OnSelectBackground(PhotoBackGroundData bgData)
	{
	}

	public bool IsPhotoBgTabFirstClicked()
	{
		return false;
	}

	public void MarkPhotoBgTabAsFirstClicked()
	{
	}

	public bool IsUnlockPhotoBgTab()
	{
		return false;
	}

	public bool ShouldShowPhotoBgTabRedDot()
	{
		return false;
	}

	public void MarkPhotoBgTabAsClicked()
	{
	}

	public void RequestEquipBackgroundInfo()
	{
	}

	public List<PhotoBackGroundData> GetBigEventGroupPhotoBackGrounds()
	{
		return null;
	}

	public string GetFormatPhotoBgTimeStamp()
	{
		return null;
	}

	public void ClearBigEventGroupPhotoBackGrounds()
	{
	}

	public void ProcessPhotoFilterDesc(List<PhotoFilterSettingDesc> photo_filter_setting_desc)
	{
	}

	private void _003CRequestCurrentSelectBigEventPhotoFrameID_003Eb__41_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CTryGetAlbumPhotoInfosInternal_003Eb__82_0(Dictionary<string, MediaMgr.MediaMetaData> mediaExistence, string error)
	{
	}

	private void _003CTryGetAlbumPhotoInfos_003Eb__86_0(MediaMgr.MediaType mediaType, MediaMgr.MediaAccessType accessType, MediaMgr.MediaAuthStatus authStatus, string error)
	{
	}

	private void _003CRequestEquipBackgroundInfo_003Eb__115_0(bool success)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
