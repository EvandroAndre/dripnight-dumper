using System;
using System.Collections.Generic;
using proto;

namespace COW;

public class SparkPetCustomInfoCache
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<SparkStageAppearance, IEnumerable<uint>> _003C_003E9__14_1;

		public static Func<SparkStageAppearance, IEnumerable<uint>> _003C_003E9__36_1;

		internal IEnumerable<uint> _003Cget_AppearanceItemIds_003Eb__14_1(SparkStageAppearance x)
		{
			return null;
		}

		internal IEnumerable<uint> _003CGetAppearanceItems_003Eb__36_1(SparkStageAppearance x)
		{
			return null;
		}
	}

	private uint temper;

	private uint appearance_stage;

	private uint colorID;

	private List<SparkStageAppearance> stage_appearance_items;

	private bool show_spark_in_lobby;

	private bool show_collab_spark;

	private bool isFirstChooseTemper;

	private bool isSystemChooseTemper;

	private bool isDirty;

	public uint Temper => 0u;

	public uint AppearanceStage => 0u;

	public uint[] AppearanceItemIds => null;

	public bool ShowSparkInLobby => false;

	public bool ShowCollabSpark => false;

	public bool IsFirstChooseTemper => false;

	public bool IsSystemChooseTemper => false;

	public bool IsDirty => false;

	public void Reset()
	{
	}

	public void CopyFrom(CSGetSparkInfoRes sparkInfo)
	{
	}

	private List<SparkStageAppearance> DeepCopyStageAppearanceItems(List<SparkStageAppearance> source)
	{
		return null;
	}

	public CSSetSparkCustomInfoReq ToRequest()
	{
		return null;
	}

	public void SetAppearanceStage(uint value)
	{
	}

	public void SetTemper(uint value)
	{
	}

	public uint GetTemper()
	{
		return 0u;
	}

	public uint GetAppearanceStage()
	{
		return 0u;
	}

	public void SetColorID(uint value)
	{
	}

	public uint GetColorID()
	{
		return 0u;
	}

	public void SetAppearanceItems(uint[] value)
	{
	}

	public uint[] GetAppearanceItems()
	{
		return null;
	}

	public void SetShowSparkInLobby(bool value)
	{
	}

	public void SetShowCollabSpark(bool value)
	{
	}

	public void SetIsFirstChooseTemper(bool value)
	{
	}

	public void SetIsSystemChooseTemper(bool value)
	{
	}

	public bool CheckIsDirty(CSGetSparkInfoRes sparkInfo)
	{
		return false;
	}

	private bool AppearanceItemsEqual(List<SparkStageAppearance> appearanceItems1, List<SparkStageAppearance> appearanceItems2)
	{
		return false;
	}

	private bool ArrayEqual(uint[] arr1, uint[] arr2)
	{
		return false;
	}

	private bool _003Cget_AppearanceItemIds_003Eb__14_0(SparkStageAppearance x)
	{
		return false;
	}

	private bool _003CGetAppearanceItems_003Eb__36_0(SparkStageAppearance x)
	{
		return false;
	}
}
