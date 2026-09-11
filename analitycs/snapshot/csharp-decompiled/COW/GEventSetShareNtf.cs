using GCommon;

namespace COW;

public class GEventSetShareNtf : GEvent
{
	public EPrimeShareClothesBubbleState State;

	public ulong ShareeAccountID;

	public ulong SharerAccountID;

	public uint SetShareID;
}
