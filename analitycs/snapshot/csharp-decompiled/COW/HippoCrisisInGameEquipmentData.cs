using System.Collections.Generic;
using proto;

namespace COW;

public class HippoCrisisInGameEquipmentData : IHippoCrisisEquipmentBackpackData
{
	private static HashSet<int> EquipSlotEnumValus;

	public uint m_Totalcapacity;

	public uint m_Remainingcapacity;

	public uint m_SafeBoxTotalcapacity;

	public uint m_SafeBoxRemainingcapacity;

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

	private Dictionary<ulong, IHippoCrisisBackPackItemUIData> m_BackpackItemsDic;

	private Dictionary<ulong, IHippoCrisisBackPackItemUIData> m_SafeBoxItemsDic;

	private Dictionary<ulong, IHippoCrisisBackPackItemUIData> m_EquipmentsDic;

	private Dictionary<ulong, IHippoCrisisBackPackItemUIData> m_AttachmentsDic;

	public uint BackpackUsagecapacity => 0u;

	public uint BackpackTotalcapacity => 0u;

	public uint BackpackRemainingcapacity => 0u;

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

	uint IHippoCrisisEquipmentBackpackData.SafeBoxTotalcapacity => 0u;

	uint IHippoCrisisEquipmentBackpackData.SafeBoxRemainingcapacity => 0u;

	uint IHippoCrisisEquipmentBackpackData.AllEquipmentValue => 0u;

	public static bool IsInEHippoCrisisEquipmentSlot(int slotId)
	{
		return false;
	}

	public void Clear()
	{
	}

	public bool RepairItem(List<IHippoCrisisBackPackItemUIData> item)
	{
		return false;
	}

	public bool AddItem(IHippoCrisisBackPackItemUIData item, EHippoInventory.EquipType targetEquipType, EHippoCrisisEquipmentSlot targetSlot)
	{
		return false;
	}

	public bool ExchangeItem(IHippoCrisisBackPackItemUIData fromItem, IHippoCrisisBackPackItemUIData toItem, EHippoInventory.EquipType fromEquipType, EHippoInventory.EquipType toEquipType, EHippoCrisisEquipmentSlot fromItemSlot = EHippoCrisisEquipmentSlot.None, EHippoCrisisEquipmentSlot toItemSlot = EHippoCrisisEquipmentSlot.None)
	{
		return false;
	}

	public bool MoveItem(IHippoCrisisBackPackItemUIData item, EHippoInventory.EquipType fromEquipType, EHippoCrisisEquipmentSlot fromSlot, EHippoInventory.EquipType toEquipType, EHippoCrisisEquipmentSlot toSlot)
	{
		return false;
	}

	public bool DropItem(IHippoCrisisBackPackItemUIData item, uint dropNum, EHippoInventory.EquipType equipType, EHippoCrisisEquipmentSlot inventorySlot = EHippoCrisisEquipmentSlot.None)
	{
		return false;
	}

	public bool SplitItem(IHippoCrisisBackPackItemUIData item, uint splitNum, EHippoInventory.EquipType fromEquipType, EHippoInventory.EquipType targetEquipType)
	{
		return false;
	}

	public bool TryGetItemUIData(ulong uniqueId, out IHippoCrisisBackPackItemUIData itemUIData)
	{
		itemUIData = null;
		return false;
	}

	public EHippoInventory.EquipType GetEquipType(ulong uniqueId)
	{
		return EHippoInventory.EquipType.EquipTypeWarehouse;
	}

	public void ModifyCapacity(uint maxCapacity, uint curCapacity)
	{
	}

	public void ModifySafeBoxCapacity(uint maxCapacity, uint curCapacity)
	{
	}

	public bool AddItemUIData(ulong uniqueId, uint dataId, uint num, EHippoInventory.EquipType targetEquipType, uint durability, int slotId = -1, ulong attachToEquipUniqueId = 0uL)
	{
		return false;
	}

	public bool AddItemUIData(IHippoCrisisBackPackItemUIData itemUIData, EHippoInventory.EquipType targetEquipType, int slotId = -1, ulong attachToEquipUniqueId = 0uL)
	{
		return false;
	}

	public bool RemoveItemUIData(ulong uniqueId)
	{
		return false;
	}

	public bool MoveItemUIData(ulong uniqueId, EHippoInventory.EquipType targetEquipType, out IHippoCrisisBackPackItemUIData oldItemUIData, int slotId = -1, ulong attachToEquipUniqueId = 0uL)
	{
		oldItemUIData = null;
		return false;
	}

	public bool ModifyItemUIData(ulong uniqueId, uint num, uint durability)
	{
		return false;
	}

	private bool AddItemUIDataToBackpack(ulong uniqueId, uint dataId, uint num, uint durability = 0u)
	{
		return false;
	}

	private bool AddItemUIDataToBackpack(IHippoCrisisBackPackItemUIData itemUIData)
	{
		return false;
	}

	private bool RemoveItemUIDataFromBackpack(ulong uniqueId)
	{
		return false;
	}

	private bool AddItemUIDataToSafeBox(ulong uniqueId, uint dataId, uint num, uint durability = 0u)
	{
		return false;
	}

	private bool AddItemUIDataToSafeBox(IHippoCrisisBackPackItemUIData itemUIData)
	{
		return false;
	}

	private bool RemoveItemUIDataFromSafeBox(ulong uniqueId)
	{
		return false;
	}

	private bool AddItemUIDataToEquipment(ulong uniqueId, uint dataId, uint num, uint durability, int slot, out IHippoCrisisBackPackItemUIData originItemUIData)
	{
		originItemUIData = null;
		return false;
	}

	private bool AddItemUIDataToEquipment(IHippoCrisisBackPackItemUIData itemUIData, int slot, out IHippoCrisisBackPackItemUIData originItemUIData)
	{
		originItemUIData = null;
		return false;
	}

	private bool RemoveItemUIDataFromEquipment(ulong uniqueId, int slot, out IHippoCrisisBackPackItemUIData originItemUIData)
	{
		originItemUIData = null;
		return false;
	}

	private IHippoCrisisBackPackItemUIData GetEquipmentBySlot(int slot)
	{
		return null;
	}

	private void SetEquipmentBySlot(int slot, IHippoCrisisBackPackItemUIData itemUIData)
	{
	}

	private bool AddItemUIDataToAttachment(ulong uniqueId, uint dataId, ulong attachToEquipUniqueId, out IHippoCrisisBackPackItemUIData originItemUIData)
	{
		originItemUIData = null;
		return false;
	}

	private bool AddItemUIDataToAttachment(IHippoCrisisBackPackItemUIData itemUIData, ulong attachToEquipUniqueId, out IHippoCrisisBackPackItemUIData originItemUIData)
	{
		originItemUIData = null;
		return false;
	}

	private bool RemoveItemUIDataFromAttachment(ulong uniqueId, ulong attachToEquipUniqueId, out IHippoCrisisBackPackItemUIData originItemUIData)
	{
		originItemUIData = null;
		return false;
	}
}
