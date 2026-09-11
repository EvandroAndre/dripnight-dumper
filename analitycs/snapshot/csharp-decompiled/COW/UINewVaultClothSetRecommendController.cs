using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UINewVaultClothSetRecommendController : UIBaseController, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public AvatarWardrobeData selectClothData;

		public UINewVaultClothSetRecommendController _003C_003E4__this;

		internal bool _003COnDressUpClick_003Eb__0(AvatarWardrobeData e)
		{
			return false;
		}

		internal void _003COnDressUpClick_003Eb__1()
		{
		}
	}

	private UINewVaultClothSetRecommendView m_View;

	private uint m_SelectClothID;

	private UIModelInventory m_ModelInventory;

	private UIModelAvatar m_ModelAvatar;

	private UIClickMask m_ClickMask;

	private Action OnClose;

	private uint m_CurrentSelectSetID;

	private List<UIStandardItemMAXBController> m_ClothSetList;

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

	public void SetViewData(uint selectClothID, UIWidget Clickbg, Action onClose)
	{
	}

	private AvatarWardrobeData GetRealSeriesItemData(AvatarWardrobeData data)
	{
		return null;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIMaleAvatar TryGetNewVaultAvatar()
	{
		return null;
	}

	public void SetCurrentSelectSetID(uint setID)
	{
	}

	private void OnDressUpClick()
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
