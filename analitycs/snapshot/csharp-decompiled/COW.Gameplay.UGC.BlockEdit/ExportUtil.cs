using message;

namespace COW.Gameplay.UGC.BlockEdit;

public static class ExportUtil
{
	public static string ExportError;

	public static bool FillValue(BlockEditContext context, ValueData value, UGCVarValueDataV2 result)
	{
		return false;
	}

	public static void ExportInt(UGCVarValueDataV2 result, long intValue)
	{
	}

	public static bool ExportAs(BlockEditContext context, BlockData source, UGCVarValueDataV2 result)
	{
		return false;
	}

	public static UGCVarValueDataV2 ExportGlobalGraphId(BlockEditContext context)
	{
		return null;
	}

	public static UGCVarValueDataV2 ExportGlobalEntity(string ownerGraphId)
	{
		return null;
	}

	public static UGCVarValueDataV2 ExportGetThisEntityReplicationData(string ownerGraphId, int propertyIndex)
	{
		return null;
	}

	public static UGCVarValueDataV2 ExportGetReplicationData(string ownerGraphId, UGCVarValueDataV2 entity, int propertyIndex)
	{
		return null;
	}

	public static UGCVarValueDataV2 ExportThisEntity(string ownerGraphId)
	{
		return null;
	}

	public static bool NeedExtraCodeBlock(BlockData source)
	{
		return false;
	}

	public static bool NeedExport(BlockData source)
	{
		return false;
	}

	public static OverrideExportReport TakeOverExportBlockData(BlockEditContext context, BlockData source, DOMDODOIOBI result)
	{
		return default(OverrideExportReport);
	}

	public static OverrideExportReport OverrideExportBlockData(BlockData source, DOMDODOIOBI result)
	{
		return default(OverrideExportReport);
	}

	public static string ExportLocalVarName(string varName, string varId)
	{
		return null;
	}

	public static UGCVarValueDataV2 GetLocalVar(string ownerGraphId, string varName, string varId)
	{
		return null;
	}
}
