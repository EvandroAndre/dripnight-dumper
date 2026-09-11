using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPopupController : UIBaseController
{
	private UIHudPopupView m_View;

	private float m_delayCallTime;

	private int m_DefaultMainPanelDepth;

	private int m_DefaultLabelPanelDepth;

	private Vector3 m_DefaultMessageScale;

	private bool m_DefaultsCached;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	private void CacheDefaultsFromPrefab()
	{
	}

	private void ResetByCacheDefaults()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetMessage(string message, float duration, bool noAnim = false)
	{
	}

	public void SetDepth(int depth)
	{
	}

	private void Update()
	{
	}

	private void CancelDelayCall()
	{
	}

	protected override void OnDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
