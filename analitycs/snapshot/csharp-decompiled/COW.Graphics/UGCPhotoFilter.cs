using UnityEngine;

namespace COW.Graphics;

public class UGCPhotoFilter : CustomEffectBase
{
	public enum FilterType
	{
		NormalFilter,
		Comic,
		Drawing,
		Pixel,
		RGB_Split,
		GoldenAge,
		Cyberpunk
	}

	private const string SHADER_NAME = "Hidden/BRMobile/PostEffects/VFX_PostEffect_UGC";

	private const string SHADER_RESOURCE_NAME = "UGCSHADER_VFX_POSTEFFECT";

	private static readonly int ID_Brightness;

	private static readonly int ID_Saturation;

	private static readonly int ID_Contrast;

	private static readonly int ID_Threshold;

	private static readonly int ID_Range;

	private static readonly int ID_FlashSpeed;

	private static readonly int ID_LineIntensity;

	private static readonly int ID_LineSize;

	private static readonly int ID_PencilSize;

	private static readonly int ID_PencilCorrection;

	private static readonly int ID_PencilColor;

	private static readonly int ID_PaperTex;

	private static readonly int ID_PaperColor;

	private static readonly int ID_CornerLose;

	private static readonly int ID_Pixelisation;

	private static readonly int ID_ColorOffset;

	private static readonly int ID_RGBSplitOffset;

	private static readonly int ID_GoldenIntensity;

	private static readonly int ID_GoldenWarmth;

	private static readonly int ID_EdgeIntensity;

	private static readonly int ID_EdgeSize;

	private static readonly int ID_EdgeSensitivity;

	private static readonly int ID_GlitchInterval;

	private static readonly int ID_GlitchDuration;

	private static readonly int ID_EdgeColor1;

	private static readonly int ID_EdgeColor2;

	private static readonly int ID_EdgeNoiseTex;

	private Shader m_shader;

	private Material m_material;

	private Texture2D m_paperTexFallback;

	private Texture2D m_noiseTexFallback;

	private bool m_isInit;

	private GameObject m_lensFlareGO;

	private FlareLayer m_flareLayer;

	private bool m_savedFlareLayerEnabled;

	private bool m_lensFlareActive;

	public void Init()
	{
	}

	public override void OnEnable()
	{
	}

	public override void OnDisable()
	{
	}

	private void Release()
	{
	}

	public override void RefreshData()
	{
	}

	protected override void Render(RenderTexture src, RenderTexture dest)
	{
	}

	private void SetCommonProperties(PostEffectProfile p)
	{
	}

	private void SetShaderProperties(PostEffectProfile p)
	{
	}

	private Texture2D ResolvePaperTex(Texture2D fromProfile)
	{
		return null;
	}

	private Texture2D ResolveNoiseTex(Texture2D fromProfile)
	{
		return null;
	}

	private void UpdateGoldenAgeLensFlare(bool wantActive)
	{
	}

	private void ActivateGoldenAgeLensFlare()
	{
	}

	private void DeactivateGoldenAgeLensFlare()
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

	public void _003C_003EiFixBaseProxy_Render(RenderTexture P0, RenderTexture P1)
	{
	}
}
