using COW.GamePlay;
using UnityEngine;

namespace COW;

public class CSRoundDragonMapObject
{
	private LevelCSRoundDragon m_Dragon;

	public GameObject DragonObject;

	private Transform m_MapContainer;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	public void SetMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void OnUIInit(Transform container, GameObject dragon)
	{
	}

	public void OnCSRoundDragonCreate(object[] data)
	{
	}

	public void OnCSRoundDragonRecycle(object[] data)
	{
	}

	public void UpdateDragonPosition(bool updateInterval = false)
	{
	}

	public bool IsSelf(uint dragonID)
	{
		return false;
	}

	public bool IsRecycled()
	{
		return false;
	}
}
