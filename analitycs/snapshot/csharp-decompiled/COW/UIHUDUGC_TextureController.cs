using COW.Gameplay.UGC;
using UnityEngine;

namespace COW;

public class UIHUDUGC_TextureController : UIHUDUGC_WidgetBaseController
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public UIHUDUGC_TextureController _003C_003E4__this;

		public string cur;

		public UGCHudTexture texture;

		internal void _003COnTextureChanged_003Eb__0(bool succ, bool isReloaded, Texture2D tex)
		{
		}
	}

	private UGCHudTextureRepItem m_TextureCmpt;

	protected override void InitEntityData()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void RefreshWidgetInfo()
	{
	}

	private void OnTextureChanged(string cur)
	{
	}

	private void OnShaderChanged(string cur)
	{
	}

	private void OnUVRectXYChanged(Vector2 cur)
	{
	}

	private void OnUVRectWHChanged(Vector2 cur)
	{
	}

	private void OnFillTypeChanged(int cur)
	{
	}

	private void OnBorderLRChanged(Vector2 cur)
	{
	}

	private void OnBorderTBChanged(Vector2 cur)
	{
	}

	private void OnCenterInvisibleChanged(bool cur)
	{
	}

	private void OnFillDirChanged(int cur)
	{
	}

	private void OnFillAmountChanged(float cur)
	{
	}

	private void OnInvertFillChanged(bool cur)
	{
	}

	private void OnFlipChanged(int cur)
	{
	}

	private void OnGradientChanged(int cur)
	{
	}

	private void OnGradientTopChanged(int cur)
	{
	}

	private void OnGradientBottomChanged(int cur)
	{
	}

	public void OnGradientTopAlphaChanged(float cur)
	{
	}

	public void OnGradientBottomAlphaChanged(float cur)
	{
	}

	public override void RefreshAlpha()
	{
	}

	public void _003C_003EiFixBaseProxy_InitEntityData()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshWidgetInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshAlpha()
	{
	}
}
