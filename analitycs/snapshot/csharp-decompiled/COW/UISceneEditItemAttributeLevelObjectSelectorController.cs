using System;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UISceneEditItemAttributeLevelObjectSelectorController : UIBaseController
{
	private UISceneEditItemAttributeLevelObjectSelectorView m_View;

	protected Action<string> m_ValueChangeCallback;

	protected string m_CurValue;

	protected string m_TipKey;

	protected virtual string CurValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	public void InitShowData(ItemEditAttributeUIDataLevelObjectSelector data)
	{
	}

	protected void OnClickHintButton()
	{
	}

	public void RegisetrValueChangeCallback(Action<string> callBack)
	{
	}

	private void OnPickBtnClick()
	{
	}

	private void OnCancel()
	{
	}

	private void OnGetEntityChange(SceneEditObjectBase obj)
	{
	}

	private void DeregisterFromGetter()
	{
	}

	private void OnSelectedLevelObjectChanged()
	{
	}

	private void UpdateLevelObjectSelection(bool isExisted, string nameKey)
	{
	}

	private void OnClearBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
