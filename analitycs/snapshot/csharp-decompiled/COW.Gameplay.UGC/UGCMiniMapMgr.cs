using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCMiniMapMgr
{
	private HIMMHCLHMGK m_WorkShopGridMgr;

	protected float[,] m_WSMapArray;

	protected bool m_MiniMapVisible;

	public Texture2D WSMapTexture;

	protected bool _enableMinimapUpdate;

	protected bool m_SceneMapDirty;

	private bool m_MapDirty;

	protected float m_UpdateDelay;

	private Color m_WSItemHideColor;

	private Color defaultC;

	private int textureResolution;

	private int[,] WorkShopMapColorArr;

	private HashSet<int> m_DirtyMapSceneItemSet;

	public Dictionary<string, WorkShopItemInfo> m_ItemInfoCache;

	public Dictionary<string, IconInfo> m_ItemIconCache;

	private UGCEntityDataStore _repDataMgr;

	protected bool m_DepthMode;

	protected HashSet<uint> SmallMapIDSet;

	protected List<Collider> m_WorkingColliderList;

	protected List<Collider> m_TempColliderList;

	public FFEAJEKGIIF SceneBuilder => null;

	public HIMMHCLHMGK WorkShopGridMgr
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float[,] WSMapArray => null;

	public bool IsSceneMapDirty
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float LowestObjectY => 0f;

	public bool IsMapDirty
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetMiniMapVisible(bool value)
	{
	}

	public virtual void Init()
	{
	}

	public virtual void UnInit()
	{
	}

	public void UpdateObjectInScene(int idx)
	{
	}

	private void UpdateSceneMapNow()
	{
	}

	public void ClearSceneEditMap()
	{
	}

	public virtual void InitMiniMapByLevel(List<OKFGLFKOBEJ> allSubLevels)
	{
	}

	public void UpdateBigMapMiniMapSetting(uint mapID, uint areaID)
	{
	}

	public virtual void UpdateObjectInGame(string entityID)
	{
	}

	protected void UpdateGameMapNow()
	{
	}

	protected virtual void OnUpdateGameMapNow()
	{
	}

	protected bool IsLevelObjectDestoryed(string entityID, out GameObject obj)
	{
		obj = null;
		return false;
	}

	protected bool IsItemShownOnMap(string entityID, uint itemID)
	{
		return false;
	}

	public void GenerateMapBgTexture(bool depthmode)
	{
	}

	protected void InitMiniBGTexture(uint mapID)
	{
	}

	protected void RemoveMapAreaName()
	{
	}

	protected uint GetBiggestSizeMap(List<OKFGLFKOBEJ> allLoadedSubLevel)
	{
		return 0u;
	}

	protected void RegisterColliders(GameObject obj)
	{
	}

	protected virtual void UpdateMapGridArray()
	{
	}
}
