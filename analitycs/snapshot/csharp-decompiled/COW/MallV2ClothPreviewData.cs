using System.Collections.Generic;

namespace COW;

public class MallV2ClothPreviewData
{
	public uint avatarId;

	public bool isFemale;

	public bool isSetSelect;

	public uint lasetSelectedCloth;

	public Dictionary<int, SlotClothInfo> clothDict;
}
