using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHud3DContainer : UGCHudWidget
{
	protected string m_ResourceID;

	public Transform m_ScaleNode;

	public Transform m_RotationNode;

	public Transform m_LayerNode;

	private GameObject m_Instance;

	private Vector3 m_Scale;

	private Vector3 m_Rotation;

	private Vector2Int m_BaseDepth;

	public bool m_NeedRefreshLayer;

	public string ResourceID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GameObject Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3 Scale
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 Rotation3D
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public override void SetParentHasChanged()
	{
	}

	public override UGCHudWidgetType GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public void DestroyInstance()
	{
	}

	public void SetInstanceLayer()
	{
	}

	private void Update()
	{
	}

	public override void SetLayer(int layer)
	{
	}

	public override Vector2Int SetDepth(Vector2Int depth, int stepDepth)
	{
		return default(Vector2Int);
	}

	public new void _003C_003EiFixBaseProxy_SetParentHasChanged()
	{
	}

	public UGCHudWidgetType _003C_003EiFixBaseProxy_GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public void _003C_003EiFixBaseProxy_SetLayer(int P0)
	{
	}

	public Vector2Int _003C_003EiFixBaseProxy_SetDepth(Vector2Int P0, int P1)
	{
		return default(Vector2Int);
	}
}
