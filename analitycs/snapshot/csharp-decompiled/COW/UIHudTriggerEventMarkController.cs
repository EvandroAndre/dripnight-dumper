using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTriggerEventMarkController : UIHudNameBaseController
{
	public enum EProgressColor
	{
		Red,
		White
	}

	private const int DEFAULT_ZOOM_SCALE = 34;

	private readonly Color COLOR_BG_RED;

	private readonly Color COLOR_BG_YELLOW;

	private readonly Color COLOR_BG_INDIA_RED;

	private readonly Color COLOR_BG_GRAY;

	private readonly Color COLOR_LABEL_RED;

	private readonly Color COLOR_LABEL_WHITE;

	private readonly Color COLOR_PROGRESS_WHITE_FORE;

	private readonly Color COLOR_PROGRESS_WHITE_BACK;

	private readonly Color COLOR_PROGRESS_RED_FORE;

	private readonly Color COLOR_PROGRESS_RED_BACK;

	private UIEventTriggerView m_View;

	private Vector3 m_bindWorldPosition;

	private BHGGAEEHJCO m_BindPlayerID;

	private bool m_NeedShowDistance;

	private bool m_NeedShowTime;

	private uint m_CurrentDelegate;

	private InGameTriggerMaskData m_showData;

	private uint m_VFXDelayCall;

	private bool m_NeedRecycle;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindWorldPosition(Vector3 targetPosition)
	{
	}

	public void HideUIShowData()
	{
	}

	public void FlashUIShowData(bool isHelpResource = true)
	{
	}

	public void SetUIShowData(BHGGAEEHJCO pID, InGameTriggerMaskData data, bool needRecycle)
	{
	}

	private Color GetColorByMarkType(COMCCDPHDGI markType)
	{
		return default(Color);
	}

	private void ResetUI()
	{
	}

	public void SetShowDistance(bool enable)
	{
	}

	public void SetShowTime(bool enable)
	{
	}

	public void UpdateTimeLabel(string val)
	{
	}

	public FCPLBIOLDOF GetMarkType()
	{
		return FCPLBIOLDOF.NONE;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	private void SetDistance(int distance)
	{
	}

	private void RefreshDistanceToLocalPlayer()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void LateUpdate()
	{
	}

	private void RefreshProgress()
	{
	}

	private void RefreshProgress_KnockDown()
	{
	}

	private void RefreshProgress_BeingRescured()
	{
	}

	private void SetProgressColorType(uint progressColor)
	{
	}

	private void _003CFlashUIShowData_003Eb__25_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_LateUpdate()
	{
	}
}
