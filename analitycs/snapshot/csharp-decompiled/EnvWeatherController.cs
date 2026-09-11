using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

public class EnvWeatherController : MonoBehaviour
{
	private class EnvWeatherEffectStats
	{
		public readonly Material Material;

		public readonly float DefaultAlpha;

		public EnvWeatherEffectStats(Material mat)
		{
		}
	}

	public delegate void OnWeatherChanged(string weatherName);

	private sealed class _003CTweenWeather_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnvWeatherController _003C_003E4__this;

		public EnvWeatherPreset preset;

		public float duration;

		private float _003CtweenTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTweenWeather_003Ed__77(int _003C_003E1__state)
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

	private static EnvWeatherController _instance;

	public const string DefaultWeatherName = "Default";

	public static string PCWeatherName;

	public List<string> weatherEventNames;

	public List<EnvWeatherPreset> weatherPresets;

	public EnvWeatherPreset defaultPreset;

	private EnvWeatherPreset _003CcurrentPreset_003Ek__BackingField;

	private EnvWeatherPreset _003CtargetPreset_003Ek__BackingField;

	private EnvWeatherPreset outsideEnvZonePreset;

	private bool m_isRestoringOutsidePreset;

	public bool sunRotate;

	private bool hasSound;

	private bool soundChanged;

	private bool footstepsSoundUpdated;

	private OnWeatherChanged m_onWeatherChanged;

	public List<Material> waterMaterials;

	private Light mainLight;

	private LensFlare lensFlare;

	private Material skyboxMaterial;

	private Material runtimeSkyboxMaterial;

	private GameObject effectHolder;

	private Transform camTrans;

	private bool m_zoneInRoom;

	private bool m_playerInRoom;

	private bool m_playerUnderShelter;

	private float m_shelterCheckTime;

	private GMPGMPFNMFP m_Tmpinfo;

	private const float shelterCheckInterval = 0.333f;

	public List<ParticleSystem> particles;

	private List<float> particleEmissionRates;

	private readonly List<EnvWeatherEffectStats> m_WeatherEffectStats;

	private Dictionary<Material, int> m_lightObjectsMatCount;

	private AudioResource currentAudio;

	private List<ResourceID> m_footStepSounds;

	private Shader skyboxShader;

	private Shader skyboxBlendedShader;

	private IEnumerator weatherTweener;

	private bool isWeatherTweenerDone;

	private int defalutFogStartDistance;

	private int defalutFogEndDistance;

	private int currentWeatherID;

	private float tweenWeatherDuration;

	private float changeWeatherDuration;

	private GameObject effectKeeper;

	private static readonly int m_CloudBlendPropertyID;

	private static readonly int m_WaterFogColorID;

	private bool m_Islerp;

	private HashSet<EnvWeatherZone> m_EnvWeatherZones;

	private List<EnvWeatherZone> m_EnvWeatherZonesToUnRegister;

	private bool m_IsZoneBlend;

	private bool m_savedLensFlareEnabled;

	private bool m_lensFlareSuppressed;

	public static EnvWeatherController instance
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public EnvWeatherPreset currentPreset
	{
		get
		{
			return _003CcurrentPreset_003Ek__BackingField;
		}
		private set
		{
			_003CcurrentPreset_003Ek__BackingField = value;
		}
	}

	public EnvWeatherPreset targetPreset
	{
		get
		{
			return _003CtargetPreset_003Ek__BackingField;
		}
		private set
		{
			_003CtargetPreset_003Ek__BackingField = value;
		}
	}

	public Material OriginSkyboxMaterial => null;

	public Material ActiveSkyboxMaterial => null;

	public List<ResourceID> footStepSounds => null;

	public event OnWeatherChanged onWeatherChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void ChangeNextWeather()
	{
	}

	private GameObject GetResourceByName(string name)
	{
		return null;
	}

	private bool UnderShelterCheck(Player player, bool playerInRoom)
	{
		return false;
	}

	private void UpdateEffectTransform(Transform followTrans, bool playerUnderShelter)
	{
	}

	private void UpdateAudio(bool playerInRoom)
	{
	}

	public void SetZoneInRoom(bool zoneInRoom)
	{
	}

