using GCommon;
using proto;

namespace COW.Gameplay.UGC;

public class UGCInGameMatchMakingManager
{
	public enum UGCInGameMatchMakingState
	{
		Start,
		Downloading,
		Downloaded,
		Matchmaking,
		End
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public CSGetWorkshopExportSettingRes data;

		public UGCInGameMatchMakingManager _003C_003E4__this;

		internal void _003CRequestGameDataUrl_003Eb__1(byte[] gameDataBytes)
		{
		}
	}

	private string m_MapCode;

	private int m_RequestRetryCount;

	private byte[] m_GameDataBytes;

	private SceneEditSlotInfo m_Info;

	private UGCSimpleDownloadTask m_ResDownloadTask;

	private EventLogger.EventTypeUGCLoadingResDownload m_ResDownloadLogInfo;

	private const int ServerMatchmakingPhase_Preparing = 0;

	private const int ServerMatchmakingPhase_Matchmaking = 1;

	private int m_playerNum;

	private int m_lastMatchmakingPlayerNum;

	private bool m_ResumeToMatchmaking;

	private UIModelSceneEdit m_UIModelSceneEdit;

	private UGCInGameMatchMakingState m_State;

	private UIHUDUGC_CrossMapMatchmakingController m_CrossMapMatchmakingController;

	public bool IsMatchmaking => false;

	private UIHUDUGC_CrossMapMatchmakingController CrossMapMatchmakingController => null;

	public UGCInGameMatchMakingState CurState
	{
		get
		{
			return UGCInGameMatchMakingState.Start;
		}
		set
		{
		}
	}

	public void Init(string mapCode, int playerNum, int resumePhase = 0)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnCtrlCancelClick()
	{
	}

	public void UpdateMatchMakingState()
	{
	}

	private void RequestMapDetailInfo()
	{
	}

	private void OnReceiveMapDetailInfo(SceneEditSlotInfo slotInfo)
	{
	}

	private void NotifyGSExceedPlayerNum()
	{
	}

	private void StartDownloading()
	{
	}

	private void NotifyFinishDownloadSuccess()
	{
	}

	private void RequestGameDataUrl()
	{
	}

	private void HandleDownloadGameData(SceneEditSlotInfo info, byte[] gameData)
	{
	}

	private void OnGameDataReady(SceneEditSlotInfo info, byte[] gameData)
	{
	}

	private void DownloadResourceBySlotInfo()
	{
	}

	private void DownloadResourceInternal()
	{
	}

	private void HandelDownloadConfirm(object[] param)
	{
	}

	private void HandleResDownloadRefresh(object[] param)
	{
	}

	private void HandleDownloadPopupCancel(object[] param)
	{
	}

	private void HandleResourceDownloadFailed(object[] param)
	{
	}

	private void SendCancelResDownloadMessage()
	{
	}

	private void OnEnterStateDownloaded()
	{
	}

	private void OnEnterStateMatchmaking()
	{
	}

	public void HandleCancelMatchmaking()
	{
	}

	private void CleanProcess()
	{
	}

	public void UpdateMatchMakingDownloadProgress(int ready, int total)
	{
	}

	public void OnReceiveCancelMatchmaking()
	{
	}

	public void OnReceiveStartMatchmaking(int playerNum)
	{
	}

	public void OnReceiveResDownloadTimeout()
	{
	}

	private void _003CStartDownloading_003Eb__29_0(byte[] gameDataBytes)
	{
	}

	private void _003CRequestGameDataUrl_003Eb__31_0(HttpErrorCode errorCode, object res)
	{
	}
}
