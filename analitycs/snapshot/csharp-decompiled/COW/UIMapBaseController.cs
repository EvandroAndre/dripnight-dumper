using GCommon;
using UnityEngine;

namespace COW;

public class UIMapBaseController : UIBaseController
{
	protected UIMapContentController m_MapContentCtrl;

	protected UIMapContentController m_ExtraMapContentCtrl;

	protected override void OnUIInit()
	{
	}

	protected void InitMapContent(Transform tr, UIMapUtil.EMapType mapType = UIMapUtil.EMapType.Minimap)
	{
	}

	protected virtual UIMapContentController OpenMapContentController(Transform tr)
	{
		return null;
	}

	protected void InitExtraMapContent(Transform tr, UIMapUtil.EMapType mapType)
	{
	}

	protected virtual void RegisterEvents()
	{
	}

	protected virtual void UnRegisterEvents()
	{
	}

	protected virtual void OnObservePlayer(object[] data)
	{
	}

	protected virtual void OnObserverTargetChange(object[] data)
	{
	}

	protected virtual void OnPlayerHPChanged(GEvent data)
	{
	}

	protected virtual void OnLocalPlayerSwitch(object[] data)
	{
	}

	public virtual float GetMapScale()
	{
		return 0f;
	}

	public virtual UIMapContentController CurrentActiveGetMapContentCtrl()
	{
		return null;
	}

	protected virtual void OnMapOffsetUpdateCallBack()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
