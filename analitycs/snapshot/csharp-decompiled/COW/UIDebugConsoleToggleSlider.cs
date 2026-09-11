using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugConsoleToggleSlider : UIBaseController, UITable2.IUITable2Item
{
	public class Data
	{
		public delegate float NewCmd();

		public string name;

		public string cmd;

		public bool defaultToggleValue;

		public float defaultSliderValue;

		public string defaultDisplayValue;

		public NewCmd OnNewCmdHandler;
	}

	public delegate void OnRunCmd(string cmd, bool toggleValue, float sliderValue, Component component);

	private UIDebugConsoleToggleSliderView m_View;

	private Data m_Data;

	public OnRunCmd OnRunCmdHandler;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
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

	private void RunCmd()
	{
	}

	private void RunNewCmd()
	{
	}

	public void OnToggleValueChange()
	{
	}

	public void OnSliderChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
