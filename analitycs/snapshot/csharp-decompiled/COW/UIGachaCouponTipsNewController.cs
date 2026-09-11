using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaCouponTipsNewController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<CSSharedItemData, uint> _003C_003E9__18_0;

		internal uint _003CGetCouponItemIds_003Eb__18_0(CSSharedItemData coupon)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public UIGachaCouponTipsNewController _003C_003E4__this;

		public Dictionary<uint, int> dic;

		internal int _003CRefreshCouponList_003Eb__0(CSSharedItemData a, CSSharedItemData b)
		{
			return 0;
		}

		internal bool _003CRefreshCouponList_003Eb__1(CSSharedItemData item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public UIModelBigEvent.TokenTipsData sourceChannel;

		internal bool _003CRefreshSourceChannel_003Eb__0(UIModelBigEvent.TokenTipsData source)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_1
	{
		public UINavigationUtil.UINavigationFrom navFrom;

		public UIModelBigEvent.TokenTipsData sourceChannel;

		internal void _003CRefreshSourceChannel_003Eb__1()
		{
		}
	}

	protected UIGachaCouponTipsNewView m_View;

	protected uint m_ChestID;

	protected const int MaxRowCount = 3;

	protected const int MaxSourceChannelCount = 3;

	protected UIModelGacha m_ModelGacha;

	protected List<UIStandardItemMiniController> m_CouponCtrlList;

	protected List<UIModelBigEvent.TokenTipsData> m_SourceChannelList;

	protected List<GameObject> m_SourceChannelGoList;

	protected List<UILabel> m_SourceChannelLabelList;

	protected List<UIButton> m_SourceChannelButtonList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnMaskBtnClick()
	{
	}

	private void InitViewData()
	{
	}

	public virtual void SetViewData(uint chestID)
	{
	}

	protected virtual void RefreshCouponList()
	{
	}

	protected virtual void RefreshSourceChannel()
	{
	}

	protected virtual List<CSSharedItemData> GetCouponItemsList()
	{
		return null;
	}

	protected virtual List<uint> GetCouponItemIds()
	{
		return null;
	}

	protected virtual uint GetTotalCouponCount()
	{
		return 0u;
	}

	protected virtual UINavigationUtil.UINavigationFrom GetNavigationFrom()
	{
		return UINavigationUtil.UINavigationFrom.None;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
