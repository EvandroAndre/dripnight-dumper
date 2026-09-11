using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class UGCHudSocialButtonWidget : UGCHudWidget
{
	public enum EFuncBtnType
	{
		AddFriend,
		Report
	}

	public enum EShowType
	{
		Bright,
		Dark
	}

	private class ShowTypeData
	{
		public string NormalSpriteName;

		public string DisabledSpriteName;
	}

	private Dictionary<int, Dictionary<int, ShowTypeData>> m_showTypeMap;

	private UIButton m_Btn;

	private UISprite m_Icon;

	private EFuncBtnType m_FuncBtnType;

	private EShowType m_ShowType;

	private bool m_AlreadyUsed;

	public UIButton Btn => null;

	public UISprite Icon => null;

	public bool AlreadyUsed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void InitShowTypeMap()
	{
	}

	public override void OnInternalInit()
	{
	}

	public override UGCHudWidgetType GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public EFuncBtnType GetFuncBtnType()
	{
		return EFuncBtnType.AddFriend;
	}

	public void SetFuncBtnType(EFuncBtnType type)
	{
	}

	public void SetFuncBtnShowType(EShowType type)
	{
	}

	private void RefreshShowType()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnInternalInit()
	{
	}

	public UGCHudWidgetType _003C_003EiFixBaseProxy_GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}
}
