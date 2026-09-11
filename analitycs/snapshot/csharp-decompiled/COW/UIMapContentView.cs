using GCommon;
using UnityEngine;

namespace COW;

public class UIMapContentView : UIBaseView
{
	public Transform MapPanel;

	public GameObject mushroom;

	public UITexture MapBG;

	public GameObject WorkMapRoot;

	public UITexture WorkShopItemMap;

	public UITexture WorkShopItemMapOutline1;

	public UITexture WorkShopItemMapOutline2;

	public UITexture WorkShopItemMapOutline3;

	public UITexture WorkShopItemMapOutline4;

	public UITexture WorkShopItemMapShadow;

	public UITexture workShopMapBg;

	public UITexture MapGrid;

	public GameObject BombDangerArea;

	public GameObject BombDangerInstance;

	public GameObject WarningZoneArea;

	public GameObject HotzoneContainer;

	public GameObject HotzoneArea;

	public UISprite GuideToMark;

	public TweenAlpha GuideToMarkTween;

	public UISprite warningToSafeZone;

	public Transform warningArrow;

	public UISprite GuideToSaveZone;

	public GameObject OBAirtransporter;

	public GameObject PlayerArrow;

	public UISprite PlayerArrowSprite;

	public TweenAlpha UavPlayerArrow;

	public GameObject Arrow;

	public GameObject TeamMate;

	public GameObject id;

	public GameObject direction;

	public GameObject knockdown;

	public GameObject dead;

	public GameObject QuickChatEffect;

	public GameObject TeammatePoints;

	public UISprite TeammatePoint1;

	public UISprite TeammatePoint2;

	public UISprite TeammatePoint3;

	public UISprite UavPoint;

	public UISprite DetectorPoint;

	public UISprite CarIcon;

	public Transform Uav;

	public UIUAVMapObjectView UAVObjectView;

	public UISprite UavCircle;

	public TweenScale UavCircleLine;

	public Transform Bounty;

	public UISprite MarkCircle;

	public TweenAlpha MarkerTween;

	public TweenScale MarkCircleLine;

	public UISprite DirectionHint;

	public TweenAlpha DirectionHintTween;

	public Transform Detector;

	public UISprite DetectorCircle;

	public TweenScale DetectorCircleLine;

	public Transform AirlineContainer;

	public UISprite AirLine;

	public UISprite AirLinePointStart;

	public UISprite AirLinePointEnd;

	public Transform OBPlayerContainer;

	public UISprite SpectatorAirDrop;

	public GameObject TreasureMark;

	public GameObject CampFire;

	public GameObject Carepackage;

	public LastVehicleObject LastVehicleUIObject;

	public GameObject MapMarks;

	public GameObject MapMark;

	public UISprite Mark;

	public GameObject MapMark2;

	public UISprite Mark2;

	public GameObject MapMark3;

	public UISprite Mark3;

	public GameObject MapMark4;

	public UISprite Mark4;

	public GameObject Zombie;

	public GameObject EnermyPoint;

	public GameObject TeleportDoor;

	public GameObject MaxHypePlayerPoint;

	public GameObject AirDropNext;

	public GameObject ToxicZoneArea;

	public GameObject ToxicZoneInstance;

	public GameObject csZone;

	public GameObject gamezone;

	public GameObject CandyZoneIcon;

	public GameObject Pumpkin;

	public PlayerPumpkinInfo PlayerPumpkin;

	public GameObject GeneratedBuff;

	public GameObject ItemGenerator;

	public GameObject bombZone;

	public GameObject bombZoneTemplate;

	public UISprite BombPickup;

	public GameObject zeppelinContainer;

	public UISprite zeppelin;

	public UISprite zeppelinDestination;

	public UISprite zeppelinDirection;

	public Transform zeppelinArrow;

	public UISprite ReaperPlayer;

	public UISprite DetectiveMarkPoint;

	public UISprite EscortVehicle;

	public GameObject DetectiveEffectObj;

	public GameObject DetectiveEffect;

