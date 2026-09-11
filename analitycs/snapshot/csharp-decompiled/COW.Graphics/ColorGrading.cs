using AmplifyColor;
using UnityEngine;

namespace COW.Graphics;

public class ColorGrading : CustomEffectBase
{
	public enum FilterType
	{
		ColorGrading,
		Comic,
		Drawing,
		Pixel,
		RGB_Split,
		GoldenAge,
		Cyberpunk
	}

	public const int LutSize = 32;

	public const int LutWidth = 1024;

	public const int LutHeight = 32;

	private bool m_isInit;

	private Shader shaderBase;

	private Shader shaderProcessOnly;

	private RenderTexture blendCacheLut;

	private Texture2D defaultLut;

	private Texture2D depthCurveLut;

	private ColorSpace colorSpace;

	private Quality qualityLevel;

	private Material materialBase;

	private Material materialBlend;

	private Material materialBlendCache;

	private Material materialProcessOnly;

	private Shader stylizedFilterShader;

	private Material stylizedFilterMaterial;

	private Texture2D paperTexture;

	private Texture2D pixelTexture;

	private Texture2D cyberpunkTexture;

	private bool blending;

	private RenderTexture midBlendLUT;

	public void Init()
	{
	}

	public void Release()
	{
	}

	protected override void Update()
	{
	}

	protected override void Render(RenderTexture src, RenderTexture dest)
	{
	}

	public override void OnEnable()
	{
	}

	public override void OnDisable()
	{
	}

	private void SetupShader()
	{
	}

	private void SafeRelease<T>(ref T obj) where T : Object
	{
	}

	private void ReleaseMaterials()
	{
	}

	private bool CreateMaterials()
	{
		return false;
	}

	private void ReportMissingShaders()
	{
	}

	private void ReportNotSupported()
	{
	}

	private bool CheckShader(Shader s)
	{
		return false;
	}

	private bool CheckShaders()
	{
		return false;
	}

	private bool CheckMaterialAndShader(Material material, string name)
	{
		return false;
	}

	private void ReleaseTextures()
	{
	}

	public static bool ValidateLutDimensions(Texture lut)
	{
		return false;
	}

	private int ComputeShaderPass()
	{
		return 0;
	}

	public override void RefreshData()
	{
	}

	public void _003C_003EiFixBaseProxy_Update()
	{
	}

	public void _003C_003EiFixBaseProxy_Render(RenderTexture P0, RenderTexture P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnEnable()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDisable()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshData()
	{
	}
}
