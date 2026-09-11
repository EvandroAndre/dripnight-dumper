using System;
using UnityEngine;

public class FadeEffect : MonoBehaviour
{
	public enum FadeState
	{
		Stay,
		FadeIn,
		FadeOut
	}

	public Renderer Render;

	private FadeState m_CurState;

	private Action m_CallBack;

	private Material m_CachedMat;

	private Color m_StartColor;

	private float m_StartAlpha;

	private float m_CurAlpha;

	private float m_Duration;

	private float m_Time;

	private void Awake()
	{
	}

	public void Fade(FadeState state, float duration, Action callBack)
	{
	}

	private void Update()
	{
	}
}
