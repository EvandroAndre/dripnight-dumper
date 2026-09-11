using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW;

public class UIMapUtil
{
	public class DrawCacheInfo
	{
		private bool m_UseOwnShaderDrawCache;

		public Vector3 InnerCenter;

		public float InnerWidth;

		public float InnerLength;

		public Vector3 InnerForward;

		public float InnerRadius;

		public Vector3 OuterCenter;

		public float OuterWidth;

		public float OuterLength;

		public Vector3 OuterForward;

		public Vector4 OuterColor;

		public float OuterRadius;

		private Vector4 m_CachedShaderOuterInnerCenter;

		private Vector4 m_CachedShaderRadii;

		private Vector4 m_CachedShaderLineWidth;

		public Vector4 GetCachedShaderOuterInnerCenter()
		{
			return default(Vector4);
		}

		public void SetCachedShaderOuterInnerCenter(Vector4 v)
		{
		}

		public Vector4 GetCachedShaderRadii()
		{
			return default(Vector4);
		}

		public void SetCachedShaderRadii(Vector4 v)
		{
		}

		public Vector4 GetCachedShaderLineWidth()
		{
			return default(Vector4);
		}

		public void SetCachedShaderLineWidth(Vector4 v)
		{
		}

		public void Reset()
		{
		}
	}

	public enum EMapType
	{
		Minimap,
		Bigmap,
		Sidemap,
		ExtraMiniMap
	}

	public enum ESafezoneType
	{
		Outer,
		Inner,
		Next,
		InnerDotted
	}

	public class MapOffsetContext
	{
		private Vector4 m_Offset;

		private readonly bool m_MapOffsetUsingNew;

		public Vector4 Offset => default(Vector4);

		public float MinOffsetX => 0f;

		public float MaxOffsetX => 0f;

		public float MinOffsetZ => 0f;

		public float MaxOffsetZ => 0f;

		public float ZoneDiameter => 0f;

		public float OffsetScaleRatioX => 0f;

		public Vector3 Center => default(Vector3);

		public MapOffsetContext(Vector4 offset)
		{
		}

		public void UpdateOffset(Vector4 offset)
		{
		}

		public static MapOffsetContext CreateFromMapID(uint serverMapID)
		{
			return null;
		}

		public static MapOffsetContext CreateFromCurrent()
		{
			return null;
		}

		public bool IsPositionValidInBlueTearsMap(Vector3 pos)
		{
			return false;
		}
	}

	public static Dictionary<int, uint> NamePlateColorDict;

	public static Dictionary<int, uint> NamePlateColorDict4CS;

	public static int NAME_PLATE_COLOR_COUNT;

	public static int NAME_PLATE_COLOR_COUNT_CS;

	private static readonly int OuterColorPropertyID;

	private static readonly int OuterInnerCenterPosPropertyID;

	private static readonly int NextCircleCenterPosPropertyID;

	private static readonly int DottedCircleCenterPosPropertyID;

	private static readonly int CircleRadiusPropertyID;

	private static readonly int CircleLineWidthPropertyID;

	private static readonly int GlobalMissionZonePropertyID;

	private static readonly int VehicleChipScanRangeZonePropertyID;

	private static readonly int OuterCenterForwardPropertyID;

	private static readonly int OuterSizePropertyID;

	private static readonly int OuterCircleLineWidthPropertyID;

	private static readonly int InnerCenterForwardPropertyID;

	private static readonly int InnerSizePropertyID;

	private static readonly int TechBuildSafeZone;

	public static readonly int InfoType_InfoBox;

	public static readonly int InfoType_GlobalMission;

	public static readonly int InfoType_TechBuilding;

	public static Vector4 DEFAULT_MAP_OFFSET;

	public static Dictionary<uint, Vector4> MAPOFFSET_DICT;

	private static Vector4 CurrentMapOffset;

	private static MapOffsetContext CurrentMapOffsetContext;

	public const float ZONE_DIAMETER_MAP = 1024f;

	public static float MAP_WIDTH;

	public static float MAP_DOTTED_WIDTH;

	public static float MAP_DOTTED_WIDTH_SCALE;

	public static float OUTER_LINEWIDTH;

	public static float MAP_OUTZONE_TRANSPARENCY;

	private static Vector3 m_InnerCenterPos;

	private static Vector3 m_InnerZoneScale;

