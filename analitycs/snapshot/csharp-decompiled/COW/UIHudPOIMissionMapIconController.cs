using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPOIMissionMapIconController : UIBaseController
{
	private uint m_POIMissionId;

	private UIHudPOIMissionMapIconView m_View;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private UITimeLabelHelper m_StartTimer;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(uint poimissionId, UIMapUtil.MapOffsetContext mapOffsetContex)
	{
	}

	private void Update()
	{
	}

	private void OnTimerFinish()
	{
	}

	public void SetIconRotation(Quaternion rotation)
	{
	}

	public void SetIconScale(Vector3 scale)
	{
	}

	public Transform GetIconTransform()
	{
		return null;
	}

	protected void OnPOIMissionOwnerChanged()
	{
	}

	protected void OnPOIMissionStart()
	{
	}

	protected void OnPOIMissionStateChanged(uint poimissionId)
	{
	}

	protected void OnPOIMissionModelShowChanged(uint poimissionId)
	{
	}

	protected void RefreshState(LevelObjectPOIMission poimission)
	{
	}

	private void RefreshCirclePosition(LevelObjectPOIMission poimission)
	{
	}

	protected void RefreshIconState(LevelObjectPOIMission poimission)
	{
	}

	private void RefreshOccupyProgress()
	{
	}

	private void RefreshOccupyProgressBar(LevelObjectPOIMission poimission)
	{
	}

	private LevelOccupyPoint GetBindOccupyPoint(uint poimissionId)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
