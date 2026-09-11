using UnityEngine;

namespace COW.Graphics;

public class ImageDepthBlur : CustomEffectBase
{
	private Color m_rimColor;

	private Shader m_blurShader;

	private Shader m_depthBlurShader;

	private Material m_blurMaterial;

	private Material m_depthBlurMaterial;

	private bool m_isInit;

	private int width;

	private int height;

	public override void Start(PostEffectManagerBase manager)
	{
	}

	public void Init()
	{
	}

	public void Release()
	{
	}

	protected override void Update()
	{
	}

	protected override void Render(RenderTexture source, RenderTexture destination)
	{
	}

	public override void OnEnable()
	{
	}

	public override void OnDisable()
	{
	}

	public override bool NeedCallRender()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Start(PostEffectManagerBase P0)
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

	public bool _003C_003EiFixBaseProxy_NeedCallRender()
	{
		return false;
	}
}
