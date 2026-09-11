using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.Graphics;

public class SceneGraphics : MonoSingleton<SceneGraphics>
{
	[Serializable]
	public class LightSettings
	{
		public float charaLightIntensityOff;

		public float charaLightIntensityOn;

		public Vector4 m_backLightDir;

		public Vector4 m_backLightColor;

		public Vector3 lightRot;

		public Color lightColor;

		public float lightIntensity;

		public float shadowStrength;

		public Color ambientColor;

		public Color fogColor;

		public float fogStartDistance;

		public float fogEndDistance;

		public LightSettings Clone()
		{
			return null;
		}
	}

	public enum MaterialType
	{
		DepthCull,
		StencilCull,
		StencilWrite,
		NDotV
	}

	public delegate void OnTerrainPreviewProc(Material mat);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<GameObject> _003C_003E9__295_0;

		internal bool _003CUpdateExchangeWater_003Eb__295_0(GameObject water)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass265_0
	{
		public HashSet<NetworkMaterialInfo> network_mats;

		internal void _003CHandleDefaultTextureForIngameCDN_003Eb__0(uint tid, bool ret, UnityEngine.Object res)
		{
		}
	}

	public Texture2D m_terrainShadowTex;

	public List<GameObject> m_waterGO;

	private List<Material> m_waterMat;

	public Vector3 m_lightDirection;

	public Vector4 m_waterPosition;

	public float m_mapWidth;

	public float m_mapHeight;

	public float m_mapStartPosX;

	public float m_mapStartPosZ;

	public float m_mapCenterX;

	public float m_mapCenterZ;

	public float m_shadowSizeX;

	public float m_shadowSizeZ;

	private bool m_hasProperties;

	public bool m_forceOffFogSwitch;

	public float m_landFogStartDensity;

	public float m_landFogEndDensity;

	public float m_landFogSwitchHeight;

	public float m_landFogSwitchSpeed;

	private int m_switchDensInc;

	private float m_curDensity;

	public bool m_fogDistantSwitch;

	public float m_fogDistantSwitchSpeed;

	public float m_skyFogDistantStart;

	public float m_skyFogDistantEnd;

	public float m_landFogDistantStart;

	public float m_landFogDistantEnd;

	private int m_switchStartDistInc;

	private int m_switchEndDistInc;

	private float m_curStartDistant;

	private float m_curEndDistant;

	private bool m_switchFog;

	public float m_vegPreviewHeight;

	public int m_treeGroupPSNum;

	public bool m_isInVegPreview;

	public Texture2D lutTexture;

	public Color skyboxColor;

	public float charaLightIntensityOff;

	public float charaLightIntensityOn;

	private GameObject _EnvLight;

	public List<DynamicGeneratorGroup> m_dynamicGenGroupList;

	private Camera m_camera;

	private float m_switchWaterTrans;

	private float m_switchWaterTransSpeed;

	public float m_waterTransThres;

	private bool m_isWaterTransDone;

	private PostEffectManager m_posteffect;

	public GameObject m_farWaterGO;

	public Color m_farWaterColor;

	private Material m_farWaterMat;

	public float m_farWaterFadeSpeed;

	private float m_farWaterFadeCoeff;

	private bool m_isFarWaterFadeDone;

	private GameObject m_nearWaterGO;

	private Color skyboxOriginalColor;

	private DynamicGeneratorManager m_dynamicGeneratorMan;

	private APELCIGCHDJ m_Spectator;

	private bool _003CSwitchCameraPerspective_003Ek__BackingField;

	private bool _003CSwitchCameraPerspectiveColor_003Ek__BackingField;

	private MNMBLBKENMK m_graphQuality;

	public GameObject m_treeOrnamentGO;

	private Material m_nightSkyMat;

	private Transform m_camTransform;

	private GameObject m_snowFlakeGO;

	private ParticleSystem m_snowFlakeParticle;

	private bool m_snowFlakeEnable;

	public bool m_isNightMode;

	public bool m_forceOffNightMode;

	public bool m_isDawnMode;

	public bool m_forceOffDawnMode;

	public bool m_isSnowMode;

	public bool m_forceOffSnowMode;

	public Material m_treeShadowMat;

	private bool m_backLightEnabled;

	public Vector4 m_backLightDir;

	public Vector4 m_backLightColor;

	public GameObject m_terrainGO;

	private Renderer[] m_terrainRenderers;

	public GameObject m_terrainGOPreview;

	public GameObject m_cloudGOPreview;

	public GameObject m_buildingGOPreview;

	public float m_switchTerrainHeightStart;

	public float m_switchTerrainHeightEnd;

	private Dictionary<Material, Texture> m_terrainMatDict;

