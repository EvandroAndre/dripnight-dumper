using System.Collections.Generic;
using COW.GamePlay;
using proto;
using tcp;

namespace COW;

public class HippoCrisisOutGameItemUIData : IHippoCrisisBackPackItemUIData
{
	private ulong m_UniqueId;

	private uint m_ItemID;

	private uint? m_Durability;

	private uint? m_AmmoNum;

	private uint m_Num;

	private uint m_SelectedNum;

	private PIJKGPDBNJC m_Type;

	private List<IHippoCrisisBackPackItemUIData> m_Attachments;

	private HENEHAGJCLI m_ItemData;

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

	public HippoCrisisOutGameItemUIData()
	{
	}

	public HippoCrisisOutGameItemUIData(IHippoCrisisBackPackItemUIData targetData)
	{
	}

	public HippoCrisisOutGameItemUIData(proto.HippoInventoryItem item)
	{
	}

	public HippoCrisisOutGameItemUIData(tcp.HippoInventoryItem item)
	{
	}

	public HippoCrisisOutGameItemUIData(proto.HippoInventoryItem.AttachmentInfo attachmentInfo)
	{
	}

	public HippoCrisisOutGameItemUIData(tcp.HippoInventoryItem.AttachmentInfo attachmentInfo)
	{
	}

	public HippoCrisisOutGameItemUIData(ItemCollect item)
	{
	}

	public HippoCrisisOutGameItemUIData(uint itemId)
	{
	}

	public int ItemLevel()
	{
		return 0;
	}

	public static void CopyFrom(ref IHippoCrisisBackPackItemUIData source, IHippoCrisisBackPackItemUIData target)
	{
	}

	public static void CopyFrom(ref HippoCrisisOutGameItemUIData source, HippoCrisisOutGameItemUIData target)
	{
	}

	public static void SplitFrom(ref IHippoCrisisBackPackItemUIData source, IHippoCrisisBackPackItemUIData target, uint splitNum)
	{
	}
}
