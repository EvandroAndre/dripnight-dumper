using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudSceneEditPlotEditorDropdownController : UIBaseController
{
	private class OptionItem
	{
		public string Content;

		public EventDelegate.Callback Callback;

		public UIHudSceneEditPlotEditorDropdownItemController.EOptionType OptionType;
	}

	private enum EState
	{
		Unexpand,
		Expand
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public OptionItem option;

		public UIHudSceneEditPlotEditorDropdownController _003C_003E4__this;

		internal void _003CChangeState_003Eb__0()
		{
		}
	}

	private UIHudSceneEditPlotEditorDropdownView m_View;

	private List<OptionItem> m_Options;

	private List<UIHudSceneEditPlotEditorDropdownItemController> m_Controllers;

	private EventDelegate.Callback m_OnRefreshOptions;

	private bool m_NeedModifyWidth;

	private float m_ModifyWidth;

	private EState m_State;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ClearOptions()
	{
	}

	public void AddOption(string content, EventDelegate.Callback callback, UIHudSceneEditPlotEditorDropdownItemController.EOptionType optionType = UIHudSceneEditPlotEditorDropdownItemController.EOptionType.Normal)
	{
	}

	public void SelectOption(string option)
	{
	}

	public void ShowLabel(string text)
	{
	}

	public void SetOnRefreshOptions(EventDelegate.Callback callback)
	{
	}

	public void ModifyWidth(float width)
	{
	}

	public void Unexpand()
	{
	}

	private void OnBtnClick()
	{
	}

	private void ChangeState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
