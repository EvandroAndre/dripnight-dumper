using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MinimalEncoder : MonoBehaviour
{
	public Camera selfCamera;

	private float _startTime;

	private RenderTexture m_ownRT;

	private RenderTexture m_recordRT;

	private Camera m_selfCamera;

	private List<Camera> m_managedCameras;

	private List<PostEffectManagerBase> m_injectedManagers;

	private List<Camera> m_cachedLowerCameras;

	private List<PostEffectManagerBase> m_cachedLowerCameraPEs;

	private HashSet<Camera> m_customShadowCameras;

	private Camera[] m_allCamerasBuffer;

	[PreserveSig]
	private static extern IntPtr UEP_GetRenderEventFunc();

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void EnsureRTs()
	{
	}

	private void ReleaseRTs()
	{
	}

	private void RestoreManagedCameras()
	{
	}

	private void RestoreInjectedManagers()
	{
	}

	private int GetAllCamerasNoAlloc()
	{
		return 0;
	}

	private bool NeedRebuildCache(int allCount)
	{
		return false;
	}

	private void RebuildCache(int allCount)
	{
	}

	private void LateUpdate()
	{
	}

	private void OnPreRender()
	{
	}

	private void OnPostRender()
	{
	}
}
