using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

internal class UILoadingController : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public Vector2 fitSize;

		public UILoadingController _003C_003E4__this;

		internal void _003CRefreshLoadingBgAndTips_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public bool gamemodeNoneFilter;

		internal bool _003CGetCdnUrlByGameMode_003Eb__0(AdvertDesc v)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public UILoadingController _003C_003E4__this;

		public SceneEditSlotInfo slotInfo;

		internal bool _003CRefreshSceneEditMapInfo_003Eb__0(WorkshopCreateNewConfigData data)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_1
	{
		public UINetworkTexture texComp;

		public _003C_003Ec__DisplayClass74_0 CS_0024_003C_003E8__locals1;

		internal void _003CRefreshSceneEditMapInfo_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_2
	{
		public int templateIndex;

		public _003C_003Ec__DisplayClass74_0 CS_0024_003C_003E8__locals2;

		internal bool _003CRefreshSceneEditMapInfo_003Eb__2(WorkshopCreateNewConfigData data)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_3
	{
		public UINetworkTexture texComp;

		public _003C_003Ec__DisplayClass74_0 CS_0024_003C_003E8__locals3;

		internal void _003CRefreshSceneEditMapInfo_003Eb__3()
		{
		}
	}

	public UILabel m_Tips;

	public UIProgressBar m_ProgressBar;

	public UILabel m_ProgressText;

	public UILabel m_WarningTips;

	public UINetworkTexture m_BG;

	private float m_Progress;

	public UISprite Logo;

	public UIGrid m_GridPlayerInfo;

	public Transform m_RootPlayerInfoTip;

	public Transform m_UGCLoadingMapInfo;

	public GameObject m_LoadingEffect1;

	public GameObject m_LoadingEffect2;

	public UILabel m_MapModeDescTips;

	public GameObject m_SpecialCSModeGroup;

	public UISprite m_SpecialCSModeIcon;

	public UILabel m_SpecialCSModeTitleLabel;

	public Transform m_HighlightReplay;

	public UITexture m_Fakeloading;

	public UITexture m_NinthBG;

	public Transform m_NinthBGUIFXRoot;

	public GameObject m_NinthBGContainer;

	public GameObject m_NormalBGContainer;

	public Transform m_UGCTutorialLoadingTips;

	private GameObject m_NinthBGUIFXGo;

	private Texture2D m_NinthBGTexture;

	private float m_OpenTime;

	private float m_UGCDelayTime;

	private bool m_UGCLoadingFail;

	private bool m_UGCLoadingStartMatch;

	private uint m_UGCFinishPlayer;

	private uint m_UGCTotalPlayer;

	private bool m_AchieveTimeLengthCanClose;

	private int m_CanDestroyFrame;

	private bool m_TriggerNeedUnloadAsset;

	private bool m_UGCloading;

	private WorkshopDownloadData m_WorkshopDownloadData;

	private GameObject m_BRLoadingVfx;

	private List<UILoadingPlayerInfoController> m_UILoadingPlayerInfoControllers;

	private List<ResVersionInfo.FileInfo> m_NeedDownloadFileInfos;

	private float m_TimeTick;

	private bool m_MainSceneLoaded;

	private float awaketime;

	private Vector2 m_FullScreenNguiSize;

	private bool m_FullScreenNguiSizeInitSuccess;

	private UIFFLogoController m_UIFFLogoCtrl;

	private float m_DelayDestroyTime;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetDelayDestroyTime(float delayTime)
	{
	}

	private void CheckDelayDestroyTime()
	{
	}

	public void RegisterDownloadingEvent()
	{
	}

	private void RefreshLoadingProcessWaitStatus()
	{
	}

	private void LoadFakeLoadingTexture()
	{
	}

	private void RefreshDownloadList(object[] param)
	{
	}

	private void OnLoadingStartMatch(object[] param)
	{
	}

	private void OnUGCLoadingFail(object[] param)
	{
	}

	private void RefreshHaveDownloadedPlayerNum(object[] param)
	{
	}

	public void TriggerCanDestroy(int delayFrames)
	{
	}

	public void TriggerNeedUnloadAsset()
	{
	}

	private void CheckCanDestroy()
	{
	}

	private void DestroySelf()
	{
	}

	private void OnDestroy()
	{
	}

	private void RefreshProgress()
	{
	}

	private float GenerateFakeProgressValue(float TrueProgress)
	{
		return 0f;
	}

	private void RefreshUGCProgress()
	{
	}

	private void RefreshLoadingBgAndTips()
	{
	}

	private void RefershNinthBG(Vector3 localScale, Vector3 localPosition)
	{
	}

	private void RefreshSpecialCSModeGroup()
	{
	}

	private void RefreshGamePattern()
	{
	}

	private bool CheckAllFileDownloadFinish()
	{
		return false;
	}

	private string GetCdnUrlByGameMode(out uint endTime, bool gamemodeNoneFilter = false)
	{
		endTime = default(uint);
		return null;
	}

	private bool CheckNeedShowPlayerInfo()
	{
		return false;
	}

	private void OpenHighlightAnim()
	{
	}

	private void RefreshSceneEditMapInfo()
	{
	}

	private void BuildUGCTutorialLoadingTips(UGCTutorialLevelConfig levelConfig)
	{
	}

	private void RefreshPlayerInfo()
	{
	}

	public void ShowFriendOBWait()
	{
	}

	private int SortLoadingCard(MatchPregameInfo a, MatchPregameInfo b)
	{
		return 0;
	}

	private void GetRandomCDNAndTipsByLoadingConfig(out string cdnURL, out string tips)
	{
		cdnURL = null;
		tips = null;
	}

	private bool IsLobbySocialAreaLoading()
	{
		return false;
	}

	private uint GetLoadingMapID()
	{
		return 0u;
	}

	private uint GetLoadingGameMode()
	{
		return 0u;
	}

	private void GetMapModeDescTips(out string mapStr, out string modeStr)
	{
		mapStr = null;
		modeStr = null;
	}

	private void SwitchMatchGameAudio(bool state)
	{
	}

	public void OnMainSceneLoaded()
	{
	}
}
