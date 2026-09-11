using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbySkyboardDisplayController : UINavigationController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SkyboardDisplayItemData> _003C_003E9__18_0;

		internal int _003CSetSkateboardShow_003Eb__18_0(SkyboardDisplayItemData a, SkyboardDisplayItemData b)
		{
			return 0;
		}
	}

	private UILobbySkyboardDisplayView m_View;

	private UIModelSkyboardDisplay m_Model;

	private UIModelCollection m_ModelCollection;

	private uint m_CurrentSkateboardId;

	private bool isTipsFollowGrid;

	private static int SKATEBOARDITEMCOUNT;

	private float m_SkateboardDisplayItemHeight;

	private float m_CellSpacing;

	private List<SkyboardDisplayItemData> m_skyboardDisplayList;

	private UICommonGuideController m_GuideController;

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

	private void OnAutoRotateClicked()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void OnGotoShopButtonClick()
	{
	}

	private void OnRemoveButtonClicked()
	{
	}

	private void SetSkateboardShow()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void ChangeSkyboard(object[] data)
	{
	}

	private void OnCameraMoveEnd(object[] data)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
