using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_ProgressbarController : UIHudNameBaseController, IUIHUDBaseController
{
	private UIHUDUGC_ProgressbarView m_View;

	private UGCProgressbarHudRepItem m_Component;

	private string TrackEntityID;

	private Transform TrackObject;

	private Vector3 PositionOffset;

	protected Dictionary<UIPanel, int> m_PanelDepth;

	private UGCInternalHudRepItem m_UGCInternalHudRepItem;

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

	public void SetEntityID(string entityID)
	{
	}

	public void DestroyEntity()
	{
	}

	private void OnDepthChanged(int cur)
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnFollowTargetChange(string cur)
	{
	}

	private void OnColorChange(int cur)
	{
	}

	private void OnHUDLengthChange(int cur)
	{
	}

	private void OnCurrentValueChange(float cur)
	{
	}

	private void OnOffsetChange(Vector3 cur)
	{
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}
}
