using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyIceWallDisplayController : UINavigationController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WeaponItemData> _003C_003E9__19_0;

		internal int _003CSetIceWallShow_003Eb__19_0(WeaponItemData a, WeaponItemData b)
		{
			return 0;
		}
	}

	private UILobbyIceWallDisplayView m_View;

	private UIModelIceWallDisplay m_Model;

	private UIModelCollection m_ModelCollection;

	private uint m_CurrentIceWallID;

	private List<WeaponItemData> m_IceWallList;

	private UICommonGuideController m_guideController;

	private const uint icewalltype = 1201u;

	public bool CanRefresh;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
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

	protected override void OnUIDestroy()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnGotoShopButtonClick()
	{
	}

	private void OnRemoveButtonClicked()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void SetIceWallShow(uint id)
	{
	}

	private void OnClickCloseButton()
	{
	}

	private void ChangIceWall(object[] data)
	{
	}

	private void OnCameraMoveEnd(object[] data)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
