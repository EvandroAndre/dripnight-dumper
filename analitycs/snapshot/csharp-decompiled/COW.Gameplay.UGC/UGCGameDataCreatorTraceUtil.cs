using message;

namespace COW.Gameplay.UGC;

public static class UGCGameDataCreatorTraceUtil
{
	private const int MaxRecordCount = 5;

	private const byte EncodeSeed = 90;

	public static void Apply(JOEANMPIFAB runtimeData, uint slotID)
	{
	}

	public static void Apply(JOEANMPIFAB runtimeData, bool hasSourceTrace, UGCGameDataCreatorTrace sourceTrace)
	{
	}

	public static bool TryExtractFromRuntimeBytes(byte[] runtimeBytes, out UGCGameDataCreatorTrace trace)
	{
		trace = default(UGCGameDataCreatorTrace);
		return false;
	}

	private static bool TryExtractFromLocalRuntime(uint slotID, out UGCGameDataCreatorTrace trace)
	{
		trace = default(UGCGameDataCreatorTrace);
		return false;
	}

	private static bool TryExtract(JOEANMPIFAB runtimeData, out UGCGameDataCreatorTrace trace)
	{
		trace = default(UGCGameDataCreatorTrace);
		return false;
	}

	private static MKFBKNBKBCJ GetOrCreateOpenAttribute(JOEANMPIFAB runtimeData)
	{
		return null;
	}

	private static MKFBKNBKBCJ GetOpenAttribute(JOEANMPIFAB runtimeData)
	{
		return null;
	}

	private static ulong GetCurrentAccountId()
	{
		return 0uL;
	}

	private static string BuildRecord(ulong accountId, ulong editTs)
	{
		return null;
	}

	private static string Encode(string value)
	{
		return null;
	}

	private static string Decode(string value)
	{
		return null;
	}

	private static byte GetKey(int index)
	{
		return 0;
	}
}
