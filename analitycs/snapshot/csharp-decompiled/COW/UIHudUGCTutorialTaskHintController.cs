using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCTutorialTaskHintController : UIBaseController
{
	private UIHudUGCTutorialTaskHintView m_View;

	private string m_CurrentHint;

	private UIGroupWaitingDropItem m_DragDropItem;

	private const float COLLIDER_SIZE_EPSILON = 0.5f;

	private const float UI_EFFECT_INSET_X = 10f;

	private const float UI_EFFECT_INSET_Y = 6f;

	private static readonly Vector2 DEFAULT_HINT_POSITION;

	public const int TASK_HINT_PANEL_DEPTH = 995;

	public UIHudUGCTutorialTaskHintView View => null;

	public string CurrentHint => null;

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

	private void Update()
	{
	}

	public void SetHint(string hint)
	{
	}

	private void OnTaskHintChanged(object[] data)
	{
	}

	private void ApplyHint(string hint, bool isTaskComplete)
	{
	}

	private void SetTaskCompleteVisualVisible(bool visible)
	{
	}

	private void SetUIEffectVisible(bool visible)
	{
	}

	private void SetBGMaskVisible(bool visible)
	{
	}

	private void ApplyPanelDepth(int depth)
	{
	}

	private void SetHintPanelVisible(bool visible)
	{
	}

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	private void ApplyDefaultPosition()
	{
	}

	private void InitDrag()
	{
	}

	private Vector2 GetBound()
	{
		return default(Vector2);
	}

	private void RefreshUIEffectScale()
	{
	}

	private void RefreshDragColliderAndBound()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}
}
