using System;
using UnityEngine;

namespace UMA;

public class TextureMerge : MonoBehaviour
{
	[Serializable]
	public class TextureMergeRect
	{
		public Material mat;

		public Texture tex;

		public Rect rect;

		public Rect srcRect;
	}

	public Camera myCamera;

	public Material material;

	public Shader normalShader;

	public Shader diffuseShader;

	public Shader dataShader;

	public Shader cutoutShader;

	public Shader skinShader;

	public Shader blendShader;

	public Shader maskShader;

	public int textureMergeRectCount;

	public TextureMergeRect[] textureMergeRects;

	private int _MainTex;

	private int _ExtraTex;

	private int _Color;

	private int _AdditiveColor;

	private int _SecondAddtiveColor;

	private int _AlphaTex;

	private int _BiasScale;

	private int _RegionCoord;

	private int _ClipFlag;

	private int _DestBlend;

	private Rect atlasRect;

	private int height;

	private void Awake()
	{
	}

	private void OnRenderObject()
	{
	}

	private void DrawRect(ref TextureMergeRect textureMergeRect)
	{
	}

	public void BlitTexture(ref RenderTexture renderTexture, float normalSpecTexScale)
	{
	}

	public void DrawAllRects(RenderTexture target, int width, int height, Color background = default(Color))
	{
	}

	public Vector4 SetBiasScale(Rect rect, int rtWidth, int rtHeight, Rect srcRect)
	{
		return default(Vector4);
	}

	public void Reset()
	{
	}

	internal void EnsureCapacity(int moduleCount)
	{
	}

	private void SetupMaterial(ref TextureMergeRect textureMergeRect, UMAData.MaterialFragment source, int textureType)
	{
	}

	public void SetupModule(UMAData.MaterialFragment source, int textureType)
	{
	}

	public void SetupModule(UMAData.GeneratedMaterial atlas, int idx, int textureType)
	{
	}

	private void SetupOverlay(UMAData.MaterialFragment source, int i2, int textureType)
	{
	}

	private bool SetupMaterial(ref TextureMergeRect textureMergeRect, UMAData.MaterialFragment source, int i2, Rect overlayRect, int textureType)
	{
		return false;
	}
}
