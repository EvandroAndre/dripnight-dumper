using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIMallV2ShoppingMallContainerController : UIBaseController, IUIModelDataChangeObserver
{
	public enum UIMallV2ShoppingMallType
	{
		Normal = 1
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public UIMallV2ShoppingMallContainerController _003C_003E4__this;

		public ulong endTime;

		internal void _003CTickCountDown_003Eb__0()
		{
		}
	}

	private UIMallV2ShoppingMallContainerView m_View;

	private UIModelMall m_ModelMall;

	private UIModelShoppingMall m_ModelShoppingMall;

	private UIModelInventory m_ModelInventory;

	private ShoppingMallScreenDesc m_CurrentItem;

	private UIMallV2ShoppingMallItemController m_CurrentShowItemCtrl;

	private bool m_IsTopShowSelect;

	public UITable2 m_CurrentTable;

	private uint m_CountDownDelayCall;

	private UILaunchTagFrameController m_LaunchTagCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitState()
	{
	}

	public void SetViewData(List<ShoppingMallScreenDesc> storeDescs)
	{
	}

	private void TopShowRefresh()
	{
	}

	private void OnTopShowBtnClick()
	{
	}

	private void RequestChannelGopos()
	{
	}

	public void RefreshRightState(uint indexId)
	{
	}

	private void RefreshGoposBtn()
	{
	}

	private void OnGoPosBtnClick()
	{
	}

	private void GoPos(uint gopos, string subGopos)
	{
	}

	internal void SelectItem(int index, bool force = false)
	{
	}

	public void RefreshHightLight(int index)
	{
	}

	internal int GetDataListCount()
	{
		return 0;
	}

	public void RefreshTableAndButtonView()
	{
	}

	private void InitShoppingMallItemTemplate()
	{
	}

	private UITable2.IUITable2Item OpenNormalMallItem()
	{
		return null;
	}

	public override void Hide()
	{
	}

	private void ShowLaunchTag(bool show, uint tagID = 0u)
	{
	}

	private void RefreshCountDownAndGoPos(bool showCountDown, ulong endTime = 0uL)
	{
	}

	private void TickCountDown(ulong endTime)
	{
	}

	private void OnObtainLaunchTag()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private UITable2.IUITable2Item _003CInitShoppingMallItemTemplate_003Eb__26_0()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
