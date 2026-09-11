using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_IdentityNotifyController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_IdentityNotifyView m_View;

	private UGCIdentityNotifyHudRepItem m_Component;

	private List<UIPropertySync> m_PropertySyncList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
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

	private void OnPositionChanged(Vector3 cur)
	{
	}

	private void OnIconSpriteChanged(string cur)
	{
	}

	private void OnLabelChanged(string cur)
	{
	}

	private void OnBGColorChanged(int cur)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
