using UnityEngine;

namespace COW.Graphics;

public class Bloom : CustomEffectBase
{
	private enum Pass
	{
		Prefilter4,
		Downsample4,
		UpsampleBox,
		Final,
		FinalLinear
	}

	private Shader m_bloomShader;

	private Material m_bloomMaterial;

	private Vector4 m_threshold;

	private Vector4 m_intensity;

	private float m_sampleScale;

	private int m_iterations;

	private bool m_isInit;

	private int width;

	private int height;

	private int m_thresholdID;

	private int m_intensityID;

	private int m_srcTexID;

	private int m_sampleScaleID;

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
