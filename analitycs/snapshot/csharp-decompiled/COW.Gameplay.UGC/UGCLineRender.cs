using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCLineRender : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<object, Vector3> _003C_003E9__8_0;

		internal Vector3 _003COnPointsChangeEvent_003Eb__8_0(object p)
		{
			return default(Vector3);
		}
	}

	private string m_EntityID;

	private List<Vector3> m_Points;

	private string m_CustomMaterial;

	private float m_Width;

	private UGCLineRenderEntityRepItem m_RepItem;

	private LineRenderer m_LineRenderer;

	public static UGCLineRender Create(string entityID)
	{
		return null;
	}

	public void OnDestroy()
	{
	}

	private void OnPointsChangeEvent(List<object> points)
	{
	}

	private void OnCustomMaterialChangeEvent(string customMaterial)
	{
	}

	private void OnWidthChangeEvent(float width)
	{
	}

	private void UpdateLineRender()
	{
	}

	private void _003CUpdateLineRender_003Eb__11_0(bool succ, UGCMaterial resObj)
	{
	}
}
