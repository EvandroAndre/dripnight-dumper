using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class CustomShadow : MonoBehaviour
{
	public Light m_light;

	public static Camera m_camera;

	private RenderTexture m_depthRT;

	private Shader m_shader;

	private Transform m_lightTransform;

	private Camera followingCam;

	private bool m_bEnableRTShadow;

	public float m_CameraHeight;

	private float m_CameraOffset;

	private Vector3 m_LastAimTarget;

	private Vector3 m_LastLightForward;

	public float nearClipPlane;

	public float farClipPlane;

	public int rtResolution;

	public float shadowStrength;

	private static readonly int s_MatPropIDRtName;

	private static readonly int s_MatPropIDMatrixName;

	private static List<Renderer> s_castShadowRendererCache;

	private static CustomShadow _003Cinstance_003Ek__BackingField;

	public bool isEnabled => false;

	public static CustomShadow instance
	{
		get
		{
			return _003Cinstance_003Ek__BackingField;
		}
		private set
		{
			_003Cinstance_003Ek__BackingField = value;
		}
	}

	public static void SetCastShadow(GameObject go, bool castShadow)
	{
	}

	public static void SetCastShadowInChildren(GameObject go, bool castShadow)
	{
	}

	public static void SetCastShadowInChildrenInAllMaterials(GameObject go, bool castShadow)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public static void ResetShadowMatrix()
	{
	}

	public void SetFollowingCameraLight(Camera cam, Light light)
	{
	}

	public void ForceEnableShadow(bool enableShadow)
	{
	}

	private void InitShadow()
	{
	}

	private void OnValidate()
	{
	}

	private void UpdateCameraSizeAndOffset()
	{
	}

	private void DestroyShadow()
	{
	}

	private void Update()
	{
	}

	private void UpdateShadowMatrix()
	{
	}
}
