using COW.GamePlay;
using UnityEngine;

namespace COW;

public class UIHudDirectionRulerTeamMarkItem : MonoBehaviour
{
	public UISprite Sprite;

	private Vector3 _003CPosition_003Ek__BackingField;

	private float _003CSqrDistance_003Ek__BackingField;

	private BHGGAEEHJCO _003CPlayerID_003Ek__BackingField;

	public Transform LeftArrow;

	private int _003CSortIndex_003Ek__BackingField;

	public Vector3 Position
	{
		get
		{
			return _003CPosition_003Ek__BackingField;
		}
		set
		{
			_003CPosition_003Ek__BackingField = value;
		}
	}

	public float SqrDistance
	{
		get
		{
			return _003CSqrDistance_003Ek__BackingField;
		}
		set
		{
			_003CSqrDistance_003Ek__BackingField = value;
		}
	}

	public BHGGAEEHJCO PlayerID
	{
		get
		{
			return _003CPlayerID_003Ek__BackingField;
		}
		set
		{
			_003CPlayerID_003Ek__BackingField = value;
		}
	}

	public int SortIndex
	{
		get
		{
			return _003CSortIndex_003Ek__BackingField;
		}
		set
		{
			_003CSortIndex_003Ek__BackingField = value;
		}
	}
}
