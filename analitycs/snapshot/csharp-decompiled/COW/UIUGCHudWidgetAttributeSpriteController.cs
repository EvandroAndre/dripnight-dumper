using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudWidgetAttributeSpriteController : UIUGCHudWidgetAttributeController<string>, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public string strValue;

		internal bool _003COnBtnClick_003Eb__1(string x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public string data;

		internal bool _003CInitAttribute_003Eb__0(string x)
		{
			return false;
		}
	}

	private UIUGCHudWidgetAttributeSpriteView m_View;

	private List<string> m_SpriteNames;

	private int m_SelectIndex;

	public override string AttributeData
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

	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return UIUGCHudWidgetAttributeEnum.Color;
	}

	public override void InitAttribute(string data)
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void Hide()
	{
	}

	private void OnComponentChangeImageGuide(object[] data)
	{
	}

	public void SetViewData(string title)
	{
	}

	private void SelectItem(int index)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnBtnClick()
	{
	}

	private void _003COnBtnClick_003Eb__16_0(string strValue, int intValue)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
