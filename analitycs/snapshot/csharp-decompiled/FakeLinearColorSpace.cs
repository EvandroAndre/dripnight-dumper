using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FakeLinearColorSpace : MonoBehaviour
{
	public bool m_OpenFakeLinearColorSpace;

	public Light m_MainLight;

	public Color m_MainLightColor;

	[NonSerialized]
	public bool m_IsLinear;

	private bool m_bAmbientProcessed;

	public void ProcessFakeLinearColorSpace(bool start, bool open)
	{
	}

	private void ProcessDirectionalLight()
	{
	}

	public void ProcessAmbient()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	public static void UpdateSkyboxAmbient()
	{
	}

	public void UpdateMainLightColor()
	{
	}
}
