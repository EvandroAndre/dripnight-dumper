using COW.GamePlay;
using GCommon;
using proto;

namespace COW;

public class UIHippoCrisisSplitWndController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public EventID eventId;

		internal void _003CStartGuide_003Eb__0()
		{
		}

		internal void _003CStartGuide_003Eb__1()
		{
		}
	}

	private UIHippoCrisisSplitWndView m_View;

	private uint m_MaxNum;

	private HENEHAGJCLI m_ItemData;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private uint m_SelectNum;

	private EHippoInventory.EquipType m_SourceEquipType;

	private EHippoInventory.EquipType m_DstEquipType;

	private EDragReleaseResponseAreaType m_DstAreaType;

	private EHippoCrisisEquipmentSlot m_SourceEquipmentSlot;

	private IHippoCrisisBackPackItemUIData m_ItemUIData;

	private uint BatchPlusNum;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(IHippoCrisisBackPackItemUIData itemUIData, EHippoInventory.EquipType sourceEquipType, EHippoInventory.EquipType dstEquipType, EDragReleaseResponseAreaType dstAreaType, EHippoCrisisEquipmentSlot sourceEquipmentSlot)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshValueAndWeight()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void UpdateBackpackDataChange(IHippoCrisisBackPackItemUIData data)
	{
	}

	private void OnMinusBtnClick()
	{
	}

	private void OnNumPlusBtnClick()
	{
	}

	private void OnPlusBtnClick()
	{
	}

	private void PlusNum(uint plusNum)
	{
	}

	private void OnSliderValueChange()
	{
	}

	private void SetModifyBtnView()
	{
	}

	private void SetMinBtnView()
	{
	}

	private void SetPlusBtnView()
	{
	}

	private void StartGuide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
