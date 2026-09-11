using System.Collections.Generic;
using COW.GamePlay;

namespace COW;

public interface IHippoCrisisBackPackItemUIData
{
	ulong UniqueId { get; }

	uint Itemid { get; }

	PIJKGPDBNJC ItemType { get; }

	uint? Durability { get; set; }

	bool IsEnergyWeapon { get; }

	uint? AmmoNum { get; set; }

	uint? AmmoCapacity { get; }

	uint Num { get; set; }

	uint TotalWeight { get; }

	uint TotalValue { get; }

	uint TotalBuyPrice { get; }

	List<IHippoCrisisBackPackItemUIData> Attachments { get; }
}
