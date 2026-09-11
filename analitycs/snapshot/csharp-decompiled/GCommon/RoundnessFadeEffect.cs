using UnityEngine;

namespace GCommon;

public class RoundnessFadeEffect : MonoBehaviour
{
	private Material m_CurMaterial;

	private Shader m_Shader;

	public Color m_Color;

	public float m_Radius;

	public float m_Speed;

	private void Start()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
