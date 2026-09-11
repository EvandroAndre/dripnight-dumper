using System;
using GCommon;

namespace COW;

public class UIModeEditGeneralComponentHelper
{
	public UIModelUGCModeEdit Model;

	public GeneralComponentData GeneralData;

	public UIBaseController Context;

	private UISprite BG;

	private Action EnabledChanged;

	private UIModeEditGeneralComponentHelper m_ParentGeneralHelper;

	public UIModeEditGeneralComponentHelper(UIBaseController context, GeneralComponentData generalData, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	public UIModeEditGeneralComponentHelper(UIBaseController context, GeneralComponentData generalData, UILabel title, UISprite bg, UIButton tip, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	public void Destroy()
	{
	}

	public void HideBG()
	{
	}

	public void ShowTip()
	{
	}

	private void OnEnabledChanged()
	{
	}

	public void AddOnEnableChanged(Action callback)
	{
	}

	public bool IsInHierarchyEnable()
	{
		return false;
	}
}