	private Dictionary<string, Texture> m_previewTerrainLMDict;

	private List<Material> m_terrainMatList;

	public Material m_terrainMatPreview;

	public Material m_terrainMatPreviewOpaque;

	private List<GameObject> m_terrainExchangeGO;

	private List<Renderer> m_terrainExchangeRenderers;

	private List<GameObject> m_terrainExchangeGOPreview;

	private List<GameObject> m_buildingExchangeGOPreview;

	private List<Material> m_terrainExchangeMatPreview;

	private List<Material> m_terrainExchangeMatPreviewOpaque;

	private List<Material> m_terrainExchangeMatList;

	private Dictionary<Material, Texture> m_terrainExchangeMatDict;

	private Dictionary<string, Texture> m_previewTerrainExchangeLMDict;

	private List<Material> m_buildingExchangeMatPreviewArray;

	public float m_blendingInnerRadius;

	public float m_blendingOuterRadius;

	private List<Material> m_cloudMatPreview;

	private Material[] m_buildingMatPreviewArray;

	private bool m_buildMatNeedUnload;

	private bool m_isHDMode;

	private bool m_switchTerrainDone;

	private bool m_unloadPreivewData;

	public GameObject m_sandStormGO;

	private ParticleSystem m_sandStormParticle;

	private bool m_sandStormEnable;

	public float m_lowestFogDensity;

	public bool m_IsDesertMap;

	public bool m_IsNeoParadiseMap;

	public bool m_IsWereWolvesMap;

	public bool m_skyBoxSwitch;

	private Material m_sapSkyMat;

	private Material m_AvatarTraceMat;

	private Material m_TeammateMat;

	private Material m_AvatarTraceSpecialMat;

	private Material m_TeammateSpecialMat;

	public Material m_StencilMat;

	private int m_AvatarTraceColorPropertyToID;

	private int m_AvatarTraceMaxMinPropertyToID;

	private int m_AvatarTraceMaxWidthPropertyToID;

	private int m_AvatarTraceMinWidthPropertyToID;

	private int m_AvatarTraceDepthlOpPropertyToID;

	private int m_AvatarTraceStencilOpPropertyToID;

	private static uint CDNCONFIG_PONY_CDNID;

	private Dictionary<string, TextureOverride> m_NeedOverridedTextures;

	private HashSet<DynamicGeneratorManager.DynamicPrefabMesh> m_RegistedDynamicMesh;

	private string m_CurrentCDNUrl;

	private HashSet<NetworkMaterialInfo> m_NetworkMaterials;

	private Dictionary<int, HashSet<NetworkMaterialInfo>> m_NetMatMap;

	private bool m_IsRunningDownload;

	private ENetworkMaterialGroup m_CurrentDownloadingGroup;

	private Dictionary<uint, HashSet<NetworkMaterialInfo>> m_CDNNetMatMap;

	private Dictionary<uint, HashSet<NetworkMaterialInfo>> m_RegisteredCDNNetMatMap;

	private Dictionary<int, HashSet<NetworkMaterialInfo>> m_ActivityTypeMatMap;

	private Dictionary<string, int> m_CDNUrlStyleAndTypeMap;

	private List<Texture> m_AirTransPorterTextures;

	private Dictionary<string, uint> m_CDNNetIdMap;

	public OnTerrainPreviewProc InitTerrainPreviewProc;

	public OnTerrainPreviewProc PrepareTerrainPreviewOpaqueMatProc;

	public OnTerrainPreviewProc TerrainPreviewBlendMatProc;

	public OnTerrainPreviewProc ResumeTerrainMatProc;

	public OnTerrainPreviewProc NoPreviewInitTerrainProc;

	private bool m_EnableUpdateNearWaterForLowQuality;

	private bool m_TriggerUpdateNearWaterForLowQuality;

	private int m_PlayerHeight;

	private List<Material> m_UpdateNearWaterForLowQualityMats;

	public List<Material> EnvWeatherWaterMaterialsForABMap;

	public TreeSystem CurTreeSystem;

	public GrassSystem CurGrassSystem;

	public VegetationManager CurVegetationManager;

	private int m_NumStreamerCollider;

	private int m_FogColor;

	private int m_FadeCoeff;

	private int m_MapPos;

	private int m_NeedFade;

	private int m_TimeOverride;

	private int m_FadeFactor;

	private int m_ZWrite;

	private int m_WholeDiffuse;

	private bool m_Inited;

	[NonSerialized]
	private LightSettings m_backupSetting;

	[NonSerialized]
	private LightSettings m_overrideSetting;

	public float LandFogEndDensity => 0f;

