using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class EnvChangeController : MonoBehaviour
{
	public enum EnvState
	{
		BEFORE,
		SWITCHING,
		AFTER
	}

	public static Dictionary<string, EnvChangeController> sEnvChangeCtrs;

	public static List<EnvChangeWorker> sPendingWorkers;

	public string ControllerID;

	public const string SkyboxControllerID = "Skybox";

	public float MIN_DIST;

	public float MAX_DIST;

	public float Distance;

	public float BlendRate;

	private float m_InvDistance;

	public bool AutoPlay;

	public float PlaySpeed;

	public Transform StartPos;

	public WaterChangeController WaterChangeCtr;

	public float FadeOutThreshold;

	public bool NeedDispatchEvent;

	private List<EnvChangeWorker> m_WorkerArray;

	private readonly int m_DistPropertyID;

	private readonly int m_BlendPropertyID;

	private readonly int m_PlayerPosPropertyID;

	private readonly int m_SrcBlendPropertyID;

	private readonly int m_DestBlendPropertyID;

	private readonly int m_ZWritePropertyID;

	private const string KEYWORD_SWITCH_BEFORE = "SWITCH_BEFORE";

	private const string KEYWORD_SWITCH_ING = "SWITCH_ING";

	private const string KEYWORD_SWITCH_AFTER = "SWITCH_AFTER";

	private const string KEYWORD_BLEND_ON = "BLEND_ON";

	private bool m_BlendRateChanged;

	private float m_LastDistance;

	private bool m_IsBlendModeInited;

	private bool m_IsBlendModeTransparent;

	private EnvState m_EnvState;

	private EnvState m_LastEnvState;

	private Action m_FadeOutCb;

	private bool m_IsFadeOutCbCalled;

	private Action m_EnvChangeDoneCb;

	private bool m_IsEnvChangeDoneCbCalled;

	private bool m_IsEnvSwitchStartDispatched;

	private bool m_IsEnvSwitchEndDispatched;

	private CameraClearFlags m_GameCamOriCameraClearFlags;

	private bool m_GameCamOriCameraClearFlagsChanged;

	public static void RegisterWorker(EnvChangeWorker worker)
	{
	}

	public static void UnregisterWorker(EnvChangeWorker worker)
	{
	}

	public void OnWorkerAdded(EnvChangeWorker w)
	{
	}

	public void Reset()
	{
	}

	public bool IsBeforeSwitchStart()
	{
		return false;
	}

	public bool IsAfterSwitchEnd()
	{
		return false;
	}

	public void StartSwitch()
	{
	}

	public void StopSwitch()
	{
	}

	public void ChangeStateAFTER()
	{
	}

	public void ChangeStateBEFORE()
	{
	}

	public void SetBlend(float rate)
	{
	}

	public void RegisterFadeOutCb(Action cb)
	{
	}

	public void RegisterEnvChangeDoneCb(Action cb)
	{
	}

	public void UpdateStartPosition()
	{
	}

	public void DisableNormalSkybox()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateAllPendingWorkers()
	{
	}

	private void UpdateMatState(EnvChangeWorker w)
	{
	}

	private void UpdateMatDist(EnvChangeWorker w)
	{
	}

	private void UpdateMatBlend(EnvChangeWorker w)
	{
	}

	private void UpdateMatBlendMode(EnvChangeWorker w, bool isTransparent)
	{
	}

	private void UpdateMatState()
	{
	}

	private void UpdateStartPosition(EnvChangeWorker w)
	{
	}

	private bool IsTransparentForBlending()
	{
		return false;
	}

	private bool IsBlending()
	{
		return false;
	}

	private bool IsOuter()
	{
		return false;
	}

	private void UpdateEnvState()
	{
	}
}
