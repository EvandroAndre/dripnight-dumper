using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_HitObjectHPBarController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_HitObjectHPBarView m_View;

	private UGCHPbarHudRepItem m_Component;

	private int m_CurrentVal;

	private int m_MaxVal;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnObjectNameChanged(string cur)
	{
	}

	private void OnCurrentValueChanged(int cur)
	{
	}

	private void OnMaxValueChanged(int cur)
	{
	}

	private void OnOffsetChanged(Vector3 cur)
	{
	}

	private void OnLengthChanged(int cur)
	{
	}

	private void OnValChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
