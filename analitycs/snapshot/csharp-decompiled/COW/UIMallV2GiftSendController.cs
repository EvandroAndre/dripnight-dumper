using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIMallV2GiftSendController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<FriendInfo, ulong> _003C_003E9__17_0;

		internal ulong _003COnSendBtnClick_003Eb__17_0(FriendInfo a)
		{
			return 0uL;
		}
	}

	private UIMallV2GiftSendView m_View;

	private UIModelGift m_ModelGift;

	private UIModelMall m_ModelMall;

	private GiftItem m_SelectedGift;

	private string m_ReceiversName;

	private int m_ItemCount;

	private bool m_ApplyAll;

	private EGiftSendSource m_GiftSource;

	private bool m_IsPrime;

	private string m_DefaultString;

	private string m_CurrentString;

	private List<FriendInfo> m_FriendList;

	private List<UIMallV2GiftReceiverController> m_ReceiverList;

	private Dictionary<ulong, string> m_MessageDict;

	private UIMallV2GiftSendCheckTipController m_GiftSendCheckTipCtrl;

	private FriendInfo m_CurFriendInfo;

	private UIBaseProfileInfoController m_ProfileInfoController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnSendBtnClick()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void ProcessAnimEvent(object[] data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void ShowContainer()
	{
	}

	public void ShowGiftMessage(List<FriendInfo> receiversList, GiftItem selectedGift, int itemCount, EGiftSendSource source = EGiftSendSource.None, bool isPrime = false)
	{
	}

	public void ShowRepeatTips()
	{
	}

	private void LoadFriendList()
	{
	}

	private void SelectFriend(int index)
	{
	}

	private void OnInputChange()
	{
	}

	private void OnMutliInputChange()
	{
	}

	private void RefreshFriendInfo(FriendInfo friendInfo)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public GiftItem GetSelectedGift()
	{
		return null;
	}

	public uint GetSelectedItemCount()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
