using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIDetailTipsController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BundleShowData, uint> _003C_003E9__30_0;

		internal uint _003COnGotoClick_003Eb__30_0(BundleShowData item)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public uint gopos;

		public string subgopos;

		public UIDetailTipsController _003C_003E4__this;

		internal void _003CSetCommonIconData_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public UIDetailTipsController _003C_003E4__this;

		public ItemChannelInfo m_TargetItemChannelInfo;

		internal void _003CRefreshIPCollabTipsGain_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public uint itemId;

		public UIDetailTipsController _003C_003E4__this;

		public Action _003C_003E9__1;

		internal void _003CCreateShowProbabilityTipsBtnItem_003Eb__0()
		{
		}

		internal void _003CCreateShowProbabilityTipsBtnItem_003Eb__1()
		{
		}
	}

	private sealed class _003CSetPosition_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDetailTipsController _003C_003E4__this;

		public Vector3 itemPos;

		private Transform _003CcontentTr_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPosition_003Ed__48(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public static readonly Vector3 s_offset;

	private const float m_HeightSpace = 40f;

	private const int m_DefaultMaxLine = 24;

	public Action<UIDetailTipsController> _onClose;

	protected UIDetailTipsView m_View;

	protected EDetailTipsStyle m_TipsStyle;

	private bool m_CloseWithCollider;

	private UIModelBigEvent m_ModelBigEvent;

	private UIModelWishList m_ModelWishList;

	private UIModelInventory m_ModelInventory;

	private UICountDownController m_CountDownCtrl;

	private UIRoot m_UIRoot;

	private int m_AdjustWidthDiff;

	private uint m_BigEventUseType;

	protected uint m_CurrentItemId;

	private string m_CurrentItemName;

	private ItemStateInWishList m_WishListNodeState;

	private UICountDownController m_CDController;

	private UIClickMask m_ClickMask;

	private bool m_ShowLimitLabel;

	public const uint MaxUseChannelCnt = 3u;

	private bool m_AddClickMask;

	private const int QuickMessageDetailTipHeight = 60;

	private const int QuickMessageDetailTipOffset = 6;

	private bool m_CloseWithClickMask;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetItemInfoActive(bool v)
	{
	}

	private void SetGainInfoActive(bool v)
	{
	}

	private void SetGoUseInfoActive(bool v)
	{
	}

	private void SetCommonIconInfoActive(bool v)
	{
	}

	private void SetFakeItemInfoActive(bool v)
	{
	}

	private void SetWishListNodeActive(bool v)
	{
	}

	private void OnWishListNodeClick()
	{
	}

	private void OnGotoClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	public void SetTipsStype(EDetailTipsStyle style)
	{
	}

	public void SetData(Vector3 itemPos, string title, string descrip, bool showItemCount = true, bool isIpCollabTips = false)
	{
	}

	public void SetData(Vector3 itemPos, string title, string descrip, List<ResourceID> spriteResIds, bool needResize = false)
	{
	}

	public void SetData(Vector3 itemPos, uint id)
	{
	}

	public void SetData(Vector3 itemPos, BaseItemInfo info, bool showTypeIcon = true, bool showItemCount = true, bool isIpCollabTips = false)
	{
	}

	public void SetCountDownInfo(ulong endTime, bool closeOnFinish = true, string prefix = "", OnFinished cb = null, uint color = uint.MaxValue)
	{
	}

	private void ConvertSeasonLimitedItemInfo(BaseItemInfo info)
	{
	}

	public void SetData(Vector3 itemPos, BaseItemInfo info, string name, string descrip, Vector3 offset, bool use_collider, EArrowFixedType arrowFixedType, bool showTypeIcon = true, bool showTitle = false, string subTitle = "", bool showClock = false, ulong endTime = 0uL, OnFinished onFinished = null, bool showItemCount = true, bool isIpCollabTips = false)
	{
	}

	public void SetBGSprite(string spriteName)
	{
	}

	public void SetCommonIconData(Vector3 itemPos, string name, string descrip, ResourceID iconRes, bool use_collider = false, bool makePixelPerfect = true, ResourceID? iconVfxRes = null, string goposKey = "", uint gopos = 0u, string subgopos = "", LabelPosStyle style = LabelPosStyle.Default, bool addClickMask = false)
	{
	}

	public void AddDetailTipsBtnItemsInTipsGo(int count, Action<int, UIDetailTipsBtnItemController> initAction)
	{
	}

	public void SetItemTime(string time)
	{
	}

	public void SetItemCount(uint count)
	{
	}

	private IEnumerator SetPosition(Vector3 itemPos)
	{
		return null;
	}

	private void FixDescriptionScrollViewSize()
	{
	}

	private void RefreshIpCollabTips(bool isIpCollabTips)
	{
	}

	private void RefreshIPCollabTipsGain(ItemChannelInfo m_TargetItemChannelInfo)
	{
	}

	private void OpenDetailTipsItem(BaseItemInfo info)
	{
	}

	private void OpenDetailBigEventTemplateTipsItem(uint infoId)
	{
	}

	private void AddShowProbabilityBtnItem(CSSharedItemData itData)
	{
	}

	private void CreateShowProbabilityTipsBtnItem(uint itemId)
	{
	}

	private void CloseWithCollider()
	{
	}

	public string GetTipsDescrtion()
	{
		return null;
	}

	private void OnNavigationPused(object[] args)
	{
	}

	public void SetBigEventTemplateUseType(uint useType)
	{
	}

	public void SetShowLimitLabel(bool showLimitLabel)
	{
	}

	private void SubTitleForCoins(string subTitle)
	{
	}

	private void SetQuickMessageView(BaseItemInfo info)
	{
	}

	public void SetCloseWithClickMask()
	{
	}

	private void CloseWithClickMask()
	{
	}

	protected void RefreshItemSourceData()
	{
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetCurrentTipsRenderQueue(int renderQueueValue)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}