	public bool SwitchCameraPerspective
	{
		get
		{
			return _003CSwitchCameraPerspective_003Ek__BackingField;
		}
		private set
		{
			_003CSwitchCameraPerspective_003Ek__BackingField = value;
		}
	}

	public bool SwitchCameraPerspectiveColor
	{
		get
		{
			return _003CSwitchCameraPerspectiveColor_003Ek__BackingField;
		}
		private set
		{
			_003CSwitchCameraPerspectiveColor_003Ek__BackingField = value;
		}
	}

	public static bool IsProcValid(OnTerrainPreviewProc proc)
	{
		return false;
	}

	private void Start()
	{
	}

	private void WarmUpPonyShader()
	{
	}

	private void CheckCameraStatus()
	{
	}

	private void InitShaderPropertyVals()
	{
	}

	private void InitWater()
	{
	}

	private void CheckTerrainRenderersForSafeZoneSeam()
	{
	}

	private void InitTerrain()
	{
	}

	private void InitTerrainExchange()
	{
	}

	private void InitDynGenData()
	{
	}

	private void InitDaytimeMode()
	{
	}

	private GameObject GetEnvLight()
	{
		return null;
	}

	private void InitNightMode()
	{
	}

	private void InitDawnMode()
	{
	}

	private void InitSnowMode()
	{
	}

	private void InitEnvWeather()
	{
	}

	private void InitEnvWeatherWaterInfo()
	{
	}

	private void RegisterWaterMats(Transform waterObj)
	{
	}

	private void InitLowConfigFog()
	{
	}

	private void InitRTShadow()
	{
	}

	private void InitRTShadowExchange()
	{
	}

	private void InitHDMode()
	{
	}

	private void InitFog()
	{
	}

	public void InitDesertEffect()
	{
	}

	public void EnableCharacterBackLight()
	{
	}

	public void DisableCharacterBackLight()
	{
	}

	public void InitItemOutline()
	{
	}

	public void InitSceneLensFlares()
	{
	}

	private void ProcessSceneGraphicConfig()
	{
	}

	public void CreateDynamicManager()
	{
	}

	public void InitRegionActDynamicList(string[] activityParams)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void LateUpdate()
	{
	}

	public void SwitchSpecialWaitingLand(bool isWaiting)
	{
	}

	public void SetLUTEffect(EInGameFilterSetting filter, Camera camera = null)
	{
	}

	public void ResetCharaLightIntensity()
	{
	}

	public void SetBloomEnable(bool isEnable)
	{
	}

	public void SetBloomValue(float ultraIntensity, float ultraThreshold, float ultraSoftKnee, float ultraDiffusion, Color BloomColor)
	{
	}

	public void SetBloomMask()
	{
	}

	private void UpdateWater()
	{
	}

	private void UpdateCloudPreview(float fadeFactor)
	{
	}

	private void UpdateBuildingsPreview(float fadeFactor)
	{
	}

	private void UpdateExchangeBuildingsPreview(float fadeFactor)
	{
	}

	private void UpdateTerrainPreviewAll(float fadeFactor)
	{
	}

	private void UpdateTerrainPreview(float fadeFactor)
	{
	}

	private void UpdateTerrainExchangePreview(float fadeFactor)
	{
	}

	private void UpdateTerrainLod()
	{
	}

	private void UpdateTerrain()
	{
	}

	private void UpdateFog()
	{
	}

	private void UpateDaytimeMode()
	{
	}

	private void UpdateNightMode()
	{
	}

	private void UpdateSkyBox()
	{
	}

	private void UpdateDawnMode()
	{
	}

	private void UpdateSnowMode()
	{
	}

	private void UpdateHDMode()
	{
	}

	private void UpdateDesertEffect()
	{
	}

	private void ReleaseTerrainPreviewRes()
	{
	}

	private void ReleaseTerrainExchangePreviewRes()
	{
	}

	private void CheckAndUnloadPreviewTex()
	{
	}

	private void CheckAndUnloadPreviewExchangeTex()
	{
	}

	private void ReleaseSeaPreviewRes()
	{
	}

	private bool HasDynGenData()
	{
		return false;
	}

	public void UpdateSpectator()
	{
	}

	private void UpdateNearWaterForLowQuality()
	{
	}

	public void TriggerUpdateNearWaterForLowQuality()
	{
	}

	public void SetCameraPerspective(bool enabled)
	{
	}

	public void SetCameraPerspectiveColor(bool stuffed)
	{
	}

	public void RegistTextureOverride(string name, TextureOverride texture_override)
	{
	}

	public void RegistDynamicPrefabMesh(DynamicGeneratorManager.DynamicPrefabMesh prefab_mesh)
	{
	}

