using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIMapContentController : UIBaseController, IUIModelDataChangeObserver
{
	private class EnermyPointObject
	{
		public GameObject PointObject;

		public BHGGAEEHJCO EnermyID;

		public int ServerEndTime;
	}

	public enum EIconType
	{
		EIconType_InGameShop,
		EIconType_RevivePoint
	}

	private class DeliveryEnermyPointObject
	{
		public GameObject PointObject;

		public BHGGAEEHJCO EnermyID;

		public int ServerEndTime;

		public bool Marked;

		public void Reset()
		{
		}
	}

	private struct FateRandomRevivePositionObject
	{
		public UISprite PointSprite;

		private GameObject m_PointObject;

		public GameObject PointObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Reset()
		{
		}

		public void SetColor(bool isTeammate)
		{
		}
	}

	private class RevivePointIconState
	{
		public Vector3 Pos;
	}

	private class ScanLevelObjIcon
	{
		public GameObject icon;

		public uint delayCallID;
	}

	private class ScanVehicleIcon
	{
		public GameObject icon;

		public uint delayCallID;

		public uint vehicleID;
	}

	private class WLGP25_DebugIslandMoveLine
	{
		public List<GameObject> safeZoneObjs;

		public List<GameObject> pointObjs;

		public List<GameObject> lineObjs;

		public void Clear()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__818_0;

		public static Comparison<string> _003C_003E9__935_0;

		internal void _003COnDetectiveMarkEnemy_003Eb__818_0()
		{
		}

		internal int _003CGetMapLegendData_003Eb__935_0(string x, string y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass316_0
	{
		public UIMapContentController _003C_003E4__this;

		public UISprite s;

		internal void _003COnChangeIconSprite_003Eb__0(UIAtlas atlasRes, string spriteName)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass404_0
	{
		public UIMapContentController _003C_003E4__this;

		public uint playerIDCopy;

		internal void _003COnTeamRallyCooldownSync_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass500_0
	{
		public UIMapBossZoneView bossZoneIcon;

		internal void _003CSyncBossZone_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass629_0
	{
		public UIMapContentController _003C_003E4__this;

		public uint id;

		internal void _003COnUpdateOniBoss_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass637_0
	{
		public uint uid;

		internal bool _003COnTeleportDoorStateChanged_003Eb__0(TeleportDoorHintInfo e)
		{
			return false;
		}

		internal bool _003COnTeleportDoorStateChanged_003Eb__1(TeleportDoorHintInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass641_0
	{
		public MaxHypePlayerHint hint;

		internal void _003CShowMaxHypePlayerShooting_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass698_0
	{
		public UIMapContentController _003C_003E4__this;

		public uint reqId;

		public Vector3 reqPos;

		internal void _003COnShowBTTeleportOnMap_003Eb__0(uint t, bool ok, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass701_0
	{
		public UIMapContentController _003C_003E4__this;

		public uint reqId;

		public Vector3 reqPos;

		internal void _003COnShowBTIslandEntryOnMap_003Eb__0(uint t, bool ok, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass734_0
	{
		public UIMapContentController _003C_003E4__this;

		public KEEFMGKKFBO marker;

		internal void _003COnShowCSMark_003Eb__0()
		{
		}

		internal void _003COnShowCSMark_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass816_0
	{
		public UIMapContentController _003C_003E4__this;

		public BHGGAEEHJCO markedByPlayerID;

		internal void _003COnShowLevelObjScan_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass836_0
	{
		public UIHudMapBuffECAExposurePosController ctrl;

		public UIMapContentController _003C_003E4__this;

		public BHGGAEEHJCO id;

		internal void _003CShowBuffECAExposurePos_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass871_0
	{
		public UIMapContentController _003C_003E4__this;

		public ScanVehicleIcon iconData;

		internal void _003CShowVehiclChipScanPos_003Eb__0()
		{
		}
	}

	private sealed class _003CCreateItemGenerator_003Ed__620 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<LevelObjectItemGenerator> data;

		public UIMapContentController _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCreateItemGenerator_003Ed__620(int _003C_003E1__state)
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

	private sealed class _003CWaitToUpdateSafeZoneCircleShow_003Ed__756 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMapContentController _003C_003E4__this;

		public bool show;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitToUpdateSafeZoneCircleShow_003Ed__756(int _003C_003E1__state)
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

	public const uint VISIBILITY_STATE_FloatingLand = 1073741824u;

	private UIMapContentView m_View;

	private Player m_Player;

	private Vector3 m_Center;

	protected UIMapUtil.MapOffsetContext m_MapOffsetContext;

	public static float SIZE_MAP_PIXEL_X;

	public static int UPDATE_INTERVAL_FRAME_COUNT;

	public float SIZE_MAP_PIXEL_Y;

	public float ZONE_DIAMETER;

	public float ZONE_DIAMETER_MAP;

	private float SIZE_MAP_X;

	private float SIZE_MAP_Z;

	private float OFFSET_SCALE_RATIO_X;

	private float m_rotz;

	private float m_peoplerotz;

	private const float BIG_MAP_MARK_SCALE = 0.75f;

	private const int DarkCircleHeight = 120;

	private const int DarkCircleWidth = 120;

	private GameObject m_LocalMapMark;

	private UIHudPlayerMarkController m_LocalMapMarkController;

	private UIBigMapObEventController m_ObEventController;

	private float MOVE_SENSITIVITY;

	private Dictionary<BHGGAEEHJCO, float> m_TeammateMapMarkScale;

	private List<UIArcGeneratorLineController> m_AIrcGeneratorLineCtrls;

	private const float m_MiniMapTeammateMarkIconScale = 0.55f;

	private Dictionary<int, UIHudPlayerMarkIcon> m_MiniMapTeammateMarkIcons;

	private Dictionary<BHGGAEEHJCO, UIHudPlayerMarkController> m_TeammateMapMarkDict;

	private Dictionary<BHGGAEEHJCO, TeammateGameObject> m_TeammatesMap;

	private Dictionary<BHGGAEEHJCO, UIHudRoomOBPlayerMapIconController> m_RoomOBPlayerMapIcons;

	private List<BHGGAEEHJCO> m_RoomOBPlayerMapIconRemoveBuffer;

	private Dictionary<uint, uint> m_TeamRallyDelayCallMap;

	private readonly List<UIManagedMapContentIconController> m_ManagedMapContentIcons;

	private readonly List<int> m_TmpMarkedForDeletedMapContentIcons;

	private readonly Dictionary<uint, UIManagedLevelObjectMapIconController> m_ManagedLevelObjectMapIcons;

	private readonly Dictionary<uint, BHGGAEEHJCO> m_ReviveBoxMapIconPlayers;

	private readonly Dictionary<BHGGAEEHJCO, int> m_ReviveBoxMapIconPlayerCounts;

	private Dictionary<BHGGAEEHJCO, List<UIHudRoutePlanningMapMarkerController>> m_RoutePlanningMarkers;

	private Dictionary<uint, ScanByTypeResultData> m_ScanByTypeResults;

	private Dictionary<BHGGAEEHJCO, MapUIDeadBox> m_DeadBoxMap;

	private Dictionary<uint, GameObject> m_CampFireDict;

	private Dictionary<uint, GameObject> m_CarePackageDict;

	private Dictionary<uint, GameObject> m_WereWolvesTaskDict;

	private Dictionary<uint, GameObject> m_WereWolvesEmergencyTaskDict;

	private Dictionary<BHGGAEEHJCO, GameObject> m_ZombieDict;

	private Dictionary<BHGGAEEHJCO, GameObject> m_ZombieBossDict;

	private Dictionary<uint, GameObject> m_PumpkinDict;

	private Dictionary<BHGGAEEHJCO, PlayerPumpkinInfo> m_PumpkinHighScoreDict;

	private EBigMapType m_BigMapType;

	private Dictionary<uint, GameObject> m_HotzoneObjects;

	private List<UIHudBloodmoon_GP_MapIconController> m_BloodmoonGPMapCache;

	private Dictionary<uint, UIRevivePointMapIconController> m_RevivePointIcons;

	private Dictionary<uint, UITeamGatherPointMapIconController> m_TeamGatherPointIcons;

	private Dictionary<uint, GameObject> m_ReviveChestIcons;

	private Dictionary<uint, BTFishMapIcon> m_BTFishingPoolIcons;

	private Dictionary<uint, GameObject> m_BTTeleportIcons;

	private uint m_BTIslandEntryID;

	private GameObject m_BTIslandEntry;

	private List<Vector3> m_ShopPoslist;

	private List<UIShopPointMapIconController> m_ShopPointIcons;

	private Dictionary<uint, UIShopPointMapIconController> m_ShopPointIconByShopID;

	private bool m_HasPlayedPOIMissionMapIconVfx;

	private List<uint> m_POIMissionMapIconVfxIDs;

	private List<UIStropPointMapIconController> m_StropPointIcons;

	private Vector3 m_HGEndPointPos;

	private GameObject m_HGEndPoint;

	private List<UIHudCSGameZoneView> CSGameZone;

	private Dictionary<uint, UIHudEnergyDeviceMapItemController> m_EnergyDeviceIcons;

	private Dictionary<uint, UILockAirDropIconController> m_LockAirDropIcons;

	private Dictionary<uint, UIMapContenBigItemIconController> m_BigItemIcons;

	private List<UIHud2NBGPMapContentBloodMoonIconController> m_2NBGPBloodMoonIcons;

	private Dictionary<uint, UIHud2NBGPMapContentBloodMoonAirdropIconController> m_2NBGPBloodMoonAirdropIcons;

	private Dictionary<uint, UIMapContentHiraishinIconController> m_HiraishinIcons;

	private Dictionary<uint, UIHudTreasuryMapItemController> m_TreasuryPointIcons;

	private Dictionary<uint, UIHudSFRoleplayNotebookMapItemController> m_NotebookPointIcons;

	private Dictionary<ulong, UIHudMapThrowerMapIconView> m_MapThrowerIcons;

	private Dictionary<uint, UIhudTreasureHuntMapIconView> m_TreasureHuntUnderTreasuryIcons;

	private Dictionary<uint, UIhudTreasureHuntMapIconView> m_TreasureHuntNormalTreasureIcons;

	private UIHudMapThrowerSelectWndController m_MapThrowerSelectWndCtrl;

	private UIHudMapAstrolGateWndController m_MapAstrolGateSelectWndCtrl;

	private Dictionary<uint, UIMapAstrolGateIconController> m_AstrolGateIcons;

	private UIHudMapCatapultLaunchLineView m_MapCatapultLaunchLineObj;

	private Vector3 m_CatapultHitPosition;

	private Queue<UIHudMapThrowerMapIconView> m_MapThrowerQueue;

	private Dictionary<uint, UIHudCyberMushroomScanItemController> m_CyberMushroomScans;

	private Queue<UIHudItemGeneratorController> m_ItemGeneratorCache;

	private Dictionary<uint, UIHudItemGeneratorController> m_ItemGenerators;

	private Dictionary<uint, GameObject> m_TreasureMarks;

	private Dictionary<uint, GameObject> m_TreasuryMarks;

	private Dictionary<uint, GameObject> m_WishingTreeMarks;

	private Dictionary<uint, GameObject> m_OniZoneMarks;

	private Dictionary<uint, GameObject> m_OniBossMarks;

	private Dictionary<uint, UIHudGeneralConstructionMapItemController> m_GeneralConstructionMarks;

	private GameObject m_OniBirdMark;

	private Dictionary<uint, GameObject> m_EnergyStoneBoxObjects;

	private Dictionary<uint, UIMapBossZoneView> m_BossZoneObjects;

	private Dictionary<uint, UISprite> m_InstrumentIcons;

	private Dictionary<string, GameObject> m_ActiveSupplyBoxTriggerObjects;

	private List<GameObject> m_SupplyBoxTriggerObjectsPool;

	private List<GameObject> m_BuffHintMarks;

	private List<GameObject> m_FateRandomZones;

	private Dictionary<uint, GameObject> m_RmdSnackBars;

	private Dictionary<uint, UIHudBombZoneView> m_BombZones;

	private Dictionary<uint, UIHudReviveMissionMarkController> m_ReviveMissionMarks;

	private Dictionary<uint, UIHudMetropolisMapAreaIconController> m_MetropolisAreaIcons;

	private Dictionary<uint, UIHudTokenMachineMapMark> m_TokenMachineIcons;

	private Dictionary<uint, VisualInstanceHolder> m_IIVCursedEnergyIcons;

	private Dictionary<uint, UIHudShibuya_GP_DoorIconController> m_IIVTeleportDoorIcons;

	private Dictionary<uint, UIHudSeafoodCookieShopMapMark> m_SeafoodCookieShopIcons;

	private Dictionary<uint, UIHudSeafoodLittleGirlMapMark> m_SeafoodLittleGirlIcons;

	private Dictionary<uint, UIHudSeafoodGlassBridgeMapMark> m_SeafoodGlassBridgeIcons;

	private Dictionary<uint, UIHudInfiniteCakeMapMark> m_InfiniteCakeIcons;

	private Dictionary<uint, UIHudPOIMissionMapIconController> m_POIMissions;

	private UIHudMapKingClownController m_KingClownController;

	private uint m_ShowKingDelayCallID;

	private uint m_KingClownTicket;

	private BHGGAEEHJCO m_KingClownPlayerId;

	private float m_KingClownTime;

	private Vector3 m_KingClownPos;

	private Dictionary<uint, EnermyPointObject> m_CSPickupBuffDetectEnemies;

	private Queue<GameObject> m_CSPickupBuffDetectPointCache;

	private uint m_DefaultGeekSpiderId;

	private List<uint> m_GeekSpiderIconGoKeys;

	private Dictionary<uint, GameObject> m_GeekSpiderIconGos;

	private Dictionary<uint, LevelAutoPathBomb> m_GeekSpiderIconData;

	private Dictionary<uint, UIHudMapBuffECAExposurePosController> m_BuffECAExposurePosDict;

	private Queue<UIHudMapBuffECAExposurePosController> m_BuffECAExposurePosCache;

	private Stack<GameObject> m_GeekSpiderIconGoPool;

	private Dictionary<uint, UIHudLockBountyVehicleMapItem> m_LockBountyVehicleIcons;

	private List<GameObject> m_BountyBoxIcons;

	private Dictionary<uint, UIHudIceSculptureMapItemController> m_IceSculptureMarks;

	private Dictionary<uint, UIPetSkillBigMapRangeController> m_PetSkillRangeDict;

	private Dictionary<uint, List<UIHotPursuitBigMapRangeController>> m_HotPursuitScanDict;

	private Queue<UIHotPursuitBigMapRangeController> m_HotPursuitScanCache;

	private List<GameObject> m_CabinMapObj;

	private List<GameObject> m_WeRunRetreatPointIcons;

	private List<UISprite> m_WeRunRetreatPointSprites;

	private List<Vector3> m_WeRunRetreatPointIconsRealPos;

	private Dictionary<uint, GameObject> m_HippoCrisisBoxIcons;

	private Dictionary<uint, List<uint>> m_HippoCrisisBoxDrops;

	private Dictionary<uint, UIHudMissionMachineMapInfoController> m_MissionMachineInfos;

	private UIHudHypercrateMapInfoController m_HypercrateInfo;

	private UIHUDSFRoleplayMapGhostCircleController m_GhostCircleController;

	private Dictionary<BHGGAEEHJCO, GameObject> m_SummonerActionIcons;

	private Dictionary<BHGGAEEHJCO, GameObject> m_SummonerActionArrowIcons;

	private Dictionary<BHGGAEEHJCO, Vector3> m_SummonerActionIconsRealPos;

	private Queue<GameObject> m_SummonerActionIconsCache;

	private MapContentWinterlandIconController m_WinterlandIcon;

	private MapContentWinterlandMoveLineController m_WinterlandMoveLine;

	private Dictionary<uint, GameObject> m_RevivePointBuffShopIcons;

	private Dictionary<uint, uint> m_RevivePointBuffShopIconIDToTickets;

	private Dictionary<uint, Vector3> m_RevivePointIDToPos;

	private UIHudBombZoneView m_ControllZone;

	private bool m_ShowUGCFactionUI;

	private Color BOMB_ZONE_NO_BOMB;

	private Color BOMB_ZONE_HAS_BOMB;

	private Vector3 m_ZeppelinCurPos;

	private Vector3 m_ZeppelinNextPos;

	private bool m_UpdateZeppeline;

	private DeliveryEnermyPointObject m_DeliverySkillMarkEnemyPoint;

	private Dictionary<BHGGAEEHJCO, EnermyPointObject> m_SlowDownMarkEnemyPointDict;

	private Dictionary<BHGGAEEHJCO, FateRandomRevivePositionObject> m_FateRandomRevivePositionDict;

	private Queue<GameObject> m_AirDropCache;

	private Dictionary<uint, GameObject> m_AirDropDict;

	private Queue<GameObject> m_AirDropVariantCache;

	private Dictionary<uint, bool> m_AirDropVariantStates;

	private Queue<GameObject> m_AirDropSignalFlareCache;

	private Dictionary<uint, GameObject> m_AirDropSignalFlareDict;

	private Queue<GameObject> m_CampFireCache;

	private Queue<GameObject> m_CarePackageCache;

	private bool m_HasClearLockAirDropIcon;

	private Queue<GameObject> m_WereWolvesTaskCache;

	private Queue<GameObject> m_WereWolvesEmergencyTaskCache;

	private List<GameObject> m_BombCache;

	private List<UIHudMapBomberMakerRangeController> m_BomberMakerCache;

	private List<UIHudCarni25MusicBombMapRangeController> m_Carni25MusicBombCache;

	private List<UIHudThunderStormBombMapRangeController> m_ThunderStormBombCache;

	private Queue<GameObject> m_ZombieCache;

	private Queue<GameObject> m_ZombieBossCache;

	private Queue<GameObject> m_EnermyPointCache;

	private Queue<GameObject> m_PumpkinCache;

	private Queue<GameObject> m_SlowDownPointCache;

	private Queue<FateRandomRevivePositionObject> m_FateRandomRevivePositionCache;

	private Queue<PlayerPumpkinInfo> m_PumpkinHighScoreCache;

	private List<GameObject> m_ToxicCache;

	private bool m_ToxicZoneDirty;

	private Dictionary<BHGGAEEHJCO, MaxHypePlayerHint> m_RevengeMarkMap;

	private Queue<GameObject> m_RevengeMarkCache;

	private Dictionary<BHGGAEEHJCO, MaxHypePlayerHint> m_MaxHypePlayerDic;

	private Queue<GameObject> m_MaxHypePlayerCache;

	private Queue<GameObject> m_GeneratedItemCache;

	private Dictionary<uint, GeneratedItemHint> m_GeneratedItemDic;

	private Dictionary<int, List<TeleportDoorHintInfo>> m_TeleportDoors;

	private List<GameObject> m_TrainingAroundEnermyPoints;

	private List<UISprite> m_TeammateSprites;

	private Vector3 m_InnerCenterPos;

	private Vector3 m_InnerZoneScale;

	private Queue m_QueueDeadTeammates;

	private List<UavMapObject> m_UAVObjects;

	private UIUAVMapObjectView m_PreInstantiatedUAVObjectView;

	private List<CSRoundDragonMapObject> m_CSRoundDragonObjects;

	private MiniMapPermanentScan m_PermanentScan;

	private BountyScannerMapObject m_BountyScanner;

	private DetectorMapObject m_Detector;

	private SearchMapObject m_SearchMapObject;

	private float m_BigMapSliderValue;

	public float m_MapContainerScale;

	public float m_MapPanelScale;

	private Vector3 m_MapIconScale;

	private Vector3 m_MapIconScaleOfPlayerArrow;

	private Vector3 m_MapIconScaleOfTeammateArrow;

	private Quaternion m_MapIconRotation;

	private Vector3 m_SafeZoneChooseRegionCenter;

	private const float mc_fBigMapPlayerArrowExScale = 1.4f;

	private const float mc_fBigMapTeamArrowExScale = 1.3f;

	private float m_CurrentScaleRatio;

	private Vector3 m_BigmapScaleMin;

	public UIMapUtil.EMapType MapType;

	private float m_ClipHeight;

	private float m_ClipWidth;

	private Dictionary<GameObject, bool[]> m_ObjectGroupSetting;

	private SafeZone m_CurrentSafeZone;

	private bool m_CurrentSafeZoneRect;

	private bool m_BombPositionInited;

	private List<UISprite> m_ReaperPlayerFlag;

	private List<float> m_quadrantLength;

	private List<Vector3> m_quadrantPoint;

	private List<GameMissionPlayerRangeObject> m_PlayerRangeObjects;

	private Dictionary<BHGGAEEHJCO, GameObject> m_BanHighZoneEnemiesMap;

	private Queue<GameObject> m_BanHighZoneCache;

	private List<GameObject> m_DetectiveMarkPoints;

	private Dictionary<uint, GameObject> m_MarkPointsByCyberMushroom;

	private Dictionary<uint, float> m_MarkPointsByCyberMushroomDisappearTime;

	private Dictionary<uint, GameObject> m_DetectiveMarkPointsByTBD;

	private Dictionary<uint, float> m_DetectiveMarkPointsDisappearTime;

	private Dictionary<uint, GameObject> m_DetectiveEffectByTBD;

	private Dictionary<uint, float> m_DetectiveEffectDisappearTime;

	private List<GameObject> m_PointObjPool;

	private List<GameObject> m_DetectiveEffectObjPool;

	private UITexture m_SafeZoneTargetBg;

	private bool m_UGCSafeZoneDirty;

	private Material m_LastKnownSafeZoneDynMat;

	private bool m_IsReplayMode;

	private Material m_SafeZoneMat;

	private List<uint> m_TmpList;

	private UIHudMapContentAreaNamesView m_AreaNamesView;

	private ResourceID m_AreaNameResID;

	private UITexture m_SafeZoneMask;

	private IBKPOGGBIEA m_BombManager;

	private bool m_HasPlayerRangeObjects;

	private bool m_HasDeathMatchKillerKing;

	private bool m_ShowGuideToSafeZone;

	private bool m_IsGameSafeZoneIgnoreFirstOne;

	private EAirWallMapEnum m_AirWallMapIndex;

	private GameObject airWallMapGo;

	private UIMiniMapAirWall m_AirWallMap;

	private Dictionary<uint, UIMapObjectRadarView> radarViews;

	private Dictionary<uint, UIMapObjectMapScanView> mapScanViews;

	private uint m_MapId;

	private bool m_ShowNewTag;

	private UIMapSpeicalSafeZoneInfoView m_SpeicalSafeZoneInfoView;

	private bool m_IsRankShowJumpSuggest;

	private Color m_SuggestJumpNormalColor;

	private Color m_SuggestJumpOverRatioColor;

	private bool m_IsOverSuggestJumpRatio;

	private bool m_IsReachSuggestJumpRatio;

	private Action m_MapOffsetUpdateCallback;

	private uint m_AsyncLoadTicket;

	private Dictionary<string, UISprite> m_WorkShopItemIconMap;

	private Queue<UISprite> m_WorkShopItemIconCache;

	private Vector4 m_CacheLastSafeZonePos;

	private Vector2 m_CacheLastSafeZoneRadius;

	private UISprite m_CheckPointIcon;

	private bool m_SafeZoneMoveVFXInit;

	private Vector3 m_ReplayAirLineStartMapPos;

	private Vector3 m_ReplayAirLineEndMapPos;

	private Vector3 m_ReplayAirLineRot;

	private bool m_bIsUpdateAircraft;

	private bool m_NeedInitAircraft;

	private Vector3 m_airlineOffset;

	private float m_airlineResidueOriWidth;

	private int m_nMaintex_ST_PropID;

	private UIMapAirLineCurveController m_UIAirLineCurve;

	private bool m_bIsInitAirLineAlphaByUserState;

	private Dictionary<BHGGAEEHJCO, Vector3> playerPos;

	private Dictionary<BHGGAEEHJCO, float> playerAngle;

	private const string DefaultPlayerArrowName = "UI_minimap_icon_outset";

	private Vector2 DefaultPlayerArrowSize;

	private UIHudMapPlayerArrowScoutDrivingView m_LocalPlayerScoutDriving;

	private bool m_IsPlayerArrowScoutDriving;

	private Dictionary<BHGGAEEHJCO, UIHudMapScoutView> m_3PScouts;

	private List<BHGGAEEHJCO> m_3PScoutCachedPlayerIDs2Remove;

	private float m_UGC_MapMin_Scale;

	private Vector3 m_UGC_MapCenter_Offset;

	private float m_HippoCrisis_MapMinScale;

	private Vector3 m_HippoCrisis_MapCenterOffset;

	private float m_BigItemIconShowTime;

	private float m_BigItemIconFlashTime;

	private bool m_BigItemIconShow;

	private bool m_bigItemIconPosUpdate;

	private uint m_AroundEnemyDelayCall;

	private List<GameObject> m_goMarkRedPoint;

	private ResourceID m_mocoMarkPointResID;

	private int m_nUpdateMarkTick;

	private VisualInstanceHolder m_MapThrowerUIFXHolder;

	private VisualInstanceHolder m_MapThrowerPromptUIFXHolder;

	private IEnumerator CreateItemGeneratorsCO;

	private EGLBJPBPGIH m_CyberMushroomScoutEvent;

	private uint m_CandyHotZoneDelayCallID;

	private Dictionary<uint, UIHUDTrainStationMapIconController> m_StationIconMap;

	private Dictionary<uint, uint> m_RevivePointIDToTickets;

	private Dictionary<uint, RevivePointIconState> m_RevivePointIDToState;

	private Dictionary<uint, Transform> m_csMarkPoints;

	private int m_csMarkRange;

	private List<GameObject> m_DebugSafeZoneList;

	private int m_DebugSafeZoneCount;

	private UILabel m_DebugSafeZoneCountLabel;

	private Dictionary<uint, MiniMapMaskData> m_dictIdToMiniMapMaskData;

	private static int SpecificMapBGResultion;

	private UIPanel _003CParentPanel_003Ek__BackingField;

	private Dictionary<uint, ScanLevelObjIcon> m_ScanLevelObjIconDic;

	private Queue<GameObject> m_LevelObjScanEffect;

	private uint m_TeamScanDelayCallID;

	private const float ORIGIN_DETECTIVE_EFFECT_SHOWTIME = 0.8f;

	private Dictionary<int, GameObject> m_TrapIconMap;

	private GameObject m_FloatingLandMap;

	private Material m_SafeZoneTargetDefaultMaterial;

	private Dictionary<uint, ScanVehicleIcon> m_ScanVehicleIconDic;

	private Queue<GameObject> m_ScanVehicleIconPool;

	private uint hideVehicleScanRangeDelayCallID;

	private float m_CachedMapRotZ;

	private VisualInstanceHolder m_DarkCircleOpenVfx;

	private VisualInstanceHolder m_WeakDarkCicleVFX;

	private uint m_WeakVFXDelayCallTime;

	private VisualInstanceHolder m_changeSafeZoneVfx;

	private Dictionary<uint, UISensorBeaconMapScanController> m_SensorBeaconMapScanCtrls;

	private List<uint> m_SensorBeaconsToRemoveCache;

	private WLGP25_DebugIslandMoveLine m_WLGP25_DebugIslandMoveLine;

	private bool m_HasExtraMap;

	private bool m_IsBlueTearsMap;

	private float m_RefreshLegendTime;

	private List<string> m_MapLegendList;

	private HashSet<string> m_ToggleHideIcons;

	private List<GameObject> m_GoListCache;

	public float MapScale => 0f;

	public bool ShowNewTag => false;

	public UIPanel ParentPanel
	{
		get
		{
			return _003CParentPanel_003Ek__BackingField;
		}
		set
		{
			_003CParentPanel_003Ek__BackingField = value;
		}
	}

	private void UpdateShowWinterlandIcon()
	{
	}

	public UIHudMetropolisMapAreaIconController GetMetropolisAreaIcon(uint areaID)
	{
		return null;
	}

	public void SelectMetropolisArea(uint areaID, bool selected)
	{
	}

	public void TrackMetropolisArea(uint areaID)
	{
	}

	public void HideMetropolisMarking()
	{
	}

	public void RegisterMapOffsetUpdateCallback(Action callback)
	{
	}

	public void SetRot(float rotation)
	{
	}

	public void SetPeopleRot(float rotation)
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	public override void OnRecyle()
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	public override void Hide()
	{
	}

	private void RefreshPanelSelfIntervalFrame()
	{
	}

	private bool IsEnableWorkShopMap()
	{
		return false;
	}

	private bool ShouldUpdateBigMapGuideToMark()
	{
		return false;
	}

	private bool TryGetIntersectPoint(Vector3 a, Vector3 b, Vector3 c, Vector3 d, out Vector3 intersectPos)
	{
		intersectPos = default(Vector3);
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	private void InitSpritesForSpecialMode()
	{
	}

	public UIWidget GetMapBgWidget()
	{
		return null;
	}

	private void InitMapTexture()
	{
	}

	public void ChangeToDefaultMapTexture(object[] data)
	{
	}

	public void RefreshAllowPOIDisplayInfo()
	{
	}

	private void EnsureAreaNamesView(ResourceID areaNameRes)
	{
	}

	private void DestroyAreaNamesView()
	{
	}

	private void OnPOIDisplayInfoChanged()
	{
	}

	private void OnPOIDisplayPhysicsStateChange(GEvent data)
	{
	}

	private void RefreshPOIDisplayInfo()
	{
	}

	public void OnShowRMDSnackBars(object[] data)
	{
	}

	private void OnUpdateMapTexture(object[] data)
	{
	}

	private void ChangeMapMainTexture(Texture texture)
	{
	}

	private void OnOnlyChangeMapTexture(object[] data)
	{
	}

	private void OnlyChangeMapTextureByResID(ResourceID resID)
	{
	}

	private void OnRemoveMapAreaName(object[] data)
	{
	}

	private void OnClipMapBgTexture(object[] data)
	{
	}

	private void OnMapBGLoaded(uint ticket, bool success, UnityEngine.Object resource)
	{
	}

	private void OnAddOrDeleteUGCMiniMapIcon(object[] data)
	{
	}

	private void OnChangeIconSprite(object[] data)
	{
	}

	private void InitWorkShopSafeZoneMask()
	{
	}

	private void OnEradicateZoneChange(object[] data)
	{
	}

	public bool CheckUGCSafeZoneDirty(Vector3 outerC, float outerR, Vector3 innerC, float innerR)
	{
		return false;
	}

	private void UpdateEradicateZone()
	{
	}

	private void UpdateUGCIcon()
	{
	}

	private void OnWorkshopMapRefresh(object[] data)
	{
	}

	private void RefreshWorkshopMapTexture()
	{
	}

	private void RefreshAllWorkshopMapIcons()
	{
	}

	private UISprite InstantWorkshopIconItem(uint itemID, Vector3 pos)
	{
		return null;
	}

	private void OnCheckPointChange(object[] data)
	{
	}

	private void OnWorkShopSceneRefresh(object[] data)
	{
	}

	private void RefreshWorkshopMapIcon(string id, Vector3 pos, ResourceID iconRes, uint itemID)
	{
	}

	private void RemoveWorkshopMapIcon(string id)
	{
	}

	private void SetWorkShopBg()
	{
	}

	private void OnMapOffsetUpdate(object[] data)
	{
	}

	private void SetMapOffsetContext(Vector4 offset)
	{
	}

	private void CommonReInitWhenMapOffsetUpdate()
	{
	}

	private void MapOffsetUpdateCallBack()
	{
	}

	private void UpdateAstrolGateSelectWnd()
	{
	}

	protected void RegisterEvents()
	{
	}

	protected void UnRegisterEvents()
	{
	}

	protected void InitMapOffsetContext(uint serverMapID)
	{
	}

	public void InitForReplay(uint mapID, uint mapLayerID = 0u)
	{
	}

	private void HideReplayIrrelevantNodes()
	{
	}

	private static void HideReplayNode(GameObject gameObject)
	{
	}

	private static void HideReplayNode(Component component)
	{
	}

	private void ClearReplayInGamePlayerMarks()
	{
	}

	public bool IsSafeZoneDrawCallReady()
	{
		return false;
	}

	public void ShowReplaySafeZone(Vector3 outerCenter, float outerRadius, Vector3 innerCenter, float innerRadius)
	{
	}

	public void HideReplaySafeZone()
	{
	}

	public void ShowReplayAirLine(Vector3 startWorld, Vector3 endWorld)
	{
	}

	public void HideReplayAirLine()
	{
	}

	public void UpdateReplayAirLineAircraft(float t)
	{
	}

	protected void UpdateMapOffsetContext(Vector4 offset)
	{
	}

	public UIMapUtil.MapOffsetContext GetMapOffsetContext()
	{
		return null;
	}

	private void InitUIParams()
	{
	}

	private void InitUIElements()
	{
	}

	public void InitObEventController()
	{
	}

	public bool IsEventIcon(GameObject go)
	{
		return false;
	}

	private bool ShowAllGameZone()
	{
		return false;
	}

	private void RefreshPlayerArrow()
	{
	}

	public Vector3 GetPlayerArrowLocalPosition()
	{
		return default(Vector3);
	}

	private void OnShowAirWall(object[] data)
	{
	}

	public static Vector3 MultiplyByComponent(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	public void MoveMapToPosition(Vector3 pos, float f)
	{
	}

	private Vector3 GetZoomInFinalPosition()
	{
		return default(Vector3);
	}

	public void MoveMapOnSliderChange(float f)
	{
	}

	public void SetNewLabelActive(bool show)
	{
	}

	public void RefreshUIGroup()
	{
	}

	public bool ModeRelatedMinimapScale()
	{
		return false;
	}

	public void InitBountyScanner(UIPanel panel = null)
	{
	}

	public void UpdateLocalMark(Vector3 p, uint posType, Vector3 realPos, EBigMapType bigMapType = EBigMapType.MapTypeNormal)
	{
	}

	public void RemoveMarkOnMap()
	{
	}

	private void InitShowJumpSuggestFlag()
	{
	}

	private void ShowJumpSuggestPos(Vector3 markWorldPos, Vector3 markMapPos)
	{
	}

	public bool GetJumpSuggestNearestPoint(Vector3 pointA, Vector3 pointB, Vector3 circlePosition, float circleRadius, ref Vector3 min, ref Vector3 max, ref float t)
	{
		return false;
	}

	private void UpdateJumpSuggestPos(Vector3 targetPos, Vector3 markMapPos, bool isCurveAirline)
	{
	}

	private void UpdateSuggestJumpPosView()
	{
	}

	public void OnPlayerHPChangedBigMap(GEvent data)
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	private void OnReEnterSyncPlayerDeadBox(object[] data)
	{
	}

	private void ShowPlayerDeadBox(uint playerId, Vector3 pos, float createGameTime = 0f)
	{
	}

	public void OnPlayerQuit(object[] data)
	{
	}

	private void OnInfoBoxDataNtf(object[] data)
	{
	}

	private void OnInfoBoxValid(bool data)
	{
	}

	private void OnInfoBoxValidInternal(bool data, bool data2)
	{
	}

	private void OnGameGlobalMissionSafeZoneValid(bool valid)
	{
	}

	private void OnGameGlobalMissionSafeZoneChanged(object[] data)
	{
	}

	public void DeActiveSafeZoneChooseMask()
	{
	}

	internal void ShowSafeZoneChooseMask(NBBLCLAMOEJ.IGCKMAPHNEL data, Vector4 maskColor)
	{
	}

	private void OnTechBuildSafeZoneValid(bool valid)
	{
	}

	private void OnTechBuildSafeZoneValidInternal(bool valid, bool sound)
	{
	}

	private void OnTechBuildSafeZoneChanged()
	{
	}

	public void SyncTeamateState(object[] data)
	{
	}

	public Vector3 ChangePosToLocalPos(Vector3 pos1)
	{
		return default(Vector3);
	}

	public void CheckTeamInMap(TeammateGameObject go, Vector3 teammatepos, int index, BHGGAEEHJCO playerId)
	{
	}

	private void SetDir(TeammateGameObject go, int index, Vector3 jiaopos, float rotz, BHGGAEEHJCO playerId)
	{
	}

	public bool CheckHasJiao(Vector3 pos1, Vector3 pos2, Vector3 pos3, Vector3 pos4, Vector3[] spriteWorldCorners, out Vector3 jiaopos)
	{
		jiaopos = default(Vector3);
		return false;
	}

	private bool IsPointInCircle(Vector3[] corners, Vector3 p)
	{
		return false;
	}

	public void PlayTeammateQuickChatEffect(uint playerID)
	{
	}

	private void OnTeamRallyCooldownSync(uint requesterPlayerID)
	{
	}

	private void HideTeamRallyIconForPlayer(uint playerID)
	{
	}

	private void ClearAllTeamRallyIcons()
	{
	}

	public void OnLocalPlayerLastVehicleChange(object[] param)
	{
	}

	private int GetTeamIndex(Player player)
	{
		return 0;
	}

	private void SwitchUGCFactionUI()
	{
	}

	private void RefreshLocalTeammates(Player player, int oldPlayerTeamIndex, byte newTeamId, List<KMGBNNHDOHF> newTeamMateList)
	{
	}

	private void RefreshTeammatesUI()
	{
	}

	private void RefreshNewTeammatesMark(byte teamId, List<KMGBNNHDOHF> newTeamMateLists)
	{
	}

	private void Update()
	{
	}

	private void CloseAircraftAndResidueAirLine()
	{
	}

	public void ForceUpdateSafeZone()
	{
	}

	private void UpdateResidueAirLine(AirtransportParams airLine, float curTime)
	{
	}

	public void RefreshAirLineAlphaByPlayerState(bool force = false)
	{
	}

	private void RefreshAirLineAlpha(bool isOnBoard)
	{
	}

	private void OnDeplane(object[] data)
	{
	}

	private void UpdateAircraftAndResidueAirLine()
	{
	}

	private bool ShouldShowRoomOBPlayerBigMapIcons()
	{
		return false;
	}

	private void ClearRoomOBPlayerMapIconsIfAny()
	{
	}

	private void UpdateRoomOBPlayerMapIcons()
	{
	}

	private Vector3 GetTeammateMapForward(Player teammate)
	{
		return default(Vector3);
	}

	private void UpdateTeamatePosition()
	{
	}

	private void UpdateLocalScoutDriving()
	{
	}

	private void SetLocalPlayerArrowScoutDriving()
	{
	}

	private void RevertLocalPlayerArrowScoutDriving()
	{
	}

	private void Update3PScouts()
	{
	}

	private void UpdateSlowDownPointPosition()
	{
	}

	private void UpdateDeliverySkillEnemyPointPosition()
	{
	}

	private void UpdateMaxHypePlayerPos()
	{
	}

	private void UpdateRevengeMarkPos()
	{
	}

	private void UpdateDeathMatchKillerKingPos()
	{
	}

	private void UpdatePlayerStatus()
	{
	}

	private void UpdateGuideToMark()
	{
	}

	private void UpdateBigMapGuideToMark()
	{
	}

	private bool TeammateIconCanShow(Player teammatePlayer)
	{
		return false;
	}

	public void OnObservePlayerBigmap(object[] data, bool dontHideTeammateMapMark = false)
	{
	}

	public void OnObservePlayerMinimap(object[] data)
	{
	}

	private void SetTeamateSpriteByIndex(TeammateGameObject teamGo, int idx, BHGGAEEHJCO playerId)
	{
	}

	public void OnObserverTargetChange()
	{
	}

	private void HideAllTeammateObject()
	{
	}

	public void ShowMapMarkIconByTeamIndexMiniMapEventWrapper(object[] param)
	{
	}

	private bool CheckTeammatePosTypeValid(uint posType, Vector3 realPos)
	{
		return false;
	}

	private void RefreshArcGeneratorUI(int groupId)
	{
	}

	private UIArcGeneratorLineController GetSlideLineCtrl(int groupId, bool needOpenCtrl = true)
	{
		return null;
	}

	public void HideMapMarkIconByIndexMiniMapEventWrapper(object[] param)
	{
	}

	private void OnAddDetector(object[] data)
	{
	}

	private void CreateDetector(DetectorMapObjectModel d)
	{
	}

	private void SetupAirLine()
	{
	}

	public void ShowAirLine()
	{
	}

	public void HideAirLine()
	{
	}

	public void BigMapCenterPlayerPos()
	{
	}

	public void BigMapCenterSafeZone(EBigMapInteractionMode interactionMode)
	{
	}

	private void DestroyDetector()
	{
	}

	public void UpdateDetector(float angle)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void InitUGCMiniMapParams(float scale, Vector3 centerOffset)
	{
	}

	public void InitHippoCrisisMapParams(float scale, Vector3 centerOffset)
	{
	}

	public float GetBigMapMinScale()
	{
		return 0f;
	}

	public Vector3 GetSafeZoneInnerCenter()
	{
		return default(Vector3);
	}

	public float GetSafeZoneInnerRadius()
	{
		return 0f;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnTreasureMarked(object[] param)
	{
	}

	private void OnTreasureContainerDelete(object[] param)
	{
	}

	public void OnZombieSync(GEvent data)
	{
	}

	private void AddPumpkinPos(uint id, Vector3 pos)
	{
	}

	public void OnPumpkinPosSync(object[] data)
	{
	}

	public void OnPumpkinPosListSync(object[] data)
	{
	}

	public void OnPlayerPumpkinPosListSync(object[] data)
	{
	}

	public void OnCarePackageSync(GEvent data)
	{
	}

	public void OnSyncWereWolvesTask(object[] data)
	{
	}

	private void SyncWereWolvesEmergencyTask(Dictionary<uint, GameObject> dic, Queue<GameObject> queue, uint objID, Vector3 position, bool needDestroy)
	{
	}

	private void SyncWereWolvesTask(Dictionary<uint, GameObject> dic, Queue<GameObject> queue, uint objID, Vector3 position, bool needDestroy)
	{
	}

	private void OnSyncGeneralConstructionMapIcon(GEvent dataEvent)
	{
	}

	private void OnSyncEnergyDeviceMapIcon(GEvent _gEvent)
	{
	}

	private void UpdateEnergyDevicePoint()
	{
	}

	private void OnSyncAirDropMapIcon(GEvent _gEvent)
	{
	}

	public void OnSyncBossZone(object[] data)
	{
	}

	private void SyncBossZone(Dictionary<uint, UIMapBossZoneView> iconDict, uint objID, Vector3 position, DGLPANAFDGA stage, uint bossSpawnTimes, float bossHpRatio)
	{
	}

	private GameObject SyncSimpleMapIcon(GameObject iconTemplate, Dictionary<uint, GameObject> iconDict, Queue<GameObject> iconQueue, uint iconUniqueId, Vector3 worldPos, bool show)
	{
		return null;
	}

	private T SyncSimpleMapIconWithUIPos<T>(Dictionary<int, T> iconDict, int iconUniqueId, Vector3 iconPos, bool visible) where T : UIBaseController
	{
		return null;
	}

	private T SyncSimpleMapIcon<T>(GameObject iconTemplate, Dictionary<int, T> iconDict, Queue<T> iconQueue, int iconUniqueId, Vector3 worldPos, bool visible) where T : Component
	{
		return null;
	}

	private T SyncSimpleMapIconWithUIPos<T>(GameObject iconTemplate, Dictionary<int, T> iconDict, Queue<T> iconQueue, int iconUniqueId, Vector3 iconPos, bool visible) where T : Component
	{
		return null;
	}

	private void SyncLockAirDropIcon(uint id, Vector3 pos, bool needDestroy, uint interactTime, DFMAGBNLCHD type)
	{
	}

	private void ResetLockAirDropPos()
	{
	}

	private void OnSyncHiraishinIcon(object[] param)
	{
	}

	private bool IsDuringBigItemMiniShow()
	{
		return false;
	}

	private void UpdateBigItemPointPos()
	{
	}

	private bool UpdataBigItemPos(UIMapContenBigItemIconController retreatIconGo)
	{
		return false;
	}

	private void OnBigItemsIconSync(bool show)
	{
	}

	private void OnBigItemsIconStateSync(uint uniqueID)
	{
	}

	private void OnBigItemsIconPosSync(object[] param)
	{
	}

	private void OnInteractAreaStateChanged(GEvent param)
	{
	}

	private void OnInteractAreaTimeChanged(GEvent param)
	{
	}

	private List<UIHud2NBGPMapContentBloodMoonIconController> GetBloodMoonIconsList(int capacity = 0)
	{
		return null;
	}

	private void SpawnBloodMoonMapIcons()
	{
	}

	private void RemoveAllBloodMoonMapIcons()
	{
	}

	private Dictionary<uint, UIHud2NBGPMapContentBloodMoonAirdropIconController> GetBloodMoonAirdropIcons(int capacity = 0)
	{
		return null;
	}

	private void AddBloodMoonAirdropMapIcon(uint airdropObjectID, Vector3 worldPosition)
	{
	}

	private void RemoveBloodMoonAirdropMapIcon(uint airdropObjectID)
	{
	}

	public void BatchShowBloodMoonAirdropMapIcons(object[] param)
	{
	}

	private void UpdateBloodMoonAirdropMapIconsRotation()
	{
	}

	private void UpdateBloodMoonAirdropMapIconsScale()
	{
	}

	private void RemoveAllBloodMoonAirdropMapIcons()
	{
	}

	private TCtrl AllocateManagedMapContentIconController<TCtrl>(Transform parent, Vector3 localPosition, object viewData) where TCtrl : UIManagedMapContentIconController
	{
		return null;
	}

	private void FreeManagedMapContentIconControllerAnyway<TCtrl>(ref TCtrl ctrl) where TCtrl : UIManagedMapContentIconController
	{
	}

	private void FreeManagedMapContentIconController<TCtrl>(TCtrl ctrl) where TCtrl : UIManagedMapContentIconController
	{
	}

	private void SetManagedMapContentIconsRotationUp(Quaternion localRotation)
	{
	}

	private void SetManagedMapContentIconsVisuallyConstantScale(Vector3 localScale)
	{
	}

	private void NotifyManagedMapContentIconsTrackedPlayerChanged(BHGGAEEHJCO trackedPlayer)
	{
	}

	private void CleanupAllManagedMapContentIcons()
	{
	}

	public bool TryCheckClickManagedLevelObjectMapIcon(Vector3 worldPoint, out Vector3 objectPos, out uint levelObjectID, out OPICPDCLKAG clickObjectType)
	{
		objectPos = default(Vector3);
		levelObjectID = default(uint);
		clickObjectType = default(OPICPDCLKAG);
		return false;
	}

	public bool TryGetMarkPointTypeFromManagedLevelObjectIcons(uint levelObjectID, out EILKGGIDJEH markPointType)
	{
		markPointType = default(EILKGGIDJEH);
		return false;
	}

	private bool HasReviveBoxMapIconForPlayer(BHGGAEEHJCO playerID)
	{
		return false;
	}

	private void SetDeadBoxHiddenByReviveBoxMapIcon(BHGGAEEHJCO playerID, bool hidden)
	{
	}

	private void TrackReviveBoxMapIcon(uint levelObjectID, LevelReviveBox reviveBox)
	{
	}

	private void UntrackReviveBoxMapIcon(uint levelObjectID)
	{
	}

	private void RefreshReviveBoxMapIcons()
	{
	}

	private bool ValidateManagedLevelObjectMapIconParams(OPICPDCLKAG levelObjectType, uint levelObjectID, out Vector3 levelObjectWorldPos, out BaseLevelObject levelObject, out OGIJAGDFGAM logicLevelObject)
	{
		levelObjectWorldPos = default(Vector3);
		levelObject = null;
		logicLevelObject = null;
		return false;
	}

	private UIManagedLevelObjectMapIconController AllocateManagedLevelObjectMapIconController(UIManagedLevelObjectMapIconViewData commonViewData, Vector3 mapContentLocalPos, BaseLevelObject levelObject, OGIJAGDFGAM logicLevelObject)
	{
		return null;
	}

	private void OnManagedLevelObjectMapIconAdded(GEvent rawEventData)
	{
	}

	private void OnManagedLevelObjectMapIconRemoved(uint levelObjectID)
	{
	}

	private void RemoveAllManagedLevelObjectMapIcons()
	{
	}

	public bool PlayReviveBoxHighlightUIFX(uint levelObjectID, ResourceID resID)
	{
		return false;
	}

	private Dictionary<BHGGAEEHJCO, List<UIHudRoutePlanningMapMarkerController>> GetRoutePlanningMarkers()
	{
		return null;
	}

	private List<UIHudRoutePlanningMapMarkerController> GetPlayerRoutePlanningLoadedMarkers(BHGGAEEHJCO player)
	{
		return null;
	}

	private void UpdateRoutePlanningMarkerVisibility(UIHudRoutePlanningMapMarkerController markerCtrl, BHGGAEEHJCO markerOwner)
	{
	}

	private void UpdateRoutePlanningMarkersVisibility()
	{
	}

	private void RemoveAllRoutePlanningMarkers()
	{
	}

	private void OnRoutePlanningAllMarkersReady()
	{
	}

	private void OnRoutePlanningPlayerMarkerAdded(uint playerID, uint addedMarkerUUID)
	{
	}

	private void OnRoutePlanningPlayerMarkerRemoved(uint playerID, uint removedMarkerUUID)
	{
	}

	private void OnRoutePlanningPlayerMarkerReached(uint playerID, uint reachedMarkerUUID)
	{
	}

	private void OnRoutePlanningPlayerAllMarkersRemoved(uint playerID)
	{
	}

	private void OnLockAirDropIntStateChanged(object[] param)
	{
	}

	private void OnLockAirDropIntStepChanged(object[] param)
	{
	}

	private void OnLockAirDropIntTimeChanged(object[] param)
	{
	}

	public void OnCampFireSync(object[] data)
	{
	}

	public void OnAddPlayer(GEvent data)
	{
	}

	private bool ShouldShowJKPBuff()
	{
		return false;
	}

	private void RefreshAroundEnemy()
	{
	}

	private void HideAroundEnemyPoint()
	{
	}

	private void OnSwitchObserver(object[] param)
	{
	}

	private void OnSpectatorTrackedTargetChange(object[] param)
	{
	}

	private void UpdateMocoMarkPoint2(bool forceUpdate = false)
	{
	}

	private void OnSyncSlowDownEnemyPoint(object[] param)
	{
	}

	private void OnSyncDeliverySkillEnemyPoint(object[] param)
	{
	}

	private void RecycleInvisibleRevengeMark(BHGGAEEHJCO pID)
	{
	}

	private void OnShowItemGeneratorInfo(object[] data)
	{
	}

	public void OnUpdateTreasuryState(object[] data)
	{
	}

	public void OnUpdateNotebookState(object[] data)
	{
	}

	private void OnUpdateTreasureHuntNormalTreasureState(object[] data)
	{
	}

	private void OnUpdateTreasureHuntUnderTreasuryState(object[] data)
	{
	}

	public void OnDefaultInteractionModeEnterShowMapContentView()
	{
	}

	private void OnUpdateMapThrowerState(GEvent data)
	{
	}

	private void EnqueueToMapThrowerQueue(ulong uniqueID)
	{
	}

	public UIHudMapThrowerSelectWndController GetMapThrowerSelectWndController()
	{
		return null;
	}

	public UIHudMapAstrolGateWndController GetMapAstrolGateSelectWndController()
	{
		return null;
	}

	private void OnAstrolGateAdd(int astrolGateIDInt)
	{
	}

	private void OnAstrolGateRemove(int astrolGateID)
	{
	}

	private void OnAstrolGateStateSelected(int astrolGateID)
	{
	}

	private void UpdateAstrolGateIconPosition(uint astrolGateID, Vector3 pos)
	{
	}

	private void ClearAstrolGateIcons()
	{
	}

	public void RefreshMapSafeZoneUIFX(bool isShowMapThrowerUIFX)
	{
	}

	public void RefreshMapPromptUIFX(bool isShow)
	{
	}

	private void RefreshSafeZoneUIFX(VisualInstanceHolder holder)
	{
	}

	public Vector3 GetCatapultHitPosition()
	{
		return default(Vector3);
	}

	private void OnRefreshCatapultLaunchLine(object[] param)
	{
	}

	private void OnLockBountyVehicleStateChanged(object[] param)
	{
	}

	private void OnDarkCircleStateChanged(object[] param)
	{
	}

	private void OnSummonerActionUpdate(object[] param)
	{
	}

	private void UpdateSummonerActionPoint()
	{
	}

	private void RefreshSummonerActionPointPosInMiniMap(BHGGAEEHJCO ownerId)
	{
	}

	private void OnWeRunRetreatPointCreate(object[] param)
	{
	}

	private void UpdateWeRunRetreatPoint()
	{
	}

	private void RefreshWeRunRetreatPointPosInMiniMap(int index)
	{
	}

	private Vector3? GetEdgeIntersectPoint(Vector3 realPosInMap, float offset = 0f)
	{
		return null;
	}

	private bool GetEdgeIntersectPoint(Vector3 realPosInMap, out Vector3 resultPos, float offset = 0f)
	{
		resultPos = default(Vector3);
		return false;
	}

	public List<uint> GetHippoCrisisBoxDrops(uint id)
	{
		return null;
	}

	private void OnHippoCrisisMissionBoxIcon(object[] param)
	{
	}

	private void OnHippoCrisisBoxIcon(object[] param)
	{
	}

	private void OnHippoCrisisBoxOpen(object[] param)
	{
	}

	private void OnBountyBoxCreate(object[] param)
	{
	}

	private void OnBountyBoxItemGet(object[] param)
	{
	}

	private void OnIceSculptureSync(object[] param)
	{
	}

	private void OnIceSculptureHUDHide(uint id)
	{
	}

	public void OnCreateItemGenerators(object[] param)
	{
	}

	private IEnumerator CreateItemGenerator(List<LevelObjectItemGenerator> data)
	{
		return null;
	}

	public void OnHideItemGenerators(object[] param)
	{
	}

	private void UpdateItemGenerators()
	{
	}

	private void OnUsedCSItemGenerator(object[] param)
	{
	}

	private void ResetItemGeneratorPos()
	{
	}

	public void OnUpdateCyberMushroomScan(GEvent data)
	{
	}

	public void OnCyberMushroomScanEnd(uint id)
	{
	}

	public void OnUpdateWishingTreeState(object[] data)
	{
	}

	public void OnUpdateOniBoss(object[] data)
	{
	}

	public void OnUpdateOniBirdStay(object[] data)
	{
	}

	public void OnUpdateOniZoneState(object[] data)
	{
	}

	private void OnUpdateGeneratedItemInfo(object[] data)
	{
	}

	private void OnUpdateRevengeInfo(object[] data)
	{
	}

	private void RecycleInvisibleMaxHypePlayer(BHGGAEEHJCO pID)
	{
	}

	private void OnMaxHypeLevelPlayerOccurs(object[] data)
	{
	}

	public void ReleaseMapTexture()
	{
	}

	private void OnTeleportDoorStateChanged(object[] data)
	{
	}

	public void SetTeleportDoorVisible(HCBGDFOPAIJ type, bool v)
	{
	}

	public void ResetTeleportDoorPos()
	{
	}

	public bool HasMaxHypePlayer(BHGGAEEHJCO pId)
	{
		return false;
	}

	public void ShowMaxHypePlayerShooting(BHGGAEEHJCO pId, float angle)
	{
	}

	public void OnShowHotzoneOnMap(object[] param)
	{
	}

	public void OnHideHotzoneOnMap(uint param)
	{
	}

	public bool HasLevelHotzoneShowing()
	{
		return false;
	}

	private void OnBloodmoonGPCircleSync()
	{
	}

	public void UpdateBloodmoonGPCircles()
	{
	}

	public float GetBloodmoonGPCenterIconHalfExtent()
	{
		return 0f;
	}

	private void OnEnergyStoneBoxStateChange(object[] param)
	{
	}

	public void OnShowCandyHotzoneOnMap(object[] param)
	{
	}

	public Vector3 GetMapPanelScale()
	{
		return default(Vector3);
	}

	public Vector3 GetMapPanelLocalPos()
	{
		return default(Vector3);
	}

	public Transform GetMapPanelTransform()
	{
		return null;
	}

	public Dictionary<BHGGAEEHJCO, TeammateGameObject> GetTeammatesMap()
	{
		return null;
	}

	private float GetOrCreateMarkScale(BHGGAEEHJCO playerID)
	{
		return 0f;
	}

	private void OnLocalPlayerPhysicsStateChange(GEvent data)
	{
	}

	private void OnTeamParachuteModeChange(object[] param)
	{
	}

	public void UpdateMusicBombRange()
	{
	}

	public void UpdateThunderBombRange()
	{
	}

	private void UpdateBomberMakerRange()
	{
	}

	private void UpdateToxicZone()
	{
	}

	private void OnShowToxicZoneOnMap(object[] param)
	{
	}

	private void OnSyncPetFindMushroomMark(object[] param)
	{
	}

	private void SetMushRoomHide()
	{
	}

	private void OnSyncPetFindMushroomRemove(object[] param)
	{
	}

	private void OnShowRandomCenter(bool param)
	{
	}

	private void OnShowRandomMoveArrow(bool param)
	{
	}

	private void OnRadarScanUpdate(object[] data)
	{
	}

	private void OnRadarRefresh(object[] data)
	{
	}

	private void OnCreateNBGroundHole(object[] data)
	{
	}

	private void OnTrainStationStateChange(object[] datas)
	{
	}

	private void UpdateSafeZoneRandomMoveArrow()
	{
	}

	private void OnSyncCSGameZone(object[] param)
	{
	}

	private void OnShowWarningZoneOnMap(object[] param)
	{
	}

	public void ShowIconOnMap(EIconType iconType, bool show)
	{
	}

	private void OnShowRevivePointOnMap(object[] param)
	{
	}

	private void OnRevivePointIconLoaded(uint ticket, bool success, UnityEngine.Object resource)
	{
	}

	private void OnShowHGEndPointOnMap(GEvent gEvent)
	{
	}

	private void CalAndSetHGEndPointUIPosOnMap()
	{
	}

	private void OnShowIngameShopOnMap(object[] param)
	{
	}

	private void OnChangeIngameShopPointIcon(object[] param)
	{
	}

	public void TryPlayPOIMissionMapIconVfxOnFirstOpen()
	{
	}

	private void ReleasePOIMissionMapIconVfx()
	{
	}

	public void OnMapUpdateOffsetRefreshShopLocation()
	{
	}

	private void OnShowIngameStropOnMap(object[] param)
	{
	}

	private void OnAddStropIngameOnMap(PMFGOGFPDHM position, uint stropID)
	{
	}

	private void OnRemoveIngameStropOnMap(uint stropId)
	{
	}

	private void OnRevivePointStateChanged(object[] param)
	{
	}

	private void OnRevivePointTimeChanged(object[] param)
	{
	}

	private void OnRevivePointAdvancedChanged(object[] param)
	{
	}

	private void OnReviveChestChanged(object[] param)
	{
	}

	private void OnShowBTFishingPoolOnMap(object[] param)
	{
	}

	private void OnBTFishingPoolStateChanged(object[] param)
	{
	}

	private void OnShowBTTeleportOnMap(object[] param)
	{
	}

	private void CreateBTTeleportIconSync(uint id, Vector3 pos)
	{
	}

	private void OnBTTeleportIconPoolLoaded(uint id, Vector3 pos, uint ticket, bool success, UnityEngine.Object ret)
	{
	}

	private void OnShowBTIslandEntryOnMap(object[] param)
	{
	}

	private void CreateBTIslandEntryIconSync(uint id, Vector3 pos)
	{
	}

	private void OnBTIslandEntryIconPoolLoaded(uint id, Vector3 pos, uint ticket, bool success, UnityEngine.Object ret)
	{
	}

	private void OnBombZoneChanged(object[] param)
	{
	}

	private void OnControlPointChanged(object[] data)
	{
	}

	private void OnBombPickupGet(object[] data)
	{
	}

	private void OnBombPickupDrop(object[] data)
	{
	}

	private void OnBombRoundChange(object[] data)
	{
	}

	private void OnBombSettled(object[] data)
	{
	}

	private void OnPlayerODFactionChanged(object[] data)
	{
	}

	private void OnZeppelinPosUpdate(GEvent data)
	{
	}

	private void OnEscortVehiclePosUpdate(object[] data)
	{
	}

	private void OnZeppelinSpawnNextPosition(GEvent data)
	{
	}

	private void UpdateZepplineMoveDirection()
	{
	}

	private void OnShowBountyContract(object[] data)
	{
	}

	private void OnCSRoundDragonCreate(object[] data)
	{
	}

	private void OnCSRoundDragonDestroy(object[] data)
	{
	}

	private void OnCSRoundEnd()
	{
	}

	private void UpdateDragonPosition()
	{
	}

	private void OnUavCreate(object[] data)
	{
	}

	private void PreInstantiateUAVObjectView()
	{
	}

	private UIUAVMapObjectView TakeUAVObjectView()
	{
		return null;
	}

	private void OnUavDestroy(object[] data)
	{
	}

	private void OnPermanentScan(GEvent data)
	{
	}

	private void UpdateMissionWantedPlayerPosition(float deltaTime)
	{
	}

	private void OnShowPlayerRange(object[] data)
	{
	}

	private void OnAddHuntPlayer(object[] data)
	{
	}

	private void OnRemoveHuntPlayer(object[] data)
	{
	}

	private void UpdateHuntPlayerPosition()
	{
	}

	private void UpdateOniBossPosition()
	{
	}

	private void OnSafeZoneChanged()
	{
	}

	private void OnShowCSMark(int csMarkRange, int csMarkDuration)
	{
	}

	private void UpdateCSMark()
	{
	}

	private void ClearCsMark()
	{
	}

	private void OnUGCFactionChange(object[] param)
	{
	}

	private void OnLocalTeamChange(object[] param)
	{
	}

	private void OnShowMetropolisAreaOnMap(object[] param)
	{
	}

	private void OnMetropolisAreaStateChange(object[] param)
	{
	}

	private void OnMetropolisAreaStateEndTimeChange(object[] param)
	{
	}

	private void OnMetropolisAreaCountChange(object[] param)
	{
	}

	private void OnLocalPlayerFactionChange(object[] param)
	{
	}

	private void OnRoleChange(object[] param)
	{
	}

	private void OnDebugSafeZone(object[] param)
	{
	}

	public void UpdateMinimapGuideToMark()
	{
	}

	public void OnPlayerHPChangedMinimap(BHGGAEEHJCO pId)
	{
	}

	public void SetMapMaskSupplement()
	{
	}

	public void EnableBigMap(EBigMapType bigMapType = EBigMapType.MapTypeNormal)
	{
	}

	public void UpdateSafeZoneCircleShow()
	{
	}

	private IEnumerator WaitToUpdateSafeZoneCircleShow(bool show)
	{
		return null;
	}

	private void UpdateTeammates()
	{
	}

	private void UpdateDeliverySkillPoint()
	{
	}

	private void UpdateSlowDownMarkPoint()
	{
	}

	public void InitBigmapParams(Vector3 scale, float clipWidth, float clipHeight)
	{
	}

	public void InitSidemapParams(Vector3 scale, float clipWidth, float clipHeight)
	{
	}

	public float GetBigmapCurrentScaleRatio()
	{
		return 0f;
	}

	public void RemoveTeamMapMark(BHGGAEEHJCO playerID, int teamIndex)
	{
	}

	public void UpdateTeamMapMark(uint playerIDInt, int teamIndex, uint posType, bool hasMark, short posX, short posY, Vector3 realPos)
	{
	}

	public void TryCheckTeammateMark(Vector3 position)
	{
	}

	public bool TryCheckClickWinterlandMidPoint(Vector3 position, out Vector3 transformPos)
	{
		transformPos = default(Vector3);
		return false;
	}

	public bool TryCheckClickWinterlandPoint(Vector3 position, out Vector3 transformPos, out uint levelObjectID)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		return false;
	}

	public bool TryCheckClickRevivePoint(Vector3 position, out Vector3 transformPos)
	{
		transformPos = default(Vector3);
		return false;
	}

	public bool TryCheckClickShopPoint(Vector3 position, out Vector3 transformPos)
	{
		transformPos = default(Vector3);
		return false;
	}

	public bool TryCheckClickMapThrowerPoint(Vector3 position, out Vector3 transformPos, out OPICPDCLKAG clickObjectType, out uint levelObjectID)
	{
		transformPos = default(Vector3);
		clickObjectType = default(OPICPDCLKAG);
		levelObjectID = default(uint);
		return false;
	}

	public bool TryCheckClickAstrolGatePoint(Vector3 position, out Vector3 transformPos, out uint astrolGateID)
	{
		transformPos = default(Vector3);
		astrolGateID = default(uint);
		return false;
	}

	public bool TryCheckClickEnergyDevicePoint(Vector3 position, out Vector3 transformPos, out uint levelObjectID)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		return false;
	}

	public bool TryCheckClickStropPoint(Vector3 position, out Vector3 transformPos)
	{
		transformPos = default(Vector3);
		return false;
	}

	public bool TryCheckClickSlideStationPoint(Vector3 position, out Vector3 transformPos)
	{
		transformPos = default(Vector3);
		return false;
	}

	public bool TryCheckClickIIVTeleportDoor(Vector3 position, out Vector3 transformPos)
	{
		transformPos = default(Vector3);
		return false;
	}

	public bool TryCheckClickTreasuryPoint(Vector3 position, out Vector3 transformPos, out uint levelObjectID)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		return false;
	}

	public bool TryCheckClickBloodmoonGPCircle(Vector3 position, out Vector3 transformPos, out int circleIndex)
	{
		transformPos = default(Vector3);
		circleIndex = default(int);
		return false;
	}

	public bool TryResolveBloodmoonGPCircleMarkPointType(uint circleIndex, out EILKGGIDJEH markPointType)
	{
		markPointType = default(EILKGGIDJEH);
		return false;
	}

	public bool TryCheckClickHippoCrisisBox(Vector3 position, out Vector3 transformPos, out OPICPDCLKAG clickObjectType, out uint levelObjectID)
	{
		transformPos = default(Vector3);
		clickObjectType = default(OPICPDCLKAG);
		levelObjectID = default(uint);
		return false;
	}

	public bool TryCheckClickBTFishingPool(Vector3 position, out Vector3 transformPos, out uint levelObjectID, out OPICPDCLKAG type)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		type = default(OPICPDCLKAG);
		return false;
	}

	public bool TryCheckClickBTTeleport(Vector3 position, out Vector3 transformPos, out uint levelObjectID, out OPICPDCLKAG type)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		type = default(OPICPDCLKAG);
		return false;
	}

	public bool TryCheckClickBTIslandEntry(Vector3 position, out Vector3 transformPos, out uint levelObjectID, out OPICPDCLKAG type)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		type = default(OPICPDCLKAG);
		return false;
	}

	public bool TryCheckClickHippoCrisisRetreatPoint(Vector3 position, out Vector3 transformPos, out OPICPDCLKAG clickObjectType)
	{
		transformPos = default(Vector3);
		clickObjectType = default(OPICPDCLKAG);
		return false;
	}

	public bool TryCheckClickMissionMachinePoint(Vector3 position, out Vector3 transformPos, out uint levelObjectID, out OPICPDCLKAG clickObjectType)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		clickObjectType = default(OPICPDCLKAG);
		return false;
	}

	public bool TryCheckClickMetropolisAreaPoint(Vector3 position, out Vector3 transformPos, out uint levelObjectID, out OPICPDCLKAG type)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		type = default(OPICPDCLKAG);
		return false;
	}

	public bool TryCheckClickOniZonePoint(Vector3 position, out Vector3 transformPos, out uint levelObjectID)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		return false;
	}

	public bool TryCheckClickEighthStation(Vector3 position, out Vector3 transformPos, out uint levelObjectID, out OPICPDCLKAG type)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		type = default(OPICPDCLKAG);
		return false;
	}

	public bool TryCheckClickSFRoleplayNotebook(Vector3 position, out Vector3 transformPos, out uint levelObjectID, out OPICPDCLKAG type)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		type = default(OPICPDCLKAG);
		return false;
	}

	public bool TryCheckClickTreasureHuntUnderTreasury(Vector3 position, out Vector3 transformPos, out uint levelObjectID, out OPICPDCLKAG type)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		type = default(OPICPDCLKAG);
		return false;
	}

	public bool TryCheckClickTreasureHuntNormalTreasure(Vector3 position, out Vector3 transformPos, out uint levelObjectID, out OPICPDCLKAG type)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		type = default(OPICPDCLKAG);
		return false;
	}

	public bool TryCheckClickIceSculpture(Vector3 position, out Vector3 transformPos, out uint levelObjectID, out OPICPDCLKAG type)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		type = default(OPICPDCLKAG);
		return false;
	}

	public bool TryCheckClickBigItemPoints(Vector3 position, out Vector3 transformPos, out uint levelObjectID, out OPICPDCLKAG type)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		type = default(OPICPDCLKAG);
		return false;
	}

	public bool TryCheckClickGeneralConstructionPoints(Vector3 position, out Vector3 transformPos, out uint levelObjectID, out OPICPDCLKAG type)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		type = default(OPICPDCLKAG);
		return false;
	}

	public bool TryCheckClickAirDropPoint(Vector3 position, out Vector3 transformPos, out uint levelObjectID)
	{
		transformPos = default(Vector3);
		levelObjectID = default(uint);
		return false;
	}

	private void ShowFateRandomTeamZone(object[] param)
	{
	}

	private void OnFateRandomStartFight(object[] param)
	{
	}

	private void OnFateRandomReviveSelect(bool show)
	{
	}

	private void OnFateRandomRevivePosSync(object[] data)
	{
	}

	private void AddFateRandomRevivePos(BHGGAEEHJCO ownerID, Vector3 position)
	{
	}

	private void RemoveFateRandomRevivePos(FateRandomRevivePositionObject obj)
	{
	}

	private void UpdateFateRandomReviveMarkState(Vector3 position)
	{
	}

	private void UpdateFateRandomReviveMarkState()
	{
	}

	private void OnUGCSupplyBoxTriggerEnable(object[] param)
	{
	}

	private void OnUGCSupplyBoxTriggeModelChanged(object[] param)
	{
	}

	private GameObject GetSupplyBoxTriggerObjectFromPool()
	{
		return null;
	}

	private void RecycleSupplierBoxTriggerObject(string entityID)
	{
	}

	public void ChangeMapPanelScale(Vector3 targetScale)
	{
	}

	public void MoveMap(Vector2 deltaPos)
	{
	}

	private void OnShowLevelObjScan(object[] data)
	{
	}

	private void OnDetectiveMarkEnemy(object[] data)
	{
	}

	private void OnDetectiveEnemiesByTBD(object[] data)
	{
	}

	private void OnCSBuffDetectEnemies(object[] data)
	{
	}

	private void UpdateCSBuffDetectEnemies()
	{
	}

	private void UpdateCSBuffDetectObjScale()
	{
	}

	private GameObject PopPointObjFromPool()
	{
		return null;
	}

	private void RecyclePointObj(uint playerID)
	{
	}

	private GameObject PopDetectiveEffectObjFromPool()
	{
		return null;
	}

	private void RecycleDetectiveEffectObj(uint playerID)
	{
	}

	private void RefreshDetectiveEffect(float showTime = 0.8f)
	{
	}

	private void OnShowVoteBody(object[] data)
	{
	}

	private void OnHideVoteBody(object[] data)
	{
	}

	private void OnTrapCatchPlayer(object[] param)
	{
	}

	private void UpdateBanHighZoneHint()
	{
	}

	private void OnBanHighZoneHintChange(object[] data)
	{
	}

	public void UpdateRadarPreScan(bool show, float scanSize, Vector3 position)
	{
	}

	public void ShowBuffECAExposurePos(BHGGAEEHJCO id, float showTime, Vector3 pos)
	{
	}

	private void UpdateSantinoDummy()
	{
	}

	private void UpdateAutoPathBomb()
	{
	}

	private void ShowGeekSpiderBombIcon(GameObject go, LevelAutoPathBomb data)
	{
	}

	public void OnShopDiscount()
	{
	}

	private void OnPlayerRevive(uint data)
	{
	}

	private void OnInstrumentCreated()
	{
	}

	private void OnInstrumentUsed(uint objectID)
	{
	}

	private void OnUIChangeFromWaitingToBattle()
	{
	}

	private void InitSafeZone()
	{
	}

	private void OnTokenMachineChanged(GEvent data)
	{
	}

	private void OnIIVCursedEnergyChanged(GEvent data)
	{
	}

	private void OnIIVTeleportDoorChanged(GEvent data)
	{
	}

	public bool IsFloatingLandMap()
	{
		return false;
	}

	private void RefreshFloatingLandMap(object[] param)
	{
	}

	public void InitMapContentForBTUnderwaterMap()
	{
	}

	private void OnPOIMissionShow(GEvent data)
	{
	}

	private void OnSeafoodGateBuffMapChanged(GEvent data)
	{
	}

	private void OnSeafoodCookieShopShowChanged(GEvent data)
	{
	}

	private void OnInfiniteCakeShowChanged(GEvent data)
	{
	}

	private void OnAddSeafoodLittleGirl(object[] data)
	{
	}

	private void OnReviveMissionStart(object[] data)
	{
	}

	private void OnReviveMissionEnd(object[] data)
	{
	}

	private void OnMissionMachineChanged(GEvent data)
	{
	}

	private void OnHypercrateInfoShow(GEvent data)
	{
	}

	private void OnCabinWaitingEnd()
	{
	}

	private void OnBuffECAPlayerExposurePos(object[] data)
	{
	}

	private void OnGlobalMissionKingChanged(object[] data)
	{
	}

	private void ShowKingClownInternal()
	{
	}

	private void HideKingClownController()
	{
	}

	public void ShowVehiclChipScanPos(float angle, object[] data)
	{
	}

	public void ShowVehicleScanRange(object[] data)
	{
	}

	public void OnUsingHotPursuit(List<uint> idList, float radius, uint playerId, float endTime, bool needTween = false)
	{
	}

	public UIHotPursuitBigMapRangeController OnUsingHotPursuit(uint id, float radius, uint playerId, float endTime, bool needTween = false)
	{
		return null;
	}

	public void OnUsingTelescope(Vector3 pos, float radius, uint playerId, float endTime)
	{
	}

	internal void CreateCabinMapObj(PHEPNBFBLBG info)
	{
	}

	private void OnParachuteActiveObjectShow(bool show)
	{
	}

	internal void DestroyCabinMapObj()
	{
	}

	private void UpdateIconsRotationUp()
	{
	}

	public void SetSafeZoneChooseRegionCenter(Vector3 center)
	{
	}

	public void SetBigMapSliderValue(float value)
	{
	}

	private Vector3 CalMapIconLookScale(float mapScale)
	{
		return default(Vector3);
	}

	private Vector3 CalMapIconScaleByMapScale(float mapScale)
	{
		return default(Vector3);
	}

	public void SetMapContainerScale(float scale, bool force = false)
	{
	}

	public void SetMapIconScaleByMapPanelScale(float scale, bool force = false)
	{
	}

	private void ShowGhostCircle(GEvent data)
	{
	}

	public Dictionary<uint, UILockAirDropIconController> GetAirdropIconsController()
	{
		return null;
	}

	private void CloseGhostCircle()
	{
	}

	private void SetMapIconScale(Vector3 mapIconScale, bool force = false)
	{
	}

	public void HideHotPursuitTween()
	{
	}

	public void CheckAndShowAdvancedRevivePoinitNotify()
	{
	}

	private void OnMapScaneRefresh(object[] data)
	{
	}

	private UIMapObjectMapScanView GetMapScanView(uint objID, bool needCreate)
	{
		return null;
	}

	private void OnMapScaneUpdate()
	{
	}

	public void ShowDarkCircleEffect()
	{
	}

	public void AttachWeakDarkCicleVFX()
	{
	}

	private void OnWeakDarkCirlceLoopLoaded(GameObject go)
	{
	}

	public void HidekDarkCicleEffect(bool hideWeak = false)
	{
	}

	public void ShowFFwsSafezoneEffect()
	{
	}

	private void OnSafeZoneEffectChange(GEvent evt)
	{
	}

	private void UpdateSensorBeacon()
	{
	}

	private void WLGP25_DebugShowIslandMoveLine(object[] data)
	{
	}

	private void RefreshRevivePointShopIcon()
	{
	}

	private void OnShowRevivePointBuffShopIconOnMap(bool showRevivePointBuffShopIcon)
	{
	}

	private void CreateRevivePointBuffShopIcon(uint revivePointId, Vector3 position)
	{
	}

	private void CreateRevivePointBuffShopIconAsync(uint revivePointId, Vector3 position)
	{
	}

	private void OnRevivePointBuffShopIconLoaded(uint ticket, bool success, UnityEngine.Object resource)
	{
	}

	private void ClearAllRevivePointBuffShopIcons()
	{
	}

	public void ShowMapMarkIconByTeamIndexEventWrapper(object[] param)
	{
	}

	public void HideMapMarkIconByIndexEventWrapper(object[] param)
	{
	}

	private void RemoveAllScanByTypeResult()
	{
	}

	private void OnSyncScanByTypeResult(object[] param)
	{
	}

	private bool ShouldHandleOnMap(Vector3 pos, bool delete)
	{
		return false;
	}

	private bool ShouldHandleOnMapSimple()
	{
		return false;
	}

	public bool HasHomerUAVByLocalPlayer()
	{
		return false;
	}

	public UITexture GetMapBGTexture()
	{
		return null;
	}

	public bool IsMapLegendOpen()
	{
		return false;
	}

	private void GetLegendIcons(string spriteName, ref List<GameObject> list)
	{
	}

	public List<string> GetMapLegendData()
	{
		return null;
	}

	private void OnMapLegendItemToggleChanged(object[] data)
	{
	}

	public void OnMapLegendChange(string key, bool value)
	{
	}

	private void TryAddPOIDisplayAreaMapLegend(HashSet<string> hashSet)
	{
	}

	private static void TryAddMapLegendByIcon(HashSet<string> hashSet, string iconName)
	{
	}

	private void _003CSyncTeamateState_003Eb__397_0()
	{
	}

	private void _003COnObservePlayerMinimap_003Eb__455_0()
	{
	}

	private void _003COnShowCandyHotzoneOnMap_003Eb__650_0()
	{
	}

	private void _003COnCreateNBGroundHole_003Eb__670_0()
	{
	}

	private void _003COnPlayerHPChangedMinimap_003Eb__750_0()
	{
	}

	private void _003CRefreshDetectiveEffect_003Eb__828_0()
	{
	}

	private void _003COnGlobalMissionKingChanged_003Eb__865_0(uint _tick, bool _succ, UnityEngine.Object _inst)
	{
	}

	private void _003CShowVehicleScanRange_003Eb__873_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnRecyle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
