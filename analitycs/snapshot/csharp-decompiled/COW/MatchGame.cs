using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using WorldStreamer;
using message;

namespace COW;

internal abstract class MatchGame : COWGameBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__101_1;

		internal void _003COnReturnToLobby_003Eb__101_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public bool needGoto3DLobby;

		public bool beforeRetunrIsInSocialAreaGameRoom;

		public MatchGame _003C_003E4__this;

		internal void _003COnReturnToLobby_003Eb__0()
		{
		}
	}

	protected EMKJHAJNPDH m_Match;

	protected GameModeSetting m_GameModeSetting;

	protected uint m_ReturnToLobbyRequest;

	protected ANINHOGNNKB m_CameraModeManager;

	protected NAHFMFGGCDN m_LevelObjectManager;

	protected MFHGBNGFDIP m_MetaManager;

	protected Dictionary<uint, ReplicationEntity> m_ReplicationEntitis;

	protected Dictionary<uint, LReplicationEntity> m_LReplicationEntitis;

	protected IGRIDataPool m_GRIDataPool;

	protected CameraControllerManager m_CameraControllerManager;

	protected uint m_QuitMatchRequest;

	protected bool mUseAB;

	protected bool m_isSendMsg;

	protected InGameCutsceneManager m_InGameCutsceneManager;

	protected string mSceneABPath;

	protected string mStreamSceneAbPath;

	protected AssetBundle m_streamSceneAB;

	protected Dictionary<int, List<CFIJFGBBLON>> m_streamScenePatchAB;

	protected GameObject m_UmaDcs;

	protected WolfTrapManager m_WolfTrapManager;

	protected MPHKHODEACE m_PoteniallyVisibleSetManager;

	protected HashSet<ResourceID> m_UnUsedItemResourceList;

	protected Dictionary<ResourceID, ResourceManager.PreloadResourceInfo> m_PreloadResourcePoolInitDic;

	protected MJAFBLCDDEM m_Amb2DAudioManager;

	private bool m_SceneLoaded;

	private bool m_UGCClientPlayerCanMove;

	private List<KMPAHCCABAL> m_PendingBrokenBehaviorMsgList;

	private bool m_IsLocalPlayerHasToxicBehavior;

	private DKGFHLKJHHG m_LowGravityAreaManager;

	private CLLLDGMKBHK m_InGameShopManager;

	private DHLFCEHOPHH m_HealRobotXRayManager;

	private JNPKEGLIEPC m_SpeedScaleGroupInfo;

	protected MJEPOJGGMPC mCurrDragonTaskPhase;

	protected bool mIsDragonTaskWin;

	protected bool m_IsShowPlayerOutLine;

	protected bool m_IsShowTeamOutLine;

	public List<uint> m_OutlineSpecialCloths;

	private SortedList<int, SortedList<int, ArcGenerator>> m_AllArcGenerator;

	private Dictionary<int, BezierSlide> m_AllBezierSlides;

	public Dictionary<uint, SlidePrefabConfig> SlidePrefabConfigs;

	public Dictionary<uint, List<SlideDoorManager>> m_AllSlideDoorManager;

	public SlideColorManager SlideColorManager;

	private Dictionary<uint, List<SlideStation>> m_SlideStations;

	public Dictionary<uint, bool> m_SlideEnemyInfoMap;

	public Dictionary<uint, bool> m_SlideScanAreaInfoMap;

	public bool HasEnterSlideScanArea;

	protected SortedDictionary<uint, bool> m_SquareDancingEmoteIDs;

	public Dictionary<uint, float> ElecttricGirlSfxGlobalTs;

	public uint PickupSkillPerksCardFullScreenVfxId;

	protected MFLHGFJAOMA m_RevivePointReplaceRes;

	private List<BHGGAEEHJCO> m_SquareDancingPlayerList;

	protected SortedDictionary<uint, ClientSquareDancingTrigger> m_SquareDancingTriggerList;

	protected SortedDictionary<uint, LevelMusicBox> m_MusicBoxList;

	private BHGGAEEHJCO m_PlayingSuperEmotePlayerId;

	private List<BHGGAEEHJCO> m_SuperEmotePlayerIDs;

	private CGAFHKJNJGC m_RMDManager;

	public DJFOLHHFCNM m_AIECAManager;

	protected Font m_font;

	private int m_fontTextureRebuildCount;

	private bool m_isStopFontTextureRebuild;

	private int m_resizePushCharSize;

	private const int s_fontTextureRebuildMaxCount = 15;

	private const int s_fontTextureSize = 1024;

	private const int s_halfFontTextureSize = 512;

	private const int s_asciiVisiableCharStart = 33;

	private const int s_asciiVisiableCharEnd = 126;

	private const int s_resizePushCharStartSize = 16;

	private const int s_resizePushCharMaxSize = 128;

	private const int s_clearePushCharStartSize = 16;

	private const int s_clearPushCharMaxSize = 128;

	public MJAFBLCDDEM Amb2DAudioManager => null;

	public bool IsGameHaveSlidePath => false;

	public SortedList<int, SortedList<int, ArcGenerator>> AllArcGenerator => null;

	public Dictionary<int, BezierSlide> AllBezierSlides => null;

	public Dictionary<uint, List<SlideDoorManager>> AllSlideDoorManager => null;

	public Dictionary<uint, List<SlideStation>> SlideStations => null;

	public Dictionary<uint, bool> SlideEnemyInfoMap => null;

	public Dictionary<uint, bool> SlideScanAreaInfoMap => null;

	public BHGGAEEHJCO PlayingSuperEmotePlayerId
	{
		get
		{
			return default(BHGGAEEHJCO);
		}
		set
		{
		}
	}

	public List<BHGGAEEHJCO> SuperEmotePlayerIDs => null;

	public CGAFHKJNJGC RMDManager => null;

	public void AddBezierSlide(BezierSlide slide)
	{
	}

	public BezierSlide FindBezierSlide(int groupID)
	{
		return null;
	}

	public void AddSlideStation(SlideStation station)
	{
	}

	public List<SlideStation> GetSlideStationsById(uint groupid)
	{
		return null;
	}

	public EMKJHAJNPDH GetMatch()
	{
		return null;
	}

	public virtual bool AllowPlayerMoving()
	{
		return false;
	}

	public virtual void SetUGCClientPlayerCanMove(bool canMove)
	{
	}

	public virtual void OnUGCAllowPlayerMovingChanged(bool canMove)
	{
	}

	public virtual bool IsOnlineGame()
	{
		return false;
	}

	public override bool NotUsingAB()
	{
		return false;
	}

	public override void SetSceneABInfo(AssetBundle ab, bool useAB, string abPath, string streamABPath)
	{
	}

	public override void SetScenePatchABInfo(Dictionary<int, List<CFIJFGBBLON>> patchAB)
	{
	}

	public override string GetSceneStreamABPath()
	{
		return null;
	}

	public override string GetSceneABPath()
	{
		return null;
	}

	public override AssetBundle GetStreamSceneAB()
	{
		return null;
	}

	public override Dictionary<int, List<CFIJFGBBLON>> GetStreamScenePatchAB()
	{
		return null;
	}

	public override byte[] GetStreamSceneABTexRefInfo()
	{
		return null;
	}

	public override Type GetUISceneType()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	private void UIRootOnAwake(UIRoot uiroot)
	{
	}

	protected virtual void InitGRIData()
	{
	}

	protected override void OnSceneLoaded()
	{
	}

	protected virtual void PlayDefaultAmbienceAudioOnSceneLoaded()
	{
	}

	protected void PlayDefaultAmbienceAudio()
	{
	}

	private void InitPotentiallyVisibleSetManager()
	{
	}

	protected override void OnUnInit()
	{
	}

	protected override void OnLateUpdate()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnInitWithInGameReload()
	{
	}

	protected override void OnUnInitWithInGameReload()
	{
	}

	protected override void OnUpdate()
	{
	}

	public bool ShowFlightOpeningAnimation()
	{
		return false;
	}

	public bool FlightOpeningAnimationEnable()
	{
		return false;
	}

	public bool ShowGameOpeingAnimation()
	{
		return false;
	}

	public bool GameOpeningMovieAnimationEnable()
	{
		return false;
	}

	protected virtual bool BlockReturnToLobby()
	{
		return false;
	}

	private void OnReturnToLobby(object[] data)
	{
	}

	private void OnDisconnectByServer(object[] param)
	{
	}

	private void ReturnToLobbyByMultiLogin()
	{
	}

	protected virtual void OnLeaveMatchGame()
	{
	}

	public ANINHOGNNKB GetCameraModeManager()
	{
		return null;
	}

	public NAHFMFGGCDN GetLevelObjectManager()
	{
		return null;
	}

	public MFHGBNGFDIP GetMetaManager()
	{
		return null;
	}

	public CLLLDGMKBHK GetInGameShopManager()
	{
		return null;
	}

	public WolfTrapManager GetWolfTrapManager()
	{
		return null;
	}

	public MPHKHODEACE GetPoteniallyVisibleSetManager()
	{
		return null;
	}

	public virtual GameModeSetting GetGameModeSetting()
	{
		return null;
	}

	public MFLHGFJAOMA GetRevivePointReplaceRes()
	{
		return null;
	}

	public void InitRevivePointReplaceRes()
	{
	}

	public CameraControllerManager GetCameraControllerManager()
	{
		return null;
	}

	public void RegisterRepEntity(ReplicationEntity entity)
	{
	}

	public void UnRegisterRepEntity(ReplicationEntity entity)
	{
	}

	public ReplicationEntity GetRepEntity(uint id)
	{
		return null;
	}

	public void RegisterLRepEntity(LReplicationEntity entity)
	{
	}

	public void UnRegisterLRepEntity(LReplicationEntity entity)
	{
	}

	public LReplicationEntity GetLRepEntity(uint id)
	{
		return null;
	}

	public void OnSyncReplicationData(FastBinaryReader reader)
	{
	}

	public bool IsDragonTaskWin()
	{
		return false;
	}

	public MJEPOJGGMPC GetCurDragonTaskPhase()
	{
		return MJEPOJGGMPC.EDragonTaskPhase_None;
	}

	public bool IsInDragonTaskPhase()
	{
		return false;
	}

	public bool IsInDragonTaskFight()
	{
		return false;
	}

	protected virtual void OnAlivePlayerCountChanged(byte oldValue, byte newValue)
	{
	}

	public virtual byte GetReviveZoneRemainCount()
	{
		return 0;
	}

	public virtual bool IsCache3pIcewallEnabled(Player Owner)
	{
		return false;
	}

	protected void TryInitPlayerOutlineRes(bool EnableShowPlayerOutline, bool EnableShowTeamOutline)
	{
	}

	public bool ShowPlayerOutline()
	{
		return false;
	}

	public bool ShowTeamOutline()
	{
		return false;
	}

	protected void AddUmaDC()
	{
	}

	public void ReleaseUmaDc()
	{
	}

	public void EnsureUmaDc()
	{
	}

	public void OnRequestQuitMatchRes(HIDDBFBEMGM msg)
	{
	}

	public bool IsLocalPlayerAlive()
	{
		return false;
	}

	public bool IsLocalPlayerPendingRevive()
	{
		return false;
	}

	public bool IsLocalObserverFinishedMatch()
	{
		return false;
	}

	public bool IsLocalPlayerFinishedMatch()
	{
		return false;
	}

	public void EndObserver(bool needLog = true)
	{
	}

	public void SendQuitRequest(EQuitGameReason reason = EQuitGameReason.Normal)
	{
	}

	public virtual void SendQuitFakeBotRequest()
	{
	}

	public void RequestShowMatchResult()
	{
	}

	public void RoomSpectatorRequestQuitMatch()
	{
	}

	public void FriendObserverRequestQuitMatch()
	{
	}

	public void RequestQuitMatch(EQuitGameReason reason = EQuitGameReason.Normal)
	{
	}

	protected virtual bool IsQuitMatchReturnToLobby()
	{
		return false;
	}

	public virtual void OnQuitMatchToLobby()
	{
	}

	public override bool ShouldClearPreloadAssets(Type nextGameType)
	{
		return false;
	}

	protected ResourceID[] GetPreloadResourceIDByGameMode()
	{
		return null;
	}

	protected ResourceID[] GetPreloadPlayerAnimatorsResourceID()
	{
		return null;
	}

	protected void FilterUnUsedItemRes(ResourceID[] res, ref List<ResourceID> ret)
	{
	}

	protected virtual uint GetPreloadResourceGameMode()
	{
		return 0u;
	}

	protected static int GetMemLevelForPreload()
	{
		return 0;
	}

	public override ResourceID[] GetPreloadResourceIDSeq()
	{
		return null;
	}

	public override ResourceID[] GetPreloadResourceID()
	{
		return null;
	}

	protected void UnloadUnUsedItemResource()
	{
	}

	public virtual bool NeedPoolInstantRes()
	{
		return false;
	}

	protected void PrePoolInstantRes()
	{
	}

	public InGameCutsceneManager GetInGameCutsceneManager()
	{
		return null;
	}

	public void RegisterInGameCutsceneManager(InGameCutsceneManager manager)
	{
	}

	protected override void OnInputUpdate()
	{
	}

	public virtual Player CreatePlayer(Transform container, ulong userID, ulong serviceGroupID, BHGGAEEHJCO playerID, bool isAI = false, object syncInfo = null)
	{
		return null;
	}

	public virtual void OnAddPlayer(Player p)
	{
	}

	public virtual void OnDelPlayer(Player p)
	{
	}

	public virtual bool IsAimingEnemyInGameMode(bool isAimingEnemy, FOCGJHJOBFE player, OKEAMEELLBB aimTarget)
	{
		return false;
	}

	public virtual bool IsGameAllowFlight()
	{
		return false;
	}

	public virtual bool IsGameShowAllFlight()
	{
		return false;
	}

	public virtual bool IsFriendFire(Player attacker, OKEAMEELLBB victim, bool friendDmgEnable, AGACNOCEEFP weaponData)
	{
		return false;
	}

	public virtual bool CanTakeDamage(Player attacker, OKEAMEELLBB victim, AGACNOCEEFP weaponData)
	{
		return false;
	}

	protected void OnSoundEffectChanged(object[] data)
	{
	}

	public void AddBrokenBehaviorMsg(KMPAHCCABAL msg)
	{
	}

	private void SetPendingBrokenBehaviorMsgList(KMPAHCCABAL msg)
	{
	}

	public bool HasPendingBrokenBehaviorMsg()
	{
		return false;
	}

	public bool HasPendingBrokenBehaviorMsgDirectShow()
	{
		return false;
	}

	public KMPAHCCABAL GetBrokenBehaviorMsg()
	{
		return null;
	}

	public void RemoveOneBrokenBehaviorMsg()
	{
	}

	public void ClearPendingBrokenBehaviorMsg()
	{
	}

	protected void ClearRuntimeStateForNewMatch()
	{
	}

	public virtual bool IsSameTeam(Player p1, Player p2)
	{
		return false;
	}

	public virtual bool IsSameTeam(BHGGAEEHJCO p1, BHGGAEEHJCO p2)
	{
		return false;
	}

	public virtual bool CanSwitchWeapon(Player player)
	{
		return false;
	}

	public virtual bool CanFire(Player player)
	{
		return false;
	}

	public virtual bool NeedUGCUpdateMiniMap()
	{
		return false;
	}

	public virtual bool NeedSaveUGCDataToLocal()
	{
		return false;
	}

	public virtual bool OnUGCHandleCanWeaponHitEntity(string ugcEntityID)
	{
		return false;
	}

	public virtual bool CanFreeQuit()
	{
		return false;
	}

	public virtual bool QuitWithoutRequest()
	{
		return false;
	}

	public virtual bool NeedClientSetOnBoard()
	{
		return false;
	}

	public virtual bool GetOverrideUnlimitedAmmoSetting()
	{
		return false;
	}

	public virtual bool EnableUGCVehicleProperty()
	{
		return false;
	}

	public virtual bool CanPlayerGetOnVehicle()
	{
		return false;
	}

	public virtual bool IsTeamAceKillNotificationOpen()
	{
		return false;
	}

	public virtual ONFBHNEPBCM CurrentLvlAbilityModule()
	{
		return null;
	}

	public DKGFHLKJHHG GetLowGravityAreaManager()
	{
		return null;
	}

	public DHLFCEHOPHH GetHealRobotXRayManager()
	{
		return null;
	}

	public JNPKEGLIEPC GetSpeedScaleGroupInfo()
	{
		return null;
	}

	public virtual bool CanActiveSkillTakeEffect(BHGGAEEHJCO playerID, HBLKLJHFJDK activeSkill, out string errKey)
	{
		errKey = null;
		return false;
	}

	private bool IsUGCDebugGame()
	{
		return false;
	}

	public void TryAddSquareDancingPlayerList(BHGGAEEHJCO playerId)
	{
	}

	public void TryRemoveSquareDancingPlayerInList(BHGGAEEHJCO playerId)
	{
	}

	public Player GetNearestSqaureDancingPlayer(uint emoteID, Vector3 pos)
	{
		return null;
	}

	public void RegisterSquareDancingEmote(uint emoteID)
	{
	}

	public bool IsSquareDancingEmote(uint emoteID)
	{
		return false;
	}

	public void RegisterSquareDancingTrigger(ClientSquareDancingTrigger dancingTrigger)
	{
	}

	public ClientSquareDancingTrigger TryGetSquareDancingTrigger(uint uid)
	{
		return null;
	}

	public void RegisterMusicBox(LevelMusicBox musicBox)
	{
	}

	public LevelMusicBox TryGetLevelMusicBox(uint uid)
	{
		return null;
	}

	public void LoadSlideCsvConfig()
	{
	}

	public void AddArcGenerator(ArcGenerator arc)
	{
	}

	public ArcGenerator FindArcGenerator(int groupID, int number)
	{
		return null;
	}

	public void AddSlideDoorManager(SlideDoorManager door)
	{
	}

	public List<SlideDoorManager> FindSlideDoorManager(uint groupID)
	{
		return null;
	}

	public bool HasEnemyNearby(uint groupID)
	{
		return false;
	}

	public void UpdateSlideEnemyInfo(uint groupID, bool hasEnemy)
	{
	}

	public bool IsEnterSlideScanArea(uint groupID)
	{
		return false;
	}

	public void UpdateSlideScanAreaInfo(uint groupID, bool isEnter)
	{
	}

	public void ClearSlideScanAreaInfo()
	{
	}

	public bool CheckCanCallVehicle(Vector3 position, Quaternion rotation, int vehicleID, uint traceFlag)
	{
		return false;
	}

	public virtual float ReconnectTime()
	{
		return 0f;
	}

	public void TryAddSuperEmotePlayer(BHGGAEEHJCO playerId)
	{
	}

	public void TryRemoveSuperEmotePlayer(BHGGAEEHJCO playerId)
	{
	}

	public void HandleRMDClock(int playBellTime, int checkDistance)
	{
	}

	public void HandleCreateSnackBars(bool eventOpen, bool isDestroy, bool syncMapIcons, List<IHCIMLNDINI> snackbars)
	{
	}

	protected void TryInitAIECAManager(string personaID)
	{
	}

	public virtual void AfterJoinMatchFinish()
	{
	}

	private static KAEJKILJHGC LoadGameTickModuleWithType(MECJOKLINMA moduleType)
	{
		return null;
	}

	protected void PrepareLoadedTickModules(List<MECJOKLINMA> loadedModules)
	{
	}

	private void NotifyTickModulesPreloadAfterJoinRoomFinished()
	{
	}

	private void NotifyTickModulesCleanupForInGameReload()
	{
	}

	private void TickGameModules(float gameTime, float deltaTime)
	{
	}

	public void RequestForceSyncMotionPlatform()
	{
	}

	public void SyncMotionPlatformState(KFNBOGFCCNE msg)
	{
	}

	protected void PreLoadFontTextute()
	{
	}

	private void OnFontTextureResize(Font font)
	{
	}

	private void OnFontTextureClear(Font font)
	{
	}

	private void ResizePushCharactorsToFont()
	{
	}

	private void ClearPushCharactorsToFont()
	{
	}

	private void _003CRoomSpectatorRequestQuitMatch_003Eb__145_0()
	{
	}

	private void _003CRequestQuitMatch_003Eb__147_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_NotUsingAB()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetSceneABInfo(AssetBundle P0, bool P1, string P2, string P3)
	{
	}

	public void _003C_003EiFixBaseProxy_SetScenePatchABInfo(Dictionary<int, List<CFIJFGBBLON>> P0)
	{
	}

	public string _003C_003EiFixBaseProxy_GetSceneStreamABPath()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetSceneABPath()
	{
		return null;
	}

	public AssetBundle _003C_003EiFixBaseProxy_GetStreamSceneAB()
	{
		return null;
	}

	public Dictionary<int, List<CFIJFGBBLON>> _003C_003EiFixBaseProxy_GetStreamScenePatchAB()
	{
		return null;
	}

	public byte[] _003C_003EiFixBaseProxy_GetStreamSceneABTexRefInfo()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUnInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnLateUpdate()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitWithInGameReload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUnInitWithInGameReload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate()
	{
	}

	public bool _003C_003EiFixBaseProxy_ShouldClearPreloadAssets(Type P0)
	{
		return false;
	}

	public ResourceID[] _003C_003EiFixBaseProxy_GetPreloadResourceIDSeq()
	{
		return null;
	}

	public ResourceID[] _003C_003EiFixBaseProxy_GetPreloadResourceID()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnInputUpdate()
	{
	}
}