	public GameObject DeliveryMarkEnermyPoint;

	public GameObject RevivePointContainer;

	public GameObject IngameShopPointContainer;

	public GameObject IngameShopPointIcon;

	public GameObject BountyContract;

	public UISprite WereWolvesBody;

	public UILabel WereWolvesBodyName;

	public GameObject TaskPoint;

	public GameObject randomCenter;

	public GameObject EmergencyTaskPoint;

	public GameObject TrapIcon;

	public UISprite WSMapIconItem;

	public GameMissionPlayerRangeView WantedPlayerRange;

	public GameObject obevent;

	public GameObject obeventDragContainer;

	public GameObject DeadBox;

	public GameObject EnergyStoneBox;

	public UILabel TeamMateIDLable;

	public GameObject MapBGMask;

	public GameObject VFX_BombPickup;

	public UISprite PlayerArrowShadow;

	public UISprite DetectiveEffectExtend;

	public GameObject KillerKing;

	public GameObject FateRandomBornTeamZone;

	public GameObject ugcSupplyBoxTriggerContainer;

	public UISprite ugcSupplyBoxTrigger;

	public UIMapBossZoneView BossZone;

	public GameObject Aircraft;

	public GameObject AirDropIcon;

	public GameObject ResidueAirLine;

	public Transform LockAirDropContainer;

	public GameObject IconCtrl;

	public UITexture ResidueAirLineUITexture;

	public GameObject SafeZoneMoveArrow;

	public GameObject ArrowStart;

	public Transform SafeZoneMoveVFX;

	public Transform SafeZoneMoveScale;

	public GameObject SlowDownMarkPoint;

	public UIMapObjectRadarView Radar;

	public UISprite RadarPreScanCircle;

	public UISprite PreScanCircleLine;

	public GameObject ReviveMarkFateRandom;

	public GameObject ReviveMarkFateRandomNormal;

	public GameObject ReviveMarkFateRandomDanger;

	public GameObject RevivePosFateRandom;

	public GameObject MetropolisAreaContainer;

	public UISprite instrumentIcon;

	public GameObject BeMarkedEffect;

	public GameObject IngameStropPointContainer;

	public GameObject IngameStropPointIcon;

	public GameObject BanHighZoneEnemy;

	public GameObject ReviveMissionVfxRoot;

	public UISprite SanitoDummy;

	public GameObject GeekSpiderBomb;

	public UISprite LevelLuckyDrawBox;

	public GameObject ScanChipVehicle;

	public GameObject NewLabel;

	public GameObject CSRoundDragon;

	public Transform DynamicPanel;

	public GameObject BountyBoxIcon;

	public GameObject AirDropSignalFlareIcon;

	public Transform CabinMapObjParent;

	public GameObject AirDropIceDestructibleIcon;

	public GameObject AirDropIceDestructibleSignalFlareIcon;

	public GameObject SuggestJump;

	public UISprite SuggestJumpIcon;

	public UISprite SuggestJumpConnectLine;

	public UISprite SuggestJumpThresline;

	public GameObject NBGoundHole;

	public GameObject SuggestJumpEffect_Mark;

	public GameObject SuggestJumpEffect_Reach;

	public GameObject WeRunRetreatPointIcon;

	public TweenWidth SuggestJumpConnectLineLight;

	public Transform ArcGeneratorContainer;

	public GameObject HippoCrisisBoxIcon;

	public UITexture MapMask;

	public Transform SensorBeaconScan;

	public GameObject TarkovBoss;

	public GameObject NBHotzoneArea;

	public UISprite DarkCircle;

	public GameObject SummonerBoxIcon;

	public UISprite SummonerBoxIconArrow;

	public GameObject ReviveCheckTrans;

	public UISprite HotzoneEffectArea;

	public UISprite TeamRallyIcon;

	public MiniMapVehicleHorse DetectorCar;

	public GameObject Bloodmoon_GpContainer;

	public GameObject AirDropVariantIcon;

	public VFXCreateHelper UIFXReviveBox;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