	public static Vector4 OUTER_COLOR_BLUE;

	public static Vector4 OUTER_COLOR_WHITE;

	public static Vector4 OUTER_COLOR_TRANSPARENT;

	public static Vector4 SAFE_ZONE_CHOOSE_MASK_OUTER_COLOR;

	public static Vector4 COLOR_CELL_GAME_CIRCLE_BG;

	public static Vector4 COLOR_CELL_GAME_CIRCLE_RING;

	public const string DEFAULT_MAP_RES_NAME = "minimap_bermuda";

	private const int DRAW_CACHE_INFO_COUNT = 4;

	private static readonly DrawCacheInfo[] m_arrCacheInfo;

	private static readonly bool[] m_arrCacheInfoValid;

	private static readonly DrawCacheInfo s_FallbackCacheInfo;

	private static Vector4 s_GlobalCachedShaderOuterInnerCenter;

	private static Vector4 s_GlobalCachedShaderRadii;

	private static Vector4 s_GlobalCachedShaderLineWidth;

	private static Dictionary<int, string> m_TeamSpritesDict;

	private static Dictionary<int, string> m_TeamSpritesDict2;

	private static readonly int[] EradicateZoneCenterPosPropertyIDs;

	private static readonly int CircleRadiusOuterPropertyID;

	private static readonly int CircleRadiusInnerPropertyID;

	private static Vector4 m_CacheCircleRadiusOuter;

	private static Vector4 m_CacheCircleRadiusInner;

	private static Vector4 m_CacheLineWidth;

	private static int UGCSafeZoneIndex;

	public static float MIN_OFFSET_X => 0f;

	public static float MAX_OFFSET_X => 0f;

	public static float MIN_OFFSET_Z => 0f;

	public static float MAX_OFFSET_Z => 0f;

	private static float ZONE_DIAMETER => 0f;

	public static uint GetNamePlateColor(byte teamId, bool skipModeCheck = false)
	{
		return 0u;
	}

	public static void InitCurrentMapOffset(uint serverMapID)
	{
	}

	public static void UpdateMapOffset(Vector4 offset)
	{
	}

	public static Vector4 GetCurrentGlobalMapOffset()
	{
		return default(Vector4);
	}

	public static MapOffsetContext GetCurrentGlobalMapOffsetContext()
	{
		return null;
	}

	private static DrawCacheInfo[] CreateDrawCacheInfos()
	{
		return null;
	}

	private static DrawCacheInfo GetDrawCacheInfo(EMapType mapType, Material mat)
	{
		return null;
	}

	public static void InitializeDrawCacheInfoFromShaderMaterial(DrawCacheInfo cacheInfo, Material mat)
	{
	}

	public static bool IsMiniMapLikeMap(EMapType mapType)
	{
		return false;
	}

	public static Vector3 GetCenter()
	{
		return default(Vector3);
	}

	public static void SetVector4OnBothTextureMaterials(UITexture texture, int propertyNameID, Vector4 value)
	{
	}

	private static void UpdateOuterMaterialColor(Material material, Vector4 color)
	{
	}

	public static void ResetCachedData(bool excludeNextCircle = false)
	{
	}

	internal static void DisableSafezone(SafeZone currentSafeZone, UITexture map)
	{
	}

	public static void SetCircleSafezone(UITexture map)
	{
	}

	public static bool IsShowAirLine()
	{
		return false;
	}

	public static bool IsMiniMapHideCloseBigMapTips()
	{
		return false;
	}

	public static void SetRectangleSafezone(UITexture map)
	{
	}

	internal static void HideVehicleScanRangeCircle(UITexture circle)
	{
	}

	public static void SetGameObjectActive(GameObject go, bool active)
	{
	}

	public static float SimThunderStormRadius(IBKPOGGBIEA.FOPKPNPCFBK thunderStormEvent)
	{
		return 0f;
	}

	public static void SetTeamateSpriteByIndex(TeammateGameObject teamGo, int idx, BHGGAEEHJCO playerId)
	{
	}

	public static void SetTeamateSpriteByIndex2(TeammateGameObject teamGo, int idx)
	{
	}

	public static void PlayerStartFiring(GameObject firing)
	{
	}

	public static TeammateGameObject CreateTeammateGameObject(GameObject teammate)
	{
		return null;
	}

	public static MapUIDeadBox CreateDeadBox(GameObject deadBox)
	{
		return null;
	}

