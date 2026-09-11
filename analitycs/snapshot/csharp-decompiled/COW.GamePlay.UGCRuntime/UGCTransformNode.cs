using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCTransformNode
{
	private enum DirtyProperty
	{
		WORLD_POS = 1,
		LOCAL_POS,
		WORLD_ROT,
		LOCAL_ROT,
		LOCAL_SCALE
	}

	private UGCTransformModule m_Manager;

	private string _003CEntityID_003Ek__BackingField;

	private Transform m_CachedTransform;

	private UGCTransformNode _003CParent_003Ek__BackingField;

	private List<UGCTransformNode> _003CChildren_003Ek__BackingField;

	private Vector3 _003CWorldPos_003Ek__BackingField;

	private Vector3 _003CLocalPos_003Ek__BackingField;

	private Quaternion _003CWorldRot_003Ek__BackingField;

	private Quaternion _003CLocalRot_003Ek__BackingField;

	private Vector3 _003CLocalScale_003Ek__BackingField;

	private Vector3 _003CWorldScale_003Ek__BackingField;

	private List<int> m_DirtyList;

	private static Vector3 V3Null;

	private static Quaternion QuatNull;

	private bool m_KeepWorldPos;

	private uint _003CLastPacketID_003Ek__BackingField;

	public SmoothingMethod SmoothingMethodType;

	private float m_AccumulatedErrorSeconds;

	private bool _003CAtRest_003Ek__BackingField;

	private bool _003CNeedSmooth_003Ek__BackingField;

	private bool _003CIncludePos_003Ek__BackingField;

	private bool _003CIncludeRot_003Ek__BackingField;

	private bool _003CIncludeScale_003Ek__BackingField;

	private bool _003CIsInterpolatingPos_003Ek__BackingField;

	private bool _003CIsInterpolatingRot_003Ek__BackingField;

	private bool _003CIsInterpolatingScale_003Ek__BackingField;

	private Vector3 _003CLinearVelocity_003Ek__BackingField;

	private Vector3 _003CAngularVelocity_003Ek__BackingField;

	private Vector3 m_VisualPos;

	private Quaternion m_VisualRot;

	private Vector3 m_VisualScale;

	public float EPSILON_POS;

	public float EPSILON_POS_SQUARE;

	public float EPSILON_ROT;

	public float EPSILON_SCALE;

	public float EPSILON_VEL_SQUARE;

	public float EPSILON_AVEL_SQUARE;

	public float MAX_ACCUMULATED_ERROR_SECONDS;

	public float MIN_ACCUMULATED_ERROR;

	public float MAX_POS_ERROR_TO_HARDSNAP;

	public float EXTRAPOLATION_POS_RATIO;

	public float EXTRAPOLATION_ROT_RATIO;

	public float PREDICT_BLEND_RATIO;

	public float FINAL_BLEND_RATIO;

	public string EntityID
	{
		get
		{
			return _003CEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CEntityID_003Ek__BackingField = value;
		}
	}

	public UGCTransformNode Parent
	{
		get
		{
			return _003CParent_003Ek__BackingField;
		}
		private set
		{
			_003CParent_003Ek__BackingField = value;
		}
	}

	public List<UGCTransformNode> Children
	{
		get
		{
			return _003CChildren_003Ek__BackingField;
		}
		private set
		{
			_003CChildren_003Ek__BackingField = value;
		}
	}

	private Vector3 WorldPos
	{
		get
		{
			return _003CWorldPos_003Ek__BackingField;
		}
		set
		{
			_003CWorldPos_003Ek__BackingField = value;
		}
	}

	private Vector3 LocalPos
	{
		get
		{
			return _003CLocalPos_003Ek__BackingField;
		}
		set
		{
			_003CLocalPos_003Ek__BackingField = value;
		}
	}

	private Quaternion WorldRot
	{
		get
		{
			return _003CWorldRot_003Ek__BackingField;
		}
		set
		{
			_003CWorldRot_003Ek__BackingField = value;
		}
	}

	private Quaternion LocalRot
	{
		get
		{
			return _003CLocalRot_003Ek__BackingField;
		}
		set
		{
			_003CLocalRot_003Ek__BackingField = value;
		}
	}

	private Vector3 LocalScale
	{
		get
		{
			return _003CLocalScale_003Ek__BackingField;
		}
		set
		{
			_003CLocalScale_003Ek__BackingField = value;
		}
	}

	private Vector3 WorldScale
	{
		get
		{
			return _003CWorldScale_003Ek__BackingField;
		}
		set
		{
			_003CWorldScale_003Ek__BackingField = value;
		}
	}

	public uint LastPacketID
	{
		get
		{
			return _003CLastPacketID_003Ek__BackingField;
		}
		set
		{
			_003CLastPacketID_003Ek__BackingField = value;
		}
	}

	public bool AtRest
	{
		get
		{
			return _003CAtRest_003Ek__BackingField;
		}
		private set
		{
			_003CAtRest_003Ek__BackingField = value;
		}
	}

	public bool NeedSmooth
	{
		get
		{
			return _003CNeedSmooth_003Ek__BackingField;
		}
		private set
		{
			_003CNeedSmooth_003Ek__BackingField = value;
		}
	}

	public bool IncludePos
	{
		get
		{
			return _003CIncludePos_003Ek__BackingField;
		}
		private set
		{
			_003CIncludePos_003Ek__BackingField = value;
		}
	}

	public bool IncludeRot
	{
		get
		{
			return _003CIncludeRot_003Ek__BackingField;
		}
		private set
		{
			_003CIncludeRot_003Ek__BackingField = value;
		}
	}

	public bool IncludeScale
	{
		get
		{
			return _003CIncludeScale_003Ek__BackingField;
		}
		private set
		{
			_003CIncludeScale_003Ek__BackingField = value;
		}
	}

	public bool IsInterpolatingPos
	{
		get
		{
			return _003CIsInterpolatingPos_003Ek__BackingField;
		}
		private set
		{
			_003CIsInterpolatingPos_003Ek__BackingField = value;
		}
	}

	public bool IsInterpolatingRot
	{
		get
		{
			return _003CIsInterpolatingRot_003Ek__BackingField;
		}
		private set
		{
			_003CIsInterpolatingRot_003Ek__BackingField = value;
		}
	}

	public bool IsInterpolatingScale
	{
		get
		{
			return _003CIsInterpolatingScale_003Ek__BackingField;
		}
		private set
		{
			_003CIsInterpolatingScale_003Ek__BackingField = value;
		}
	}

	public Vector3 LinearVelocity
	{
		get
		{
			return _003CLinearVelocity_003Ek__BackingField;
		}
		private set
		{
			_003CLinearVelocity_003Ek__BackingField = value;
		}
	}

	public Vector3 AngularVelocity
	{
		get
		{
			return _003CAngularVelocity_003Ek__BackingField;
		}
		private set
		{
			_003CAngularVelocity_003Ek__BackingField = value;
		}
	}

	public Vector3 LogicPos
	{
		get
		{
			return default(Vector3);
		}
		private set
		{
		}
	}

	public Quaternion LogicRot
	{
		get
		{
			return default(Quaternion);
		}
		private set
		{
		}
	}

	public Vector3 LogicScale
	{
		get
		{
			return default(Vector3);
		}
		private set
		{
		}
	}

	public Vector3 VisualPos
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion VisualRot
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public Vector3 VisualScale
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public UGCTransformNode Create(string entityID, UGCTransformModule manager)
	{
		return null;
	}

	public void ReplaceUnityTransform(Transform tran)
	{
	}

	private void OnGameObjectLoaded(GameObject obj)
	{
	}

	private void OnParentGameObjectLoaded(GameObject obj)
	{
	}

	private void RefreshTRS()
	{
	}

	private void AddDirty(DirtyProperty p)
	{
	}

	public Vector3 GetLocalPosition()
	{
		return default(Vector3);
	}

	public Quaternion GetLocalRotation()
	{
		return default(Quaternion);
	}

	public Vector3 GetLocalScale()
	{
		return default(Vector3);
	}

	public void SetLocalPosition(Vector3 pos)
	{
	}

	public void SetLocalRotation(Quaternion rot)
	{
	}

	public void SetLocalScale(Vector3 scale)
	{
	}

	private Vector3 ValidateForScale(Vector3 scale)
	{
		return default(Vector3);
	}

	public void SetWorldPosition(Vector3 pos)
	{
	}

	public void SetWorldRotation(Quaternion rot)
	{
	}

	private bool IsUnityTransformReady()
	{
		return false;
	}

	public void SetWorldScale(Vector3 scale)
	{
	}

	public Vector3 GetWorldPosition()
	{
		return default(Vector3);
	}

	public Quaternion GetWorldRotation()
	{
		return default(Quaternion);
	}

	public Vector3 GetWorldScale()
	{
		return default(Vector3);
	}

	public void SetParent(UGCTransformNode parentNode, bool keepWorldPos, bool refresh)
	{
	}

	public bool SetParent(EntityIndex parentIndex, bool keepWorldPos)
	{
		return false;
	}

	public UGCTransformNode GetParent()
	{
		return null;
	}

	public string GetParentID()
	{
		return null;
	}

	public UGCTransformNode GetChildAt(int index)
	{
		return null;
	}

	private void AddChild(UGCTransformNode node)
	{
	}

	internal void RemoveChild(UGCTransformNode node)
	{
	}

	private void InitSyncParam()
	{
	}

	internal void UnPackSyncData(UGCTransformModule.DeserializedTRSState state)
	{
	}

	internal void UnPackSyncData(uint packetID, DCJBKFHHIBC state)
	{
	}

	internal void OnTick(float gameTime, float deltaTime, float lastPingOneWay)
	{
	}
}
