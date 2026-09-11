using System.Collections.Generic;

namespace UMA.Simple;

public class SlotOverlayHashPair
{
	public int SlotHash;

	public int OverlayHash;

	public bool NullOverlay;

	private static List<SlotOverlayHashPair> s_SharedList;

	public SlotOverlayHashPair(int s, int o, bool n)
	{
	}

	public static List<SlotOverlayHashPair> GetSharedList(bool clear = true)
	{
		return null;
	}
}
