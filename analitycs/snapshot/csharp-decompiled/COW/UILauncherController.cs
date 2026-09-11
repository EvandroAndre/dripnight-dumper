using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UILauncherController : UIBaseController
{
	public delegate UIBaseController CreateMessageBox(string path, Type classType);

	private enum EHttpVerInfoErrorCode
	{
		OK,
		ERROR,
		NOVERSIONFOUND
	}

	private class HttpVerInfo
	{
		public uint code;

		public bool is_server_open;

		public bool is_firewall_open;

		public bool need_track_hotupdate;

		public double min_hint_size;

		public string billboard_cdn_url;

		public string billboard_msg;

		public string patchnote_url;

		public string web_url;

		public string billboard_bg_url;

		public string max_store;

		public string max_web;

		public string max_video;

		public string remote_version;

		public string remote_option_version;

		public string remote_option_version_astc;

		public string cdn_url;

		public string abhotupdate_cdn_url;

		public string backup_cdn_url;

		public string server_url;

		public bool is_review_server;

		public string appstore_url;

		public string backup_appstore_url;

		public bool force_to_restart_app;

		public string country_code;

		public int gdpr_version;

		public string client_ip;

		public string maintenance_announcement;

		public string maintenance_region;

		public string[] need_check_ip_list;

		public string network_log_server;

		public string web_log_server;

		public int login_failed_count;

		public string test_url;

		public string img_cdn_url;

		public string core_url;

		public string[] core_ip_list;

		public bool is_update_btn_show;

		public bool is_use_multi_download;

		public bool use_login_optional_download;

		public bool use_background_download;

		public bool use_background_download_lobby;

		public float use_backgound_download_mem_thredshold;

		public bool garena_login;

		public bool garena_hint;

		public bool enable_clear_mem_when_autopause;

		public double space_required_in_GB;

		public string gop_url;

		public string login_download_optionalpack;

		public string gamevar;

		public string latest_release_version;

		public bool use_multithread_hash;

		public bool should_check_ab_load;

		public bool should_check_ab_exist;

		public bool use_regional_gamevar;

		public bool enable_hash_pdcache;

		public int device_whitelist_priority;

		public int quality_level;

		public int graphic_level;

		public bool show_high_framerate_UI;

		public int high_frame_default;

		public string resolution_reduceRate_blit_type;

		public int device_whitelist_sp_priority;

		public uint apply_skin;

		public bool enable_reduce_rate;

		public bool enable_min_resolution_height;

		public bool enable_min_height;

		public bool enable_unmap_web_view_vm;

		public string device_whitelist_version;

		public string device_whitelist_sp_version;

		public int whitelist_mask;

		public string whitelist_info;

		public int whitelist_sp_mask;

		public string whitelist_sp_info;

		public string force_refresh_restype;

		public bool should_check_ab_size;

		public string ggp_url;

		public string abhotupdate_check;

		public bool hotfile_force_update;

		public string multi_region;
	}

	public class HttpWhitelistInfo
	{
		public int whitelist_mask;

		public string whitelist_info;

		public int whitelist_sp_mask;

		public string whitelist_sp_info;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__62_4;

		internal void _003CCheckVersion_003Eb__62_4()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public float toMB;

		public UILauncherController _003C_003E4__this;

		internal void _003CCheckVersion_003Eb__3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass63_0
	{
		public UILauncherController _003C_003E4__this;

		public float spaceRequiredInGB;

		internal void _003COnColdUpdate_003Eb__0()
		{
		}

		internal void _003COnColdUpdate_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public bool is_from_pass;

		public UILauncherController _003C_003E4__this;

		public Action<ResErrorCode> _003C_003E9__1;

		internal void _003COnHotUpdateFinished_003Eb__1(ResErrorCode error)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_1
	{
		public bool useMtHash;

		public _003C_003Ec__DisplayClass68_0 CS_0024_003C_003E8__locals1;

		internal void _003COnHotUpdateFinished_003Eb__0(ResErrorCode ret, ResDownloadType type)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_2
	{
		public float toMB;

		public _003C_003Ec__DisplayClass68_0 CS_0024_003C_003E8__locals2;

		internal void _003COnHotUpdateFinished_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public Action<ResErrorCode> finished_callback;

		public UILauncherController _003C_003E4__this;

		public List<uint> type_List;

		internal void _003CStartLoginDownload_003Eb__0(ResErrorCode _error_code, ResDownloadType _context_type)
		{
		}
	}

	private sealed class _003CStartCheckVersion_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILauncherController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartCheckVersion_003Ed__71(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CStartHotUpdating_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILauncherController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartHotUpdating_003Ed__70(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CStartLaunchGame_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILauncherController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartLaunchGame_003Ed__69(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CStartLocDownload_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILauncherController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartLocDownload_003Ed__72(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CStartLoginCommonDownload_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILauncherController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartLoginCommonDownload_003Ed__73(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public Action OnLaunchGame;

	public CreateMessageBox OnCreateMessageBox;

	public bool IsRestart;

	private const uint UI_GROUP_HOTUPDATE = 2u;

	private const uint UI_GROUP_MAX = 4u;

	private const uint UI_GROUP_QUIT = 8u;

	private UILauncherPopupMessageController m_MessageBox;

	private UILauncherMaxController m_FFMaxMessageBox;

	private UIPopupMessageBoxController m_QuitMessageBox;

	private UILauncherConfirmWnd m_ConfirmWnd;

	private UILauncherView m_View;

	private float m_Progress;

	private float m_TotalHotUpdatingMBytes;

	private bool m_IsHotUpdating;

	private bool m_IsUnzipping;

	private int m_LastSleepTimeout;

	private bool m_LastRunInBackground;

	private bool m_Cleanup;

	private HttpVerInfo remoteVerInfo;

	private string m_MultiRegionEnds;

	private bool m_NeedTrackHotUpdate;

	private float m_ShowMessageSize;

	private bool m_IsDownloadingLoc;

	private bool m_IsLoadingGame;

	private bool m_IsDownloadingClothesCommon;

	private uint m_NowDownloadingType;

	private int m_LocErrorCount;

	private string LAUNCHER_PREFS_KEY;

	private bool m_NeedUseBackUpCDN;

	private int m_RemoteFileInfoErrCount;

	private List<uint> m_LoginDownloadResList;

	private string m_LoadingTxt;

	private UIFFLogoController m_UIFFLogoCtrl;

	public const string WhitelistVersion = "WhitelistVersion";

	public const string WhitelistSPVersion = "WhitelistSPVersion";

	private const float HOTUPDATE_DOWNLOAD_FINISH_PROGRESS = 40f;

	private const float UNZIP_FINISH_PROGRESS = 50f;

	private const float LOC_DOWNLOAD_FINISH_PROGRESS = 60f;

	private bool m_CanInGameHotupdate;

	private static string NORMALREMOTEVERSION;

	private static string ASTCREMOTEVERSION;

	private uint m_PrevActiveGroup;

	private uint m_LastActiveGroup;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void AppFlyerTrackStart()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	private void CheckIsFirstLauncherAfterMajorVersionUpdate()
	{
	}

	private void ShowLauncherPopupMessageBox(string info, UILauncherPopupMessageController.ELauncherMessageType mbType, Action onOK = null, UILauncherPopupMessageController.EButtonStyle buttonStyle = UILauncherPopupMessageController.EButtonStyle.OK, string[] urlList = null, string patchNoteUrl = null, Action onRetry = null, string webViewUrl = null, string bgUrl = null, string maxUrl = null, bool allowCompatibleLogin = false, Action onCompatibleLogin = null)
	{
	}

	private bool IsLatestReleaseVersion(HttpVerInfo verInfo)
	{
		return false;
	}

	private void SaveNotFirstStartUp()
	{
	}

	private void LoadResconf()
	{
	}

	private void LoadResconfAndLoc()
	{
	}

	private void RetrieveVerInfo()
	{
	}

	private void OnGotVerInfo(HttpErrorCode errorCode, object res)
	{
	}

	private void StartVersionCheck()
	{
	}

	private void OpenFFMaxIntro()
	{
	}

	private void OpenSpaceInsufficientNoticeWnd(float spaceRequiredInGB, float freeSpaceInGB)
	{
	}

	private void ReadReleaseVersion()
	{
	}

	private void CheckVersion()
	{
	}

	private void OnColdUpdate(float spaceRequiredInGB = 0f, bool allowCompatibleLogin = false)
	{
	}

	private string GetSpaceByRule(float GB)
	{
		return null;
	}

	private void OnHotUpdateError(string detailErrorMessage = "")
	{
	}

	private void OnLocUpdateError(ResErrorCode last_err)
	{
	}

	private void OnHotUpdateFinished(ResErrorCode result)
	{
	}

	private void OnHotUpdateFinished(ResErrorCode result, bool is_from_pass)
	{
	}

	private IEnumerator StartLaunchGame()
	{
		return null;
	}

	private IEnumerator StartHotUpdating()
	{
		return null;
	}

	private IEnumerator StartCheckVersion()
	{
		return null;
	}

	private IEnumerator StartLocDownload()
	{
		return null;
	}

	private IEnumerator StartLoginCommonDownload()
	{
		return null;
	}

	public void StartLoginDownload(List<uint> type_List, Action<ResErrorCode> finished_callback = null)
	{
	}

	private void OnStartUpdating()
	{
	}

	private void OnFinishUpdating()
	{
	}

	private void SetActiveGroup(uint activeGroup)
	{
	}

	private void SetPreviousActiveGroup()
	{
	}

	private void OnLocDownloaded(ResErrorCode err_code, ResDownloadType type)
	{
	}

	private void OnOptionalCommonFileDownloaded(ResErrorCode err_code)
	{
	}

	private void RefreshLauncherEffect()
	{
	}

	private void OnGotWhitelist(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CUpdate_003Eb__43_0()
	{
	}

	private void _003CUpdate_003Eb__43_1()
	{
	}

	private void _003COnGotVerInfo_003Eb__57_0()
	{
	}

	private void _003COpenFFMaxIntro_003Eb__59_0()
	{
	}

	private void _003COpenSpaceInsufficientNoticeWnd_003Eb__60_0()
	{
	}

	private void _003CCheckVersion_003Eb__62_0(ResHotUpdateResult result)
	{
	}

	private void _003CCheckVersion_003Eb__62_1(ResHotUpdateResult result)
	{
	}

	private void _003CCheckVersion_003Eb__62_2(ResHotUpdateResult result)
	{
	}

	private void _003COnHotUpdateError_003Eb__65_0()
	{
	}

	private void _003COnLocUpdateError_003Eb__66_0()
	{
	}

	private void _003COnLocUpdateError_003Eb__66_1()
	{
	}

	private void _003COnLocUpdateError_003Eb__66_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
