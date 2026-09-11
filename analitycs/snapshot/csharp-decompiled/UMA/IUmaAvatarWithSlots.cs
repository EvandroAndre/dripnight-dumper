using System.Collections.Generic;

namespace UMA;

public interface IUmaAvatarWithSlots : IUmaAvatarBase
{
	void SetSlot(int recipeHash);

	void SetSlot(int recipeHash, uint id);

	void ClearSlot(string slot);

	void ClearSlots();

	bool IsSlotVisible(string slot);

	bool HasSlot(string slot);

	List<uint> GetIds();
}
