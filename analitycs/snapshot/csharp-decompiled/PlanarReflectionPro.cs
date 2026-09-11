using UnityEngine;

public class PlanarReflectionPro : MonoSingleton<PlanarReflectionPro>
{
	public LayerMask _reflectionMask;

	public bool _reflectSkybox;

	public float _clipPlaneOffset;

	private const string _reflectionTex = "_ReflectionTex";

	public Material _sharedMaterial;

	public ReflectionDownsampleMode _downsample;

	private static Camera s_reflectionCamera;

	private static bool s_insideRendering;

	private ReflectionDownsampleMode _oldDownsample;

	private bool _oldReflectSkybox;

	private LayerMask _oldReflectionMask;

	private bool _cameraSettingsDirty;

	private static int s_lastRTWidth;

	private static int s_lastRTHeight;

	private static bool s_lastHDR;

	protected override void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void ReleaseRenderTextures()
	{
	}

	private Camera CreateReflectionCamera(Camera cam)
	{
		return null;
	}

	private void HoldCameraSettings(Camera helperCam)
	{
	}

	private RenderTexture CreateTexture(Camera sourceCam)
	{
		return null;
	}

	private bool NeedsRTRebuild(Camera cam)
	{
		return false;
	}

	private void OnWillRenderObject()
	{
	}

	private void RenderReflection(Camera currentCam, Camera reflectCamera)
	{
	}

	private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
	{
		return default(Matrix4x4);
	}

	private Vector4 CameraSpacePlane(Camera cam, float planeY)
	{
		return default(Vector4);
	}

	protected override void OnDestroy()
	{
	}
}
