using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCMiniMapMgr_V2 : UGCMiniMapMgr
{
	public class MapIconItemEntity
	{
		private string _EntityID;

		private string _FollowEntityID;

		private Transform _FollowedObject;

		private UGCMiniMapIconRepItem _entityComp;

		private Vector3 OffsetPosition;

		private float IconScale;

		private int IconDepth;

		public MapIconItemEntity(string entityID)
		{
		}

		private void OnFollowTargetChange(string newValue)
		{
		}

		private void OnIconTypeChange(string newValue)
		{
		}

		private void OnOffsetChange(Vector3 newValue)
		{
		}

		private void OnScaleChange(float newValue)
		{
		}

		private void OnDepthChange(int newValue)
		{
		}

		public void Update(UISprite s)
		{
		}
	}

	public class MapBitItemEntity
	{
		private string _EntityID;

		private string _TargetEntityID;

		private string _CacheTargetEntityID;

		private UGCMiniMapBitRepItem _entityComp;

		public UGCMiniMapMgr_V2 Owner;

		public string TargetObjectEntityID => null;

		public MapBitItemEntity(string entityID)
		{
		}

		public void OnTargetChange(string targetID)
		{
		}

		public void OnTargetObjectCreated(GameObject o)
		{
		}

		public void OnRemoveEntity()
		{
		}
	}

	private UGCEntityDataStore _repDataMgr;

	private string _MapEntityID;

	private UGCMiniMapRepItem _MapComp;

	private int m_Width;

	private Vector3 m_WorldCenter;

	private Vector4 defalutOffset;

	private Dictionary<string, MapIconItemEntity> m_Icons;

	private Dictionary<string, MapBitItemEntity> m_BitsItems;

	private bool _needRemoveGrass;

	private HashSet<string> _removeGrassEntityCache;

	protected Dictionary<string, Rect> m_ItemRectCache;

	public Dictionary<string, MapIconItemEntity> Icons => null;

	public string MapEntityID => null;

	private bool NeedRemoveGrass
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override void Init()
	{
	}

	public override void UnInit()
	{
	}

	private void OnAddMiniMapEntity(string entityID)
	{
	}

	private void OnRemoveMiniMapEntity(string entityID)
	{
	}

	private void OnAddMiniMapIconEntity(string entityID)
	{
	}

	private void OnRemoveMiniMapIconEntity(string entityID)
	{
	}

	private void OnAddMiniMapBitEntity(string entityID)
	{
	}

	private void OnRemoveMiniMapBitEnity(string entityID)
	{
	}

	private void OnChangeMapCenter(Vector3 valueNew)
	{
	}

	private void OnChangeMapSize(int valueNew)
	{
	}

	private void OnChangeDepthMode(bool valueNew)
	{
	}

	private void UpdateMapOffset(Vector3 worldCenter, int width)
	{
	}

	private void ReGenerateBitEntityPos()
	{
	}

	public void OnBitItemTargetChange(string oldEntity, string newEntity, GameObject obj)
	{
	}

	protected override void OnUpdateGameMapNow()
	{
	}

	public override void UpdateObjectInGame(string entityID)
	{
	}

	private void UpdateGrass()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_UnInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdateGameMapNow()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateObjectInGame(string P0)
	{
	}
}
