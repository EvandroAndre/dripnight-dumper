using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UITopButtonGroupController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CDelayRepostion_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITopButtonGroupController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRepostion_003Ed__49(int _003C_003E1__state)
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

	private UITopButtonGroupView m_View;

	private Dictionary<int, UISprite> m_TokenSpriteDic;

	private Dictionary<int, UILabel> m_TokenCountLebelDic;

	private Dictionary<int, GameObject> m_TokenTimeLimitDic;

	private Dictionary<int, UIButton> m_TokenButtonDic;

	private Dictionary<int, UIWidget> m_TokenSpaceDic;

	private UIModelUser m_ModelUser;

	private List<UIBaseController> m_CustomControllerList;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private readonly List<UITopButtonGotoTokenController> m_GotoTokenControllerList;

	private UITopButtonGroupGachaCouponsController m_GachaCouponController;

	private UITopButtonGroupDrawshopCouponsController m_DrawShopCouponController;

	private UILobbyV2TopButtonController m_LobbyV2TopCtrl;

	private const float BATTERY_EMPTY_DISPLAY_SCALE = 0.1f;

	private const float BATTERY_LEVEL_THRESHOLD_LOW_MEDIUM = 0.2f;

	private const float BATTERY_LEVEL_THRESHOLD_MEDIUM_HIGH = 0.5f;

	private readonly Color BATTERY_LEVEL_COLOR_LOW;

	private readonly Color BATTERY_LEVEL_COLOR_MEDIUM;

	private readonly Color BATTERY_LEVEL_COLOR_HIGH;

	private readonly Color BATTERY_LEVEL_COLOR_CHARGING;

	private Vector3 batteryLevelScale;

	public UIWidget HelpBtnWidget => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public UIBaseController AddCustomControl(Type customControllerType)
	{
		return null;
	}

	public void ClearAllCustomControl()
	{
	}

	public void SetViewState(bool isLobby)
	{
	}

	public void ShowNaviPage(bool show)
	{
	}

	public void ShowHelpBtn(bool show)
	{
	}

	public void NaviPageReposition()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	protected virtual void OnBackButtonClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnSettingBtnInRoomClick()
	{
	}

	public void ShowSettingBtnInNaviPage(bool show)
	{
	}

	public void RefreshOwnerInfo()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void UpdateBattery(object[] parameters)
	{
	}

	public void UpdateTitle(string title, bool showPrivilegeIcon, BadgeInfoLobby badgeInfoLobby)
	{
	}

	public void ResetTopItemState()
	{
	}

	public void SetToken1Visibility(bool flag = false)
	{
	}

	public void SetToken2Visibility(bool flag = false)
	{
	}

	public void SetGachaCouponVisibility(bool flag = false)
	{
	}

	public void SetCloseSprite(ResourceID resID)
	{
	}

	public void SetCloseBGActive(bool flag)
	{
	}

	public void UpdateGotoBtnShow(ResourceID GotoSpriteID, ResourceID GotoTagID, string label)
	{
	}

	public void UpdateTokenByIndex(int index, ResourceID id, int num, bool timeLimit = false, uint itemID = 0u)
	{
	}

	public void UpdateGachaCoupon(uint chestID)
	{
	}

	public void UpdateDrawShopCoupon(uint chestID)
	{
	}

	private IEnumerator DelayRepostion()
	{
		return null;
	}

	internal UITopButtonGotoTokenController AddGotoToken(UINavigationTopbarViewData.GotoTokenDetailData detailData)
	{
		return null;
	}

	public void OnGotoTokenLayoutUpdate()
	{
	}

	public void CloseAllGotoToken(bool reposition = true)
	{
	}

	public void SetGotoTokenState(int index, bool state, bool reposition = true)
	{
	}

	public UIWidget GetGachaCouponGuideWidget()
	{
		return null;
	}

	public UIWidget GetGachaCouponIconsWidget()
	{
		return null;
	}

	public UIButton GetGachaCouponButton()
	{
		return null;
	}

	public UITopButtonGotoTokenController GetGotoTokenByIndex(int index)
	{
		return null;
	}

	private void OnToken1Click()
	{
	}

	private void OnToken2Click()
	{
	}

	private void OnExchangeStoreClick()
	{
	}

	public void PlayAnimation()
	{
	}

	private void InitLobbyV2TopView()
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void _003CAddGotoToken_003Eb__50_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
