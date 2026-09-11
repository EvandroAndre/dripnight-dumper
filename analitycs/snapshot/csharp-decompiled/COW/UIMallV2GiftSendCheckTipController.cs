using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIMallV2GiftSendCheckTipController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<FriendInfo, ulong> _003C_003E9__13_0;

		internal ulong _003CRefreshDataAndRequest_003Eb__13_0(FriendInfo a)
		{
			return 0uL;
		}
	}

	private UIMallV2GiftSendCheckTipView m_View;

	private UIModelMall m_ModelMall;

	private List<FriendInfo> m_FriendList;

	private GiftItem m_SelectedGift;

	private List<UIMallV2GiftSendCheckTipItemController> m_ItemList;

	public bool isRepeat;

	private const int m_BeginBGHight = 46;

	private const int m_EndBGHight = 52;

	private const int m_MaxBGHight = 150;

	private const int m_BeginPosition = -55;

	private uint m_DelayCallId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshDataAndRequest(List<FriendInfo> receiversList, GiftItem selectedGift, bool isPrime)
	{
	}

	private void RefreshRepeatList(List<CSCheckOwnedBeforeSendGiftRes.GiftSource> giftSourceList)
	{
	}

	private void RefreshShowState(bool isStart)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003CRefreshRepeatList_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
