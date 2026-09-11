using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.CustomPVS;

public class LPVSItemAttacher
{
	public ushort ID;

	public GameObject gameObject;

	public const uint PVS_VISIBLE = 1u;

	public const uint STREAMER_VISIBLE = 2u;

	private BitArrayBoolean m_IsVisible;

	private List<MeshRenderer> m_Renderers;

	private bool m_CullParticleSystem;

	private List<ParticleSystemRenderer> m_ParticleSystemRenderers;

	private static List<MeshRenderer> m_TempRenderers;

	private static List<ParticleSystemRenderer> m_TempPSRenderers;

	public Transform transform => null;

	public void Init(ushort id, GameObject go)
	{
	}

	public void Clear()
	{
	}

	private bool IsChild(Transform t)
	{
		return false;
	}

	private bool CheckRenderers(bool isForce = false)
	{
		return false;
	}

	public void ResetRenderers(bool needClear = true)
	{
	}

	public void ResetPartialRenderers(GameObject go)
	{
	}

	public void Register(bool cullParticleSystem = false)
	{
	}

	public void UnRegister()
	{
	}

	public void Refresh(uint flag = 1u)
	{
	}

	public bool GetVisible()
	{
		return false;
	}

	public List<MeshRenderer> GetRenderers()
	{
		return null;
	}

	public void SetVisible(bool isVisible, bool isForce = false, uint flag = 1u)
	{
	}

	private void SetRendererEnable(Renderer r, bool enable)
	{
	}
}
