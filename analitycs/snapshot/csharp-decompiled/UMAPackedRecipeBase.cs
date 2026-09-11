using System;
using UMA;

public abstract class UMAPackedRecipeBase : UMARecipeBase
{
	[Serializable]
	public class packedSlotData
	{
		public string slotID;

		public int overlayScale;

		public int copyOverlayIndex;

		public packedOverlayData[] OverlayDataList;
	}

	[Serializable]
	public class packedOverlayData
	{
		public string overlayID;

		public int[] colorList;

		public int[][] channelMaskList;

		public int[][] channelAdditiveMaskList;

		public int[] rectList;
	}

	[Serializable]
	public class PackedSlotDataV2
	{
		public string id;

		public int scale;

		public int copyIdx;

		public PackedOverlayDataV2[] overlays;
	}

	[Serializable]
	public class PackedOverlayDataV2
	{
		public string id;

		public int colorIdx;

		public int[] rect;
	}

	[Serializable]
	public class PackedOverlayColorDataV2
	{
		public string name;

		public byte[] color;

		public byte[][] masks;

		public byte[][] addMasks;

		public void SetOverlayColorData(OverlayColorData overlayColorData)
		{
		}
	}

	[Serializable]
	public class PackedOverlayColorDataV3
	{
		public string name;

		public short[] colors;

		public PackedOverlayColorDataV3()
		{
		}

		public PackedOverlayColorDataV3(OverlayColorData colorData)
		{
		}

		public void SetOverlayColorData(OverlayColorData overlayColorData)
		{
		}
	}

	[Serializable]
	public class UMAPackRecipe
	{
		public int version;

		public packedSlotData[] packedSlotDataList;

		public PackedSlotDataV2[] slotsV2;

		public PackedOverlayColorDataV2[] colors;

		public PackedOverlayColorDataV3[] fColors;

		public int sharedColorCount;

		public string race;

		public static bool ArrayHasData(Array array)
		{
			return false;
		}

		public static bool SlotIsValid(SlotData slotData)
		{
			return false;
		}

		public static bool SlotIsValid(PackedSlotDataV2 packedSlot)
		{
			return false;
		}

		public static bool MaterialIsValid(UMAMaterial material)
		{
			return false;
		}

		public static bool RaceIsValid(RaceData raceData)
		{
			return false;
		}
	}

	public override void Load(UMAData.UMARecipe umaRecipe, UMAContext context)
	{
	}

	public override void Save(UMAData.UMARecipe umaRecipe, UMAContext context)
	{
	}

	public abstract UMAPackRecipe PackedLoad(UMAContext context);

	public abstract void PackedSave(UMAPackRecipe packedRecipe, UMAContext context);

	public static UMAPackRecipe PackRecipeV2(UMAData.UMARecipe umaRecipe)
	{
		return null;
	}

	public static UMAData.UMARecipe UnpackRecipeVersion2(UMAPackRecipe umaPackRecipe, UMAContext context)
	{
		return null;
	}

	public static void UnpackRecipeVersion2(UMAData.UMARecipe umaRecipe, UMAPackRecipe umaPackRecipe, UMAContext context)
	{
	}

	private static OverlayData InstantiateOverlay(UMAContext context, SlotData tempSlotData, string id)
	{
		return null;
	}
}
