using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class RenderersAlpha : MonoBehaviour
{
	private float m_Alpha;

	private List<Renderer> m_Renderers;

	private readonly List<int> m_ColorPropertyIDs;

	private Dictionary<Renderer, float> m_DefaultAlphaValue;

	private void Awake()
	{
	}

	public void SetAlpha(float alpha)
	{
	}
}
