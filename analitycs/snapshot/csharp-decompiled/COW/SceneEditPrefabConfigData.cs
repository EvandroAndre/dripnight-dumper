using GCommon;
using UnityEngine;

namespace COW;

public class SceneEditPrefabConfigData : CSVBaseData
{
	public enum ItemShowType
	{
		AllPlatform,
		CraftlandOnly,
		FEOnly
	}

	public uint ItemID;

	public string UGCTypeName;

	public ResourceID EditAttributeConfigResID;

	public ResourceID FunctionAttributeConfigResID;

	public string ItemTips;

	public ResourceID PrefabResID;

	public ResourceID IconResID;

	public string IconResName;

	public string Name;

	public bool CanOverAll;

	public uint[] CanOverAllExcept;

	public bool CannotBeCovered;

	public float BoundExpands;

	public uint[] Foundations;

	public uint Cost;

	public bool ShowTex;

	public ResourceID ShadowResID;

	public ResourceID AOFieldsResID;

	public bool HasSubItem;

	public bool ShowGrass;

	public uint HP;

	public bool IsPreciseAdjust;

	public uint ItemType;

	public bool ShowBitMap;

	public uint NumLimit;

	public bool ShowIconMap;

	public bool CanAdjustFloor;

	public float GroupSelectedScale;

	public int ItemShowControl;

	public int ItemColor;

	public int GroupID;

	public uint[] ItemTex;

	public Vector3 BasePointOffset;

	public bool[] DisableRot;

	public uint ScaleMod;

	public bool[] DisableScale;

	public uint GeneratorGroupID;

	public bool CanFlyPut;

	public bool CanStack;

	public bool PhysicalLayerEditable;

	public string IconUrl;

	public bool FPVEnable;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public bool CanPutOn(SceneEditPrefabConfigData otherConfig)
	{
		return false;
	}

	public bool IsShowBitMap()
	{
		return false;
	}

	public bool IsShowIconMap()
	{
		return false;
	}

	public SceneEditPrefabConfigData Clone()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
