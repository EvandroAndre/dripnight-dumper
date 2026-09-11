using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using RuntimeGizmos;
using UnityEngine;

namespace COW;

internal class UIHudSceneEditTransformVector3Controller : UIBaseController
{
	private UIHudSceneEditItemTransformVector3View m_View;

	private EAdjustType m_AdjustType;

	private SceneEditObjectBase m_ModifyObj;

	private List<UISprite> m_PreciseContainer;

	private List<BoxCollider> m_PreciseCollider;

	private Vector3 m_PreciseData;

	private SceneEditAgent m_Agent;

	private WorkshopSceneData m_WorkshopSceneData;

	private SceneEditAgent Agent => null;

	private WorkshopSceneData WorkshopSceneData => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(EAdjustType adjustType, SceneEditObjectBase modifyObj)
	{
	}

	private void OnSubmitInput(Axis axis)
	{
	}

	private void SetModifyObjData(float target, Axis axis)
	{
	}

	private void UpdatePreciseCoordinate()
	{
	}

	private void UpdatePreciseCoordinate(Vector3 data)
	{
	}

	private void OnMoveDelegate()
	{
	}

	private void OnRotateDelegate()
	{
	}

	private void OnScaleDelegate()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void _003COnUIInit_003Eb__13_0()
	{
	}

	private void _003COnUIInit_003Eb__13_1()
	{
	}

	private void _003COnUIInit_003Eb__13_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
