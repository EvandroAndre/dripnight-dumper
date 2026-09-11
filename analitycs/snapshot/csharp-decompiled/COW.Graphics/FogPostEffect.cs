using UnityEngine;

namespace COW.Graphics;

public class FogPostEffect : CustomEffectBase
{
	private Shader m_fogShader;

	private Material m_fogMaterial;

	private bool m_isInit;

	private DepthTextureMode camModeO;

	public override void OnEnable()
	{
	}

	public override void OnDisable()
	{
	}

	public void Init()
	{
	}

	public void Release()
	{
	}

	protected override void Render(RenderTexture source, RenderTexture destination)
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

	private void ReleaseTextures()
	{
	}

	private void CreateHelperTextures()
	{
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

	public void _003C_003EiFixBaseProxy_OnEnable()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDisable()
	{
	}

	public void _003C_003EiFixBaseProxy_Render(RenderTexture P0, RenderTexture P1)
	{
	}
}
