using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIBooyahPassMatchResultItemController : UIBaseController, UITable2.IUITable2Item
{
	private bool m_HasShowAnimation;

	private UIBooyahPassMatchResultItemView m_View;

	private UIModelBooyahPass m_ModelBooyahPass;

	private bool m_HasLevelUp;

	private IEnumerator m_StartShowEffect;

	private List<UIBooyahPassMatchResultMiniItemController> m_MiniItemCtrlList;

	private float m_NowExp;

	private float m_TargetExp;

	private bool m_IsUpdateProgress;

	private uint m_TargetGrade;

	private uint m_TargetRewardGrade;

	private uint m_DelayCallId;

	private const string ProgressKey = "{0} / {1}";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData()
	{
	}

	private void LateUpdate()
	{
	}

	private void ShowUpdateProgress()
	{
	}

	private void RefreshViewAfterProgressStopRise()
	{
	}

	public void RefreshView()
	{
	}

	private void RefreshRewardItemView(uint curGrade)
	{
	}

	private void RedreshCountDownView()
	{
	}

	private void RefreshGainView(uint curExp)
	{
	}

	private void RefreshGradeView(uint curGrade)
	{
	}

	private void RefreshScrollBarView(uint curExp)
	{
	}

	private void RefreshIconView()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