	public IEnumerator TweenWeather(EnvWeatherPreset preset, float duration)
	{
		return null;
	}

	private void TriggerWeatherChangedEvent()
	{
	}

	public void TriggerWeatherChangedEvent(string presetName)
	{
	}

	public void UpdateWeatherParameters(EnvWeatherPreset preset)
	{
	}

	private void EnsureFogShaderCompatibility()
	{
	}

	private void ChangeFogDistance(int start, int end)
	{
	}

	public void SetWeather(EnvWeatherPreset preset, bool force = false, bool changeEnvSound = true)
	{
	}

	private void SetWeatherInternal(EnvWeatherPreset preset, bool force = false, bool changeEnvSound = true)
	{
	}

	private bool PlayEnvSound(string soundLoopName, float volume)
	{
		return false;
	}

	private void StopCurrentEnvSound()
	{
	}

	private void UpdateFootstepsSound(EnvWeatherSound soundpreset)
	{
	}

	private bool IsSkyboxTheSame(EnvSkybox lhs, EnvSkybox rhs)
	{
		return false;
	}

	public EnvSkybox GetWeatherSkybox()
	{
		return null;
	}

	public EnvGlobalSetting GetWeatherGlobalSetting()
	{
		return null;
	}

	private void LerpGlobalSetting(EnvGlobalSetting previousSetting, EnvGlobalSetting targetSetting, float ratio)
	{
	}

	public float GetEmissionRate(ParticleSystem sys)
	{
		return 0f;
	}

	public void SetEmissionRate(ParticleSystem sys, float emissionRate)
	{
	}

	private void UpdateAllWeatherEffectAlpha(float ratio)
	{
	}

	private void OnRecvWeatherChanged(object[] param)
	{
	}

	private void OnRecvWeatherShow(object[] param)
	{
	}

	public void TriggerWeatherEvent(string weatherName, float duration)
	{
	}

	public void TriggerWeatherEvent(int weatherIndex, float duration)
	{
	}

	public void TriggerWeatherEvent(EnvWeatherPreset tarWeatherPreset, float duration)
	{
	}

	public void ShowWeatherEvent(int weatherIndex)
	{
	}

	public void ReplaceWeatherPreset(List<EnvWeatherPreset> list, int index = -1)
	{
	}

	public bool IsWeatherIsExited(string weatherName)
	{
		return false;
	}

	public void AddNewWeather(EnvWeatherPreset weather, string name)
	{
	}

	public void RegisterLuminousObjectMaterial(Material material)
	{
	}

	public void UnregisterLuminousObjectMaterial(Material material)
	{
	}

	private void SetLuminousObjectValue(EnvGlobalSetting setting)
	{
	}

	private void LerpLuminousObjectSetting(EnvGlobalSetting previousSetting, EnvGlobalSetting targetSetting, float ratio)
	{
	}

	private void LerpWeatherParam(float ratio, bool changeWaterImmediately = false)
	{
	}

	private void BeforeLerp(EnvWeatherPreset preset, bool changeEnvSound, bool changeWaterImmediately = false, EnvWeatherPreset beforehandPreset = null)
	{
	}

	private void AfterLerp()
	{
	}

	private void ClearTempParamAfterLerp()
	{
	}

	public void UnRegisterEnvWeatherZone(EnvWeatherZone zone, float durationSecs)
	{
	}

	public void RegisterEnvWeatherZone(EnvWeatherZone zone)
	{
	}

	private void FixedUpdate()
	{
	}

	private void TryToFindWeatherZonePlayerEnter()
	{
	}

	private void UpdateZoneFade()
	{
	}

	private bool IsTrackedPlayerInAnyWeatherZones()
	{
		return false;
	}

	private void UpdateZoneWeather(bool needLerp, float ratio, EnvWeatherZone targetZone = null)
	{
	}

	private void LerpByRatio(float ratio, bool changeWaterImmediately = false)
	{
	}

	public static void DynamicAddInstance()
	{
	}

	private void RegisterWater()
	{
	}

	public void SuppressLensFlare()
	{
	}

	public void RestoreLensFlare()
	{
	}
}
