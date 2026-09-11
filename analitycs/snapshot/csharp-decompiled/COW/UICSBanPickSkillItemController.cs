using GCommon;
using UnityEngine;

namespace COW;

public class UICSBanPickSkillItemController : UIEasyListItemController
{
	private UICSBanPickSkillItemView m_View;

	private bool m_IsCenterItem;

	private uint m_SkillID;

	private ECSBPPhase m_BPStatus;

	private UICSBanPickSkillItemData m_ItemData;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private CSBPContext m_Context;

	private UIModelBanPick m_ModelBanPick;

	private Color m_NormalColor;

	private Color m_DisabledColor;

	private const string BAN_LINE_ANIMATION_NAME = "UIFX_UICSBanPickSkillItem_Ban";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetBanResultInfo(uint skilld)
	{
	}

	private void RefreshBanResultUI()
	{
	}

	public void InitTopBanItemUI()
	{
	}

	public void RefreshTopBanItemChoosingUI(uint skillID)
	{
	}

	public void RefreshTopBanItemSelected(uint skillID)
	{
	}

	private void RefreshTopBanItemUI()
	{
	}

	private void RefreshSkillIcon()
	{
	}

	private void RefreshUI()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnClick2()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
