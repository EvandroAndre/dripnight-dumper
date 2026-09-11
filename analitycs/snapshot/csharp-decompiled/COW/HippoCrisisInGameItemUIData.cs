using System.Collections.Generic;
using COW.GamePlay;
using proto;

namespace COW;

public class HippoCrisisInGameItemUIData : IHippoCrisisBackPackItemUIData
{
	private ulong m_UniqueId;

	private uint m_ItemID;

	private uint? m_Durability;

	private uint? m_AmmoNum;

	private uint? m_AmmoCapacity;

	private uint m_Num;

	private uint m_SelectedNum;

	private PIJKGPDBNJC m_Type;

	private List<IHippoCrisisBackPackItemUIData> m_Attachments;

	private HENEHAGJCLI m_ItemData;

	private Dictionary<int, IHippoCrisisBackPackItemUIData> m_AttachmentsDic;

	public EHippoInventory.EquipType EquipType;

	private bool m_IsAttachment;

	public ulong AttachToEquipUniqueId;

	public EHippoCrisisEquipmentSlot EquipSlot;

	public bool IsAttachment => false;

	public List<IHippoCrisisBackPackItemUIData> Attachments => null;

	public PIJKGPDBNJC ItemType => PIJKGPDBNJC.Weapon;

	public ulong UniqueId => 0uL;

	public uint Itemid => 0u;

	public uint? Durability
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint Num
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool IsEnergyWeapon => false;

	public uint? AmmoNum
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint? AmmoCapacity => null;

	public uint TotalWeight => 0u;

	public uint TotalValue => 0u;

	public uint TotalBuyPrice => 0u;

	public uint SelectedNum
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public HippoCrisisInGameItemUIData()
	{
	}

	public HippoCrisisInGameItemUIData(ulong uniqueId, uint dataId, uint num, EHippoInventory.EquipType equipType, uint durability = 0u)
	{
	}

	public bool AddAttachment(IHippoCrisisBackPackItemUIData attachment, out IHippoCrisisBackPackItemUIData originItemUIData)
	{
		originItemUIData = null;
		return false;
	}

	public bool RemoveAttachment(IHippoCrisisBackPackItemUIData attachment, out IHippoCrisisBackPackItemUIData originItemUIData)
	{
		originItemUIData = null;
		return false;
	}
}
