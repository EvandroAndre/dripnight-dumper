using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBaseChooseLoadoutPopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public List<UIBaseChooseLoadoutItemController> m_LoadOutItemCtrls;

	public List<UILabel> m_TagsLabel;

	public List<UISprite> m_TagsSprite;

	public UIModelLoadout m_ModelLoadout;

	public UIModelMall m_ModelMall;

	public UIModelInventory m_ModelInventory;

	public UIGrid m_Grid;

	public UILabel m_LoadoutNameLabel;

	public UISprite m_TagSprite1;

	public UISprite m_TagSprite2;

	public UISprite m_TagSprite3;

	public UILabel m_TagLabel1;

	public UILabel m_TagLabel2;

	public UILabel m_TagLabel3;

	public UITable m_TagTable;

	public UITable m_DescriptionTable;

	public UILabel m_BRLabel;

	public UILabel m_BRDescriptionLabel;

	public UILabel m_CSLabel;

	public UILabel m_CSDescriptionLabel;

	public UILabel m_EmptyLabel;

	public GameObject m_LoadoutDesc;

	public UIButton m_BuyBtn;

	public UISprite m_AdjustIcon;

	public UIButton m_AdjustBtn;

	protected UIButton m_V1Btn;

	protected UIButton m_V2Btn;

	protected Transform m_V1;

	protected Transform m_V2;

	protected GameObject m_Tab;

	protected GameObject m_V1Select;

	protected GameObject m_V1Unselect;

	protected GameObject m_V2Unselect;

	protected GameObject m_V2Select;

	public UIButton m_BtnBR;

	public UIButton m_BtnCS;

	public GameObject m_BRSelect;

	public GameObject m_BRUnselect;

	public GameObject m_CSSelect;

	public GameObject m_CSUnselect;

	public UILabel m_DescriptionLabel;

	public UINetworkTexture m_CDNTextureTutorials;

	public UILabel m_BRTabLabel;

	public UILabel m_CSTabLabel;

	public UILabel m_BRTabUnselectLabel;

	public UILabel m_CSTabUnselectLabel;

	public int m_SelectIndex;

	public bool m_IsBRSelect;

	public int m_EquipIndex;

	protected bool m_IsV2Open;

	private bool m_IsOnlyShowV2;

	private bool m_IsCurShowV1;

	protected UIBaseChooseLoadoutV2Controller m_V2Ctrl;

	private bool m_IsCSBPMode;

	public bool IsCSBPMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected virtual void InitView()
	{
	}

	protected virtual void InitV1ViewWhenV2Open()
	{
	}

	protected virtual void RefreshLoadout()
	{
	}

	protected virtual void RefreshLoadoutV1()
	{
	}

	protected virtual void RefreshLoadoutV2()
	{
	}

	protected virtual void InitLoadoutV2Ctrl()
	{
	}

	protected virtual void BuildLoadoutsUI(List<Item> loadoutList)
	{
	}

	protected virtual void OnSelectLoadout(int itemIdx)
	{
	}

	protected virtual UIBaseChooseLoadoutItemController GetItemController()
	{
		return null;
	}

	protected virtual void RefreshDesc()
	{
	}

	protected virtual void OnAdjustBtnClick()
	{
	}

	protected virtual void OnShopBtnClick()
	{
	}

	private void OnBtnV1Click()
	{
	}

	private void OnBtnV2Click()
	{
	}

	private void OnBtnBRClick()
	{
	}

	private void OnBtnCSClick()
	{
	}

	protected virtual void ChangeEquipIndex(int itemIdx)
	{
	}

	protected virtual void SetShopBtn(bool state)
	{
	}

	protected virtual void RequestEquipLoadout()
	{
	}

	protected virtual bool IsItemShow(Item item)
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
