using GCommon;
using UnityEngine;

namespace COW;

public class UIBigMapObEventController : UIBaseController
{
	private UIBigMapObEventView m_View;

	private Vector3 m_Scale;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private Vector3 targetPosOffset;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnDragStart()
	{
	}

	public void OnDragRelase()
	{
	}

	public bool IsEventIcon(GameObject go)
	{
		return false;
	}

	public void UpdateScale(Vector3 mapIconScale)
	{
	}

	public float GetMoveScale()
	{
		return 0f;
	}

	public void SetMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	private void OnConfirm()
	{
	}

	public void InitMoveScale(Vector3 scale)
	{
	}

	private void OnCancel()
	{
	}

	private void OnEventSelect(object[] data)
	{
	}

	private void ShowEventIcon(bool show)
	{
	}

	private void OnBigMapDisabled(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
