using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudTaskNameIconController : UIHudNameBaseController
{
	private UIHudTaskNameIconView m_View;

	private LevelTaskZone bindedLevelObject;

	private bool m_onlyEmergency;

	private bool m_isEmergency;

	private TutorialEventEnum m_CurTutType;

	public LevelTaskZone BindedLevelObject => null;

	public bool IsEmergency => false;

	private bool IsInTutorial => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void BindLevelObject(LevelTaskZone obj)
	{
	}

	public void ClearBind()
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	public void SetEmergency(bool isEmergency)
	{
	}

	private void RefreshIconVisibility()
	{
	}

	private void OnRefreshIcon(object[] data)
	{
	}

	protected override void UpdateNamePosition()
	{
	}

	public void ShowTutorial(bool isWolf)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_UpdateNamePosition()
	{
	}
}