	public static void ResetEradicateZoneCachedData()
	{
	}

	internal static void DisableEradicateZone(UITexture map)
	{
	}

	public static void FlushUGCEradicateZoneRadiusData(UITexture map)
	{
	}

	private static void UpdateUGCMapMask(Material material, int index, Vector2 outerC, Vector2 innerC)
	{
	}

	internal static void SpecifiedSafeZoneInvalid(UITexture circle, int showType)
	{
	}

	public static OPICPDCLKAG GetMarkObjectType(uint itemMarkId)
	{
		return OPICPDCLKAG.Invalid;
	}

	public static float GetBloodmoonGPMarkInteractingHalfExtent(float fallbackHalfExtent)
	{
		return 0f;
	}

	public static Vector2 ProjectToMapOffset(Vector2 pos2D, MapOffsetContext ctx)
	{
		return default(Vector2);
	}

	public static Vector2 WorldPos2MapLocalPos(Vector3 pos, MapOffsetContext ctx)
	{
		return default(Vector2);
	}

	public static float ProjectToMapRadius(float radius, MapOffsetContext ctx)
	{
		return 0f;
	}

	public static Vector3 ProjectToWorldOffset(Vector2 pos2D, MapOffsetContext ctx)
	{
		return default(Vector3);
	}

	public static Vector2 ProjectToMapOffsetUnlimited(Vector2 pos2D, MapOffsetContext ctx)
	{
		return default(Vector2);
	}

	public static Vector2 ProjectToUVPos(Vector2 pos2D, MapOffsetContext ctx)
	{
		return default(Vector2);
	}

	private static void UpdateMaterialCenterPos(Material material, ESafezoneType type, Vector3 pos, DrawCacheInfo cacheInfo, MapOffsetContext ctx)
	{
	}

	private static void UpdateMaterialCircleRadius(Material mat, ESafezoneType type, float radius, float lineWidth, DrawCacheInfo cacheInfo, MapOffsetContext ctx)
	{
	}

	private static void UpdateMaterialRectCommon(Material material, ESafezoneType type, Vector3 pos, float length, float width, Vector3 forward, float lineWidth, MapOffsetContext ctx)
	{
	}

	private static void UpdateInnerCircleMaterial(Material material, Vector3 pos, float radius, DrawCacheInfo cacheInfo, MapOffsetContext ctx)
	{
	}

	private static void UpdateInnerDottedCircleMaterial(Material material, Vector3 pos, float radius, DrawCacheInfo cacheInfo, MapOffsetContext ctx)
	{
	}

	private static void UpdateNextCircleMaterial(Material material, Vector3 pos, float radius, DrawCacheInfo cacheInfo, MapOffsetContext ctx)
	{
	}

	private static void UpdateOuterCircleMaterial(Material material, Vector3 pos, float radius, Vector4 color, DrawCacheInfo cacheInfo, MapOffsetContext ctx)
	{
	}

	private static void UpdateInnerRectMaterial(Material material, Vector3 pos, float length, float width, Vector3 forward, MapOffsetContext ctx)
	{
	}

	private static void UpdateOuterRectMaterial(Material material, Vector3 pos, Vector4 color, float length, float width, Vector3 forward, MapOffsetContext ctx)
	{
	}

	private static void DrawInnerCircleZone(UITexture circle, Vector3 pos, float radius, DrawCacheInfo cacheInfo, MapOffsetContext ctx)
	{
	}

	private static void DrawInnerDottedCircleZone(UITexture circle, Vector3 pos, float radius, DrawCacheInfo cacheInfo, MapOffsetContext ctx)
	{
	}

	private static void DrawInnerRectZone(UITexture circle, Vector3 pos, float width, float length, Vector3 forward, MapOffsetContext ctx)
	{
	}

	private static void DrawOuterCircleZone(UITexture circle, Vector3 pos, float radius, Vector4 color, DrawCacheInfo cacheInfo, MapOffsetContext ctx)
	{
	}

	private static void DrawOuterRectZone(UITexture circle, Vector4 color, Vector3 pos, float width, float length, Vector3 forward, MapOffsetContext ctx)
	{
	}

	public static void SetSafeZoneInvisible(UITexture map, ESafezoneType type, EMapType mapType, MapOffsetContext ctx)
	{
	}

