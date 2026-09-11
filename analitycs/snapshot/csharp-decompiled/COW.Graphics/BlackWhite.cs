using UnityEngine;

namespace COW.Graphics;

public class BlackWhite : CustomEffectBase
{
	private Shader m_blackWhiteShader;

	private Material m_blackWhiteMaterial;

	private bool m_tint;

	private float m_maxInput;

	private float m_minInput;

	private int m_tintID;

	private int m_maxInputID;

	private int m_minInputID;

	private bool m_isInit;

	private int width;

	private int height;

	public const int Effect_PASS_INDEX = 0;

	public void Init()
	{
	}

	public override void OnEnable()
	{
	}

	public override void OnDisable()
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

	public override void RefreshData()
	{
	}

	public void _003C_003EiFixBaseProxy_OnEnable()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDisable()
	{
	}

	public void _003C_003EiFixBaseProxy_Update()
	{
	}

	public void _003C_003EiFixBaseProxy_Render(RenderTexture P0, RenderTexture P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshData()
	{
	}
}