	public Material CreateAndGetAvatarTraceMaterial(bool creatEnemy = true, MaterialType type = MaterialType.DepthCull)
	{
		return null;
	}

	public void SetTraceColor(Color color, bool creatEnemy = true)
	{
	}

	public void SetTraceMaxAndMinDistance(Vector4 maxMin, bool creatEnemy = true)
	{
	}

	public void SetTraceWidth(float maxWidth, float minWidth, bool creatEnemy = true)
	{
	}

	public Material CreateAndGetAvatarTraceSpecialMaterial(bool isEnemy, float magnificationRate)
	{
		return null;
	}

	public void SetTraceDepth(int depthOp, bool creatEnemy = true)
	{
	}

	public void SetRenderqueue(int renderQueue, bool creatEnemy = true)
	{
	}

	public void RegistNetworkMaterials(HashSet<NetworkMaterialInfo> network_mats, ENetworkMaterialGroup matType)
	{
	}

	public void OnRegionActiveTypeChanged()
	{
	}

	public void ApplyTextureOverrideType()
	{
	}

	public void RefreshDynamicPrefabMeshVisible()
	{
	}

	public void ApplyTrainingBillBoard()
	{
	}

	public void OnTriningBillBoardCDNFinish(ResultTextureInfo tex)
	{
	}

	public void ApplyBillboardCDNUrl()
	{
	}

	public void PreDownloadActivityCDNUrl(List<string> CDNUrls)
	{
	}

	public void ApplyArenaScreenCDNUrl()
	{
	}

	public void ApplyDownloadAllIngameCDNForNetworkMaterials()
	{
	}

	public void RegistIngameCDNNetworkMaterials(uint id, HashSet<NetworkMaterialInfo> network_mats, string defaultResourceID = null)
	{
	}

	public void DownloadIngameCDNForNetworkMaterials(uint id, HashSet<NetworkMaterialInfo> network_mats)
	{
	}

	public void DownloadTextureForActivityNetworkMaterials(int activityType, HashSet<NetworkMaterialInfo> network_mats)
	{
	}

	private void HandleDefaultTextureForIngameCDN(HashSet<NetworkMaterialInfo> network_mats, string defaultResourceID = null)
	{
	}

	private void StartDownloadTextureByIdAndUrl(uint id, string url)
	{
	}

	private void SetActivityDownloadTexture(int activityType, string url)
	{
	}

	public void StartDownloadTexture()
	{
	}

	public void CancelDownloadTexture()
	{
	}

	public void OnDownloadedTextureByCDNId(ResultTextureInfo resultInfo)
	{
	}

	private void AddAirTransPorterCdn(Texture tex)
	{
	}

	public void UnLoadAirTransPorterCdn()
	{
	}

	public void OnDownloadedTextureByStyleAndType(ResultTextureInfo resultInfo)
	{
	}

	public void OnDownloadedTexture(ResultTextureInfo resultInfo)
	{
	}

	public static void ChangeToPreZShader(ref Material target_mat)
	{
	}

	public static void ChangeToPreZV2Shader(ref Material target_mat, out Material depth_mat)
	{
		depth_mat = null;
	}

	public void OnCameraChanged(Camera target_cam)
	{
	}

	public void OnCameraUpdated()
	{
	}

	public void OnScreenShotRendering()
	{
	}

	public void OnSceneLoaded()
	{
	}

	public void RecordStreamerCollider()
	{
	}

	public void DeRecordStreamerCollider()
	{
	}

	public int GetStreamerColliderCount()
	{
		return 0;
	}

	public bool IsSwitchingTerrain()
	{
		return false;
	}

	public void OnDownloadFailed(CDNDownloadFailedInfo info)
	{
	}

	public bool OverrideLightSettings(LightSettings s)
	{
		return false;
	}

	public bool RestoreLightSettings()
	{
		return false;
	}

	public bool IsLightSettingsOverrided()
	{
		return false;
	}

	public LightSettings BackupLightSettingsRef()
	{
		return null;
	}

	private void OverridePendingLightSettingsInNeed()
	{
	}

	private void BackupLightSettings()
	{
	}

	private void ApplyLightSettings(LightSettings s)
	{
	}

	private static void UpdateSkyboxBlenderDefault()
	{
	}

	public void UpdateExchangeTerrain(GameObject terrainPreviewGO, GameObject housePreviewGO, GameObject terrainGO, GameObject cloudPreviewGO)
	{
	}

	public void UpdateExchangeWater(GameObject farSeaWaterGO, GameObject nearSeaWaterGO, List<GameObject> nearRvierWaterGO)
	{
	}

	public void UpdateExchangeEnvParameters(SceneGraphicsParameters para)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