	internal static void ShowVehicleScanRangeCircle(UITexture circle, Vector3 rangeCenter, float radius, MapOffsetContext ctx)
	{
	}

	private static void UpdateInnerCenterPosScale(SafeZone currentSafeZone, MapOffsetContext ctx)
	{
	}

	private static void DrawInnerBorder(UITexture circle, SafeZone currentSafeZone, EMapType mapType, MapOffsetContext ctx)
	{
	}

	private static void DrawOuterBorder(UITexture circle, SafeZone currentSafeZone, Vector4 color, EMapType mapType, bool forceRefresh, MapOffsetContext ctx)
	{
	}

	internal static void UpdateSafeZone(SafeZone currentSafeZone, UITexture map, bool isGameSafeZoneIgnoreFirstOne, EMapType mapType, bool forceRefresh, MapOffsetContext ctx)
	{
	}

	internal static void UpdateGuideToSaveZone(SafeZone currentSafeZone, UISprite guideToSaveZone, Vector3 playerPos, bool forceDeactive, EMapType mapType, MapOffsetContext ctx, UITexture safeZoneShaderSource)
	{
	}

	public static void UpdateBombArea(IBKPOGGBIEA bombManager, GameObject bombParent, GameObject bombInstance, List<GameObject> bombAreas, MapOffsetContext ctx)
	{
	}

	public static void UpdateTeammatePosition(TeammateGameObject teamGo, Vector3 pos, float angle, MapOffsetContext ctx)
	{
	}

	public static void UpdateEnemyPosition(GameObject enemyGo, Vector3 pos, float angle, MapOffsetContext ctx)
	{
	}

	public static void UpdateBombPosition(GameObject bomb, Vector3 pos, float angle, MapOffsetContext ctx)
	{
	}

	internal static void UpdateSpecifiedSafeZone(SafeZone currentSafeZone, NBBLCLAMOEJ.IGCKMAPHNEL data, UITexture circle, int showType, MapOffsetContext ctx)
	{
	}

	internal static void UpdateNextSafeZone(SafeZone currentSafeZone, DHMHEMOLMEJ infoboxData, UITexture nextInnerCircle, EMapType mapType, MapOffsetContext ctx)
	{
	}

	public static void UpdateUGCSafeZone(UITexture map, Vector3 outerC, float outerR, Vector3 innerC, float innerR, MapOffsetContext ctx)
	{
	}

	private static void UpdateUGCEradicateZoneRadius(int index, float innerR, float outerR, MapOffsetContext ctx)
	{
	}

	public static void UpdateUGCEradicateZoneRadius(AEGHGLECJMB zone, MapOffsetContext ctx)
	{
	}

	internal static void UpdateUGCEradicateZonePos(Material material, AEGHGLECJMB zone, MapOffsetContext ctx)
	{
	}

	public static void UpdateUGCEradicateZonePos(UITexture map, AEGHGLECJMB zone, MapOffsetContext ctx)
	{
	}

	internal static void ShowSafeZoneChooseMask(UITexture circle, NBBLCLAMOEJ.IGCKMAPHNEL data, Vector4 maskColor, MapOffsetContext ctx)
	{
	}

	public static void SetupAirLine(UISprite airline_start, UISprite airline_end, UISprite airline, MapOffsetContext ctx)
	{
	}

	internal static void SetCSGameZone(SafeZone currentSafeZone, GameObject zoneTemplate, Transform tr, List<UIHudCSGameZoneView> CSGameZone, MapOffsetContext ctx)
	{
	}

	internal static void SetBombZone(SafeZone currentSafeZone, Dictionary<uint, UIHudBombZoneView> zones, bool isMiniMap, MapOffsetContext ctx)
	{
	}

	internal static void SetBombZone(Vector3 zonecenter, uint zoneIndex, UIHudBombZoneView zoneView, MapOffsetContext ctx)
	{
	}

	public static void UpdateZeppelinPosition(GameObject zeppelin, Vector3 pos, MapOffsetContext ctx)
	{
	}

	public static void UpdateSafeZoneCircleShow(Material material, bool show, MapOffsetContext ctx)
	{
	}

	public static void UpdateSafeZoneForReplay(UITexture map, Vector3 outerCenter, float outerRadius, Vector3 innerCenter, float innerRadius, EMapType mapType, MapOffsetContext ctx)
	{
	}
}
