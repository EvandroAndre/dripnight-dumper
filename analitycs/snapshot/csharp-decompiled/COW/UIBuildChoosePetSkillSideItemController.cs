using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBuildChoosePetSkillSideItemController : UIBaseController, UITable2.IUITable2Item, IUIModelDataChangeObserver
{
	private uint m_SourceSkillID;

	private uint m_MaxPetLevel;

	private bool m_BuyPetWaitStoreRes;

	private int m_Index;

	private PetInfo m_PetInfo;

	private UIBuildChoosePetSkillSideItemView m_View;

	private UIPetSkillSlotController m_SlotCtrl;

	private UIModelPet m_ModelPet;

	private UIModelLoadout m_ModelLoadout;

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

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void OnBuyBtnClick()
	{
	}

	private void OnItemBtnSelected()
	{
	}

	private void SetViewData(object data, int data_index)
	{
	}

	public void SetLockAndEquip()
	{
	}

	private void BuyPet()
	{
	}

	public void SetBaseDepth(int depth)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
