using System.Collections.Generic;
using proto;

namespace COW;

public class HippoCrisisOutGameEquipmentData : IHippoCrisisEquipmentBackpackData
{
	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public IHippoCrisisBackPackItemUIData item;

		internal bool _003CSplitItem_003Eb__0(IHippoCrisisBackPackItemUIData o)
		{
			return false;
		}

		internal bool _003CSplitItem_003Eb__1(IHippoCrisisBackPackItemUIData o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public IHippoCrisisBackPackItemUIData item;

		internal bool _003CRemoveItem_003Eb__0(IHippoCrisisBackPackItemUIData x)
		{
			return false;
		}

		internal bool _003CRemoveItem_003Eb__1(IHippoCrisisBackPackItemUIData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass63_0
	{
		public HippoInventoryChangeInfo modify;

		internal bool _003CUpdateInfoByModifyInfos_003Eb__1(IHippoCrisisBackPackItemUIData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass63_1
	{
		public HippoInventoryEquipItem changeItem;

		internal bool _003CUpdateInfoByModifyInfos_003Eb__0(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}
	}

	public IHippoCrisisBackPackItemUIData m_MainWeapon1;

	public IHippoCrisisBackPackItemUIData m_MainWeapon2;

	public IHippoCrisisBackPackItemUIData m_SecondaryWeapon;

	public IHippoCrisisBackPackItemUIData m_MeleeWeapon;

	public IHippoCrisisBackPackItemUIData m_BodyArmor;

	public IHippoCrisisBackPackItemUIData m_Helmet;

	public IHippoCrisisBackPackItemUIData m_SkillChip;

	public IHippoCrisisBackPackItemUIData m_Backpack;

	public List<IHippoCrisisBackPackItemUIData> m_BackpackItems;

	public List<IHippoCrisisBackPackItemUIData> m_SafeBox;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	public List<HippoInventoryEquipItem> m_AllEquipments;

	public UIModelHippoCrisis ModelHippoCrisis => null;

	public uint BackpackTotalcapacity => 0u;

	public uint BackpackRemainingcapacity => 0u;

	public uint BackpackUsagecapacity => 0u;

	public IHippoCrisisBackPackItemUIData MainWeapon1 => null;

	public IHippoCrisisBackPackItemUIData MainWeapon2 => null;

	public IHippoCrisisBackPackItemUIData SecondaryWeapon => null;

	public IHippoCrisisBackPackItemUIData MeleeWeapon => null;

	public IHippoCrisisBackPackItemUIData BodyArmor => null;

	public IHippoCrisisBackPackItemUIData Helmet => null;

	public IHippoCrisisBackPackItemUIData SkillChip => null;

	public IHippoCrisisBackPackItemUIData Backpack => null;

	public List<IHippoCrisisBackPackItemUIData> BackpackItems => null;

	public List<IHippoCrisisBackPackItemUIData> SafeBoxItems => null;

	public uint SafeBoxTotalcapacity => 0u;

	public uint SafeBoxRemainingcapacity => 0u;

	uint IHippoCrisisEquipmentBackpackData.AllEquipmentValue => 0u;

	public uint AllEquipmentWeight => 0u;

	public bool RepairItem(List<IHippoCrisisBackPackItemUIData> items)
	{
		return false;
	}

	bool IHippoCrisisEquipmentBackpackData.DropItem(IHippoCrisisBackPackItemUIData item, uint dropNum, EHippoInventory.EquipType equipType, EHippoCrisisEquipmentSlot inventorySlot = EHippoCrisisEquipmentSlot.None)
	{
		return false;
	}

	public bool SplitItem(IHippoCrisisBackPackItemUIData item, uint splitNum, EHippoInventory.EquipType fromEquipType, EHippoInventory.EquipType targetEquipType)
	{
		return false;
	}

	bool IHippoCrisisEquipmentBackpackData.ExchangeItem(IHippoCrisisBackPackItemUIData fromItem, IHippoCrisisBackPackItemUIData toItem, EHippoInventory.EquipType fromEquipType, EHippoInventory.EquipType toEquipType, EHippoCrisisEquipmentSlot fromItemSlot = EHippoCrisisEquipmentSlot.None, EHippoCrisisEquipmentSlot toItemSlot = EHippoCrisisEquipmentSlot.None)
	{
		return false;
	}

	public bool AddItem(IHippoCrisisBackPackItemUIData item, EHippoInventory.EquipType targetEquipType, EHippoCrisisEquipmentSlot targetSlot)
	{
		return false;
	}

	public bool MoveItem(IHippoCrisisBackPackItemUIData item, EHippoInventory.EquipType fromEquipType, EHippoCrisisEquipmentSlot fromSlot, EHippoInventory.EquipType toEquipType, EHippoCrisisEquipmentSlot toSlot)
	{
		return false;
	}

	private void NotiRefreshUI(EHippoInventory.EquipType fromEquipType, EHippoInventory.EquipType toEquipType, bool isForceRefreshBag = false)
	{
	}

	public void RemoveItem(IHippoCrisisBackPackItemUIData item, EHippoInventory.EquipType fromEquipType, EHippoCrisisEquipmentSlot fromSlot)
	{
	}

	private void UnequipItemBySlot(EHippoCrisisEquipmentSlot fromSlot, IHippoCrisisBackPackItemUIData item)
	{
	}

	private void UnequipAttachFromItem(IHippoCrisisBackPackItemUIData item, IHippoCrisisBackPackItemUIData attach)
	{
	}

	private void EquipAttachForItem(IHippoCrisisBackPackItemUIData item, IHippoCrisisBackPackItemUIData attach)
	{
	}

	private void AddItemInteral(IHippoCrisisBackPackItemUIData item, EHippoInventory.EquipType targetEquipType, EHippoCrisisEquipmentSlot targetSlot)
	{
	}

	private void EquipItemBySlot(IHippoCrisisBackPackItemUIData item, EHippoCrisisEquipmentSlot fromSlot)
	{
	}

	public HippoCrisisOutGameEquipmentData()
	{
	}

	public HippoCrisisOutGameEquipmentData(CSGetHippoInventoryAccountInfoRes info)
	{
	}

	public void UpdateInfoByModifyInfos(List<HippoInventoryChangeInfo> change_list)
	{
	}

	public void RefreshAllEquipmentFromtList()
	{
	}

	public static void CopyOutGameItemUIDataList(ref List<IHippoCrisisBackPackItemUIData> sourceList, List<IHippoCrisisBackPackItemUIData> targetList)
	{
	}

	public static void CopyFrom(ref HippoCrisisOutGameEquipmentData source, HippoCrisisOutGameEquipmentData target)
	{
	}
}
