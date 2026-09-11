using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDetailTipsWithProfileIconController : UIPopupWindowController
{
	private UIDetailTipsWithProfileIconView m_View;

	private const float m_HeightSpace = 40f;

	private UIRoot m_UIRoot;

	private List<UIDetailTipsProfileIconItemController> m_IconItems;

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

	public void SetViewDataWithIcons(Vector3 itemPos, List<IconTextData> iconDataList, Vector3 LocalPosOffset = default(Vector3))
	{
	}

	private void SetupBGAnchors()
	{
	}

	private void ClearIcons()
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
