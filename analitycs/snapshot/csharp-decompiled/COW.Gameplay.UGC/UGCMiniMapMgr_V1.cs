using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCMiniMapMgr_V1 : UGCMiniMapMgr
{
	private UGCEntityDataStore _repDataMgr;

	protected HashSet<string> m_DirtyMapItemList;

	protected Dictionary<string, Rect> m_ItemRectCache;

	private uint m_MapID;

	private uint m_AreaID;

	public override void Init()
	{
	}

	public override void UnInit()
	{
	}

	public override void InitMiniMapByLevel(List<OKFGLFKOBEJ> allSubLevels)
	{
	}

	public override void UpdateObjectInGame(string entityID)
	{
	}

	protected override void OnUpdateGameMapNow()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_UnInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitMiniMapByLevel(List<OKFGLFKOBEJ> P0)
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateObjectInGame(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdateGameMapNow()
	{
	}
}
