using System;
using GCommon;
using UnityEngine;

public class EnvWeatherZone : MonoBehaviour
{
	public float InsideRadius;

	public float LerpDistance;

	public EnvWeatherPreset Weather;

	public bool NeedFadeWithTime;

	public float FadeTotalTime;

	public Action OnFadeOut;

	public Action<float, float> OnBlendRatioChanged;

	private float m_LastBlendRatio;

	public bool ChangeWaterImmediately;

	private float m_FadeCurTime;

	private bool m_IsFadeIn;

	public void InitSize(float insideRadius, float lerpDistance)
	{
	}

	public void InitWeatherRes(ResourceID resourceID)
	{
	}

	public void RegisterToWeatherController()
	{
	}

	public void UnRegisterFromWeatherController(float durationSecs)
	{
	}

	public bool IsTargetPositionInZone(Vector3 position, out float lerpRatio, out float distance)
	{
		lerpRatio = default(float);
		distance = default(float);
		return false;
	}

	public void StartFadeIn()
	{
	}

	public void StartFadeOut()
	{
	}

	public bool UpdateFadeInTime()
	{
		return false;
	}

	public bool IsFadeIn()
	{
		return false;
	}

	public void UnRegister()
	{
	}

	public void NotifyBlendRatioChanged(float blendRatio, float distanceToZoneCenter)
	{
	}

	public float GetFadeRatio()
	{
		return 0f;
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}
}
