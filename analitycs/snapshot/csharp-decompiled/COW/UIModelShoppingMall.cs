using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelShoppingMall : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public UIModelShoppingMall _003C_003E4__this;

		public string cmd;

		internal void _003CRequestShoppingMallInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_ShoppingMallItemRefresh = 1u;

	public const uint PropID_ShoppingMallItemReady = 2u;

	private bool m_IsReadyToShow;

	private float m_LastUpdateShoppingMallResTime;

	private float m_GetShoppingMallResCoolDown;

	private float m_ScrollViewCoolDown;

	private uint m_VeteranDiscountSortId;

	private bool m_IsTopShow;

	private readonly List<ShoppingMallScreenDesc> m_ShoppingMallShowItemList;

	private List<ShoppingMallScreenDesc> m_ShoppingMallAllItemList;

	private ShoppingMallScreenDesc m_ShoppingMallMainPageItem;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	public Dictionary<uint, OtherChannelInfo> m_DicOtherChannelInfo;

	public uint VeteranDiscountSortId => 0u;

	public bool IsTopShow => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	private void FilterShoppingMallItemInfo()
	{
	}

	private int SortShoppingMallList(ShoppingMallScreenDesc x, ShoppingMallScreenDesc y)
	{
		return 0;
	}

	public bool IsVeteranSortId(uint sortid)
	{
		return false;
	}

	private bool IsShoppingMallItemInOpenTime(ShoppingMallScreenDesc ItemData, ulong time)
	{
		return false;
	}

	private void ResetRefreshShoppingMallItemColdData()
	{
	}

	public bool GetShoppingMallIsReady()
	{
		return false;
	}

	public ShoppingMallScreenDesc GetShoppingMallItemInfoByIndexID(uint Index)
	{
		return null;
	}

	public string RequestShoppingMallItemChannelInfo(uint ChannelType)
	{
		return null;
	}

	public List<ShoppingMallScreenDesc> GetShoppingMallShowItemList()
	{
		return null;
	}

	public ShoppingMallScreenDesc GetShoppingMallMainPageItem()
	{
		return null;
	}

	public float GetScrollViewCoolDown()
	{
		return 0f;
	}

	public void ProcessShoppingMall(CSGetShoppingMallScreenRes ItemRes, bool notify = true)
	{
	}

	public void RequestShoppingMallInfo(bool sendImmediately = false)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
