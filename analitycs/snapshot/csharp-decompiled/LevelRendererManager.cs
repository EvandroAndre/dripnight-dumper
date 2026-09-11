using System.Collections.Generic;
using UnityEngine;

public class LevelRendererManager : MonoBehaviour
{
	public int LevelID;

	public List<Renderer> Renderers;

	private bool m_Inited;

	private bool m_IsVisible;

	private void Start()
	{
	}

	public void SetRenderVisible(bool isVisible)
	{
	}
}
