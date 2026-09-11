using UnityEngine;

namespace COW.Graphics;

public class Distort : CustomEffectBase
{
	private Shader m_distortShader;

	private Material m_distortMaterial;

	private int m_DistortTexRGID;

	private int m_DistortValID;

	private bool m_isInit;

	public const int Effect_PASS_INDEX = 5;

	public void Init()
	{
	}

	public override void OnEnable()
	{
	}

	public override void OnDisable()
	{
	}

	private void SafeRelease<T>(ref T obj) where T : Object
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
}
