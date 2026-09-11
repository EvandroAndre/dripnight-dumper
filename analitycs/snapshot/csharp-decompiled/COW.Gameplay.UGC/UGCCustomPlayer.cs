using COW.GamePlay;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCCustomPlayer
{
	private int _003CCustomPlayerState_003Ek__BackingField;

	public string UGCEntityID;

	public Transform Obj;

	internal Player BindedPlayer;

	private UGCEntityDataStore m_DataStore;

	public int CustomPlayerState
	{
		get
		{
			return _003CCustomPlayerState_003Ek__BackingField;
		}
		private set
		{
			_003CCustomPlayerState_003Ek__BackingField = value;
		}
	}

	internal UGCCustomPlayer(string ugcEntityID, Player bindedPlayer, GameObject obj, UGCEntityDataStore dataStore)
	{
	}

	public void Destroy()
	{
	}

	public void SetCustomPlayerState(int state)
	{
	}

	public void SetVisualPosition(Vector3 pos)
	{
	}

	public void SetVisualRotation(Quaternion rot)
	{
	}
}
