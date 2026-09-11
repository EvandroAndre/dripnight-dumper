using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIModelBarrage : UIBaseModel
{
	private Dictionary<uint, Type> EBarrageTypeToUITypeDic;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelRelationShip m_ModelRelation;

	private Dictionary<uint, BarrageConfigData> m_BarrageLauncherConfigDict;

	private Dictionary<uint, Dictionary<uint, HashSet<int>>> m_BarrageRowToTypeDict;

	public const uint PropID_BarrageDataExist = 1u;

	private UIModelClanWarV2 ModelClanWarV2 => null;

	private UIModelRelationShip ModelRelation => null;

	private Dictionary<uint, BarrageConfigData> BarrageLauncherConfigDict => null;

	private Dictionary<uint, Dictionary<uint, HashSet<int>>> BarrageRowToTypeDict => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public HashSet<int> GetEBarrageTypesByRowId(int barrageType, uint rowId)
	{
		return null;
	}

	public HashSet<int> GetEBarrageTypesByRowId(HashSet<int> barrageTypes, uint rowId)
	{
		return null;
	}

	public Type GetControllerTypeByEBarrageType(EBarrageType barrageType)
	{
		return null;
	}

	public BarrageSingleConfig GetBarrageOneRowConfigByTypeAndRowId(EBarrageType barrageType, uint rowId)
	{
		return null;
	}

	public void CheckIsExistBarrageData()
	{
	}
}
