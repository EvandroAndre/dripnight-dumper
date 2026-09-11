using GCommon;
using UnityEngine;

namespace COW;

internal class UIDetailTipsInGameController : UIPopupWindowController
{
	private UIDetailTipsInGameView m_View;

	public static readonly Vector3 s_offset;

	private const float m_HeightSpace = 40f;

	private UIRoot m_UIRoot;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(Vector3 itemPos, string description, Vector3 LocalPosOffset = default(Vector3))
	{
	}

	private void SetPosition(Vector3 itemPos, Vector3 LocalPosOffset)
	{
	}

	private void OnMaskClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
