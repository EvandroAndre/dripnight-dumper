using System.Collections.Generic;

namespace proto;

public class CSGetKitchenBSettingRes
{
	public List<BigEventProgressAwardDesc> progress_award;

	public BigEventProgressCycleAwardDesc cycle_award;

	public KitchenBWishSettingDesc setting;

	public List<KitchenBNPCDesc> npc_descs;

	public List<KitchenBWishWordDesc> word_descs;
}
