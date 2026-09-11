using System;
using UnityEngine;

namespace GCommon;

internal class GunAdsorbEffect : ReusableObject
{
	private Renderer m_Renderer;

	private MaterialPropertyBlock m_LinkProp;

	private bool m_IsDisappearing;

	private float m_DeltaTime;

	public Action OnClear;

	public bool IsDisappearing => false;

	private void Awake()
	{
	}

	public override void Prepare()
	{
	}

	public void SetData(bool isDisappearing, float deltaTime, Action action)
	{
	}

	private void Update()
	{
	}

	private void DeleteLinkTraceSmooth()
	{
	}
}
