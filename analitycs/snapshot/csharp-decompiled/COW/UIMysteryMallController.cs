using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIMysteryMallController : UINavigationController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UIMysteryMallThemeView> _003C_003E9__21_0;

		internal int _003CInitMysteryMallTab_003Eb__21_0(UIMysteryMallThemeView x, UIMysteryMallThemeView y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public uint shopId;

		internal bool _003COnNavigationShowed_003Eb__0(StandardTopTabItemViewData value)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public UIMysteryMallController _003C_003E4__this;

		public MysteryShopExpressionDesc mallDesc;

		internal void _003CRefreshView_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public UIMysteryMallController _003C_003E4__this;

		public MysteryPoolStoreItem data;

		internal UIBaseController _003CSetNormalItemView_003Eb__0()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public UIMysteryMallController _003C_003E4__this;

		public UISecondConfirmSmallContoller confirmWnd;

		internal void _003COnBtnSwitchPoolClick_003Eb__0()
		{
		}
	}

	private UIMysteryMallView m_View;

	private UIModelMysteryMall m_ModelMall;

	private UIMysteryMallItemController m_ItemSuperCtrl;

	private UIStandardTopTabController m_TabCtrl;

	private List<StandardTopTabItemViewData> m_TabDataList;

	private List<UIMysteryMallItemController> m_ItemNormalCtrlList;

	private List<ItemDelayCreateHelper> m_FakeItems;

	private UICountDownController m_CountDownCtrl;

	private const int MAX_NORMAL_ITEM_NUM = 13;

	private uint m_CurPoolId;

	private int m_LastSelectedIndex;

	private bool m_IsCancelLuckyDraw;

	public static EThemeType CurTheme;

	private string m_CurBgUrl;

	private int m_NextItemCreateFrame;

	private UIMysteryMallThemeView[] m_MallThemeArray;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnTabSelected(int index)
	{
	}

	private void InitMysteryMallTab()
	{
	}

	private void RefreshTabRedPoint()
	{
	}

	private void RefreshView(bool needSort = false)
	{
	}

	private void RefreshNormalItemList(List<MysteryPoolStoreItem> poolItemList)
	{
	}

	private void SetNormalItemView(int index, MysteryPoolStoreItem data)
	{
	}

	private void RefreshBtnSwitchPool()
	{
	}

	private void OnBtnGemClick()
	{
	}

	private void OnBtnSwitchPoolClick()
	{
	}

	private void OnBtnPurchaseSuperClick()
	{
	}

	private void OnClickCloseButton()
	{
	}

	private void OnBtnRuleClick()
	{
	}

	private void OnBtnGoWebClick()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
