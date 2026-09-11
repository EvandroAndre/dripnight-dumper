using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaCouponExpireInfoController : UIPopupWindowController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Item> _003C_003E9__5_0;

		internal int _003CRefreshData_003Eb__5_0(Item a, Item b)
		{
			return 0;
		}
	}

	private const string PREFS_KEY_PREFIX = "GACHA_COUPON_EXPIRATION_NOTI";

	protected UIGachaCouponExpireInfoView m_View;

	protected ulong m_AccountId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected virtual void RefreshData()
	{
	}

	protected virtual List<Item> GetExpiringCouponItems()
	{
		return null;
	}

	protected Item GetSelectedItem(List<Item> items)
	{
		return null;
	}

	protected virtual int FindSelectItemChestID()
	{
		return 0;
	}

	protected virtual UINavigationUtil.UINavigationPageType GetNavigationPageType()
	{
		return UINavigationUtil.UINavigationPageType.None;
	}

	protected virtual UINavigationUtil.UINavigationFrom GetNavigationFrom()
	{
		return UINavigationUtil.UINavigationFrom.None;
	}

	protected virtual string GetPrefsKeyPrefix()
	{
		return null;
	}

	protected virtual void OnBtnClick()
	{
	}

	private void OnToggleClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
