using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudSpecialPopupController : UIBaseController
{
	public class ZoneColorGroup
	{
		public NADDEMMBAJF zoneType;

		public Color iconColor;

		public Color bgColor;

		public Color bgColor2;

		public Color bgColor3;

		public ZoneColorGroup(NADDEMMBAJF zoneType, Color iconColor, Color bgColor, Color bgColor2, Color bgColor3)
		{
		}
	}

	private UIHudSpecialPopupView m_View;

	private uint m_DelayCallID;

	private List<ZoneColorGroup> m_ZoneColorGroupList;

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

	protected override void OnUIDestory()
	{
	}

	public void SetMessage(GameBannerInfo gb, NADDEMMBAJF zoneType)
	{
	}

	private void AutoHide()
	{
	}

	private void CancelDelayCall()
	{
	}

	protected override void OnDestroy()
	{
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
