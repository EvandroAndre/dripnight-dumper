using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class LevelBalloonManager
{
	private LinkedList<LevelBalloon> levelBalloonsList;

	private readonly ResourceID[] balloonResourceIDs;

	private readonly int maxBalloonNum;

	public LevelBalloon CreateBalloon(Vector3 pos)
	{
		return null;
	}

	private void CheckBalloonCapacity()
	{
	}

	public void OnBalloonDestroy(LinkedListNode<LevelBalloon> node)
	{
	}

	private ResourceID GetBalloonResource()
	{
		return default(ResourceID);
	}
}
