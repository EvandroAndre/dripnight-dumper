using COW.GamePlay;
using UnityEngine;

namespace COW;

public class LastVehicleObject : MonoBehaviour
{
	private const float DELAY_SECOUNDS = 2f;

	private Vehicle m_BindVehicle;

	private uint m_HideDelayCallID;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	public void InitByMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void BindVehicleAndShow(uint vehicleObjID)
	{
	}

	public void HideObject(bool needDelay = false)
	{
	}

	private void OnHide()
	{
	}

	public void Update()
	{
	}

	private void UpdatePositionAndRotation()
	{
	}
}
