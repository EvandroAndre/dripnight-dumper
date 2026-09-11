using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudTakeTurnsShopController : UIHudTakeTurnsShopBaseController
{
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public TweenScale ts;

		internal void _003COnOthersChoosingMaskClick_003Eb__0()
		{
		}
	}

	private LJDMEHFMAFK m_RoundState;

	private List<UIHudTakeTurnsShopRoundItemBaseController> m_RoundItemCtrls;

	private List<int> m_RoundTypes;

	private List<int> m_RoundStates;

	private HashSet<int> m_RoundScrollPlayed;

	private bool m_NeedPlayRoundScroll;

	private float m_RoundScrollStartX;

	private float m_RoundScrollTarX;

	private const float RoundScrollDuration = 1f;

	private uint m_OthersChoosingMaskDelayCall;

	private UIHudCSShopWeaponDetailController m_WeaponDetail;

	protected Vector3 m_TitleRootPosDefault;

	protected Color m_TitleLabelColorDefault;

	protected Vector3 m_CloseBtnPosDefault;

	protected Color m_CloseIconColorDefault;

	protected string m_CloseIconNameDefault;

	protected Color m_BuyBtnLabelColorTopDefault;

	protected Color m_BuyBtnLabelColorBottomDefault;

	protected string m_BuyBtnIconDefault;

	private VisualInstanceHolder m_AdditionalUIHolder;

	private int m_DetailTouchFrame;

	protected override void OnVisibilityChanged()
	{
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void SetUIData()
	{
	}

	protected override void OnInitSpecialUIElement()
	{
	}

	protected override void RecordDefaultSkinInfo()
	{
	}

	private void SetSkin(bool resetToDefault = false)
	{
	}

	private void SetSkinElement(UISprite sprite, string name, string defaultName = null)
	{
	}

	protected override UIHudTakeTurnsShopCategoryBaseController CreateCategory(Transform container)
	{
		return null;
	}

	public void SetTakeTurnsShopView(LJDMEHFMAFK state, int curRound, int maxRound)
	{
	}

	private void SetItemView(LJDMEHFMAFK state, int curRound, int maxRound)
	{
	}

	private void SetRoundItem(int curRound, int maxRound)
	{
	}

	private UIHudTakeTurnsShopRoundItemBaseController CreateItem()
	{
		return null;
	}

	private void Update()
	{
	}

	protected override bool CheckCanPurchase()
	{
		return false;
	}

	private void OnOthersChoosingMaskClick(object[] data)
	{
	}

	private void OnLongPress(object[] param)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetUIData()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnInitSpecialUIElement()
	{
	}

	public void _003C_003EiFixBaseProxy_RecordDefaultSkinInfo()
	{
	}

	public UIHudTakeTurnsShopCategoryBaseController _003C_003EiFixBaseProxy_CreateCategory(Transform P0)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_CheckCanPurchase()
	{
		return false;
	}
}
