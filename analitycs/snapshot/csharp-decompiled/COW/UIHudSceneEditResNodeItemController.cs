using System;
using System.Text.RegularExpressions;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudSceneEditResNodeItemController : UIEasyListItemController
{
	public enum EViewState
	{
		Normal,
		MultiSelect
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static MatchEvaluator _003C_003E9__25_0;

		internal string _003CSetViewData_003Eb__25_0(Match m)
		{
			return null;
		}
	}

	private UIHudSceneEditResItemView m_View;

	private Action<UIHudSceneEditResNodeItemController> m_ItemSelectedCallback;

	private Action<UIHudSceneEditResNodeItemController> m_ExpandCallback;

	private Action m_VisibleChangedCallback;

	private const float m_OffsetX = 30f;

	public const float ITEM_HEIGHT = 50f;

	public const float HALF_ITEM_HEIGHT = 25f;

	private UIHudSceneEditResRowData m_RowData;

	private SceneEditObjectBase m_SceneEditObj;

	private int m_Hierarchy;

	private float m_InitPosX;

	private float m_FrameInitPosX;

	private float m_HighlightInitPosX;

	private int m_FrameInitWidth;

	private int m_HighlightInitWidth;

	private SceneEditAgent m_Agent;

	public SceneEditObjectBase SceneEditObj => null;

	public SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void SetCallback(Action<UIHudSceneEditResNodeItemController> selectedCallback, Action<UIHudSceneEditResNodeItemController> expandCallback, Action visibleChangedCallback)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetItemName(string customizedName)
	{
	}

	private void SetRetract()
	{
	}

	private void OnBackgroundClick()
	{
	}

	private void OnArrowClick()
	{
	}

	private void OnVisibleBtnClick()
	{
	}

	private void SetSceneObjectVisible(SceneEditObjectBase obj, bool visible)
	{
	}

	private void SetMultiSelectToggle(bool selected)
	{
	}

	private void RefreshVisibleToggle()
	{
	}

	private void RefreshHighLight(bool selected, bool parentSelected)
	{
	}

	private void RefreshArrowColor(bool selected, bool parentSelected)
	{
	}

	private void RefreshVisibleToggleColor(bool selected, bool parentSelected)
	{
	}

	private void RefreshLabelColor(bool selected, bool parentSelected)
	{
	}

	private void SetViewState(EViewState state)
	{
	}

	public void RefreshItem()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
