using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudWidgetInspectorController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public UGCHudWidget widget;

		public UIUGCHudWidgetInspectorController _003C_003E4__this;

		internal void _003CBindAttribute_003Eb__0(UIUGCHudWidgetAttributeTransformController.TransformData value)
		{
		}

		internal void _003CBindAttribute_003Eb__1(bool value)
		{
		}

		internal void _003CBindAttribute_003Eb__2(Vector2Int value)
		{
		}

		internal void _003CBindAttribute_003Eb__4(Color color)
		{
		}

		internal void _003CBindAttribute_003Eb__5(int a)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_1
	{
		public UGCHudImage image;

		public _003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals1;

		internal void _003CBindAttribute_003Eb__3(string value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_10
	{
		public UGCHudButton btn;

		internal void _003CBindAttribute_003Eb__14(Color value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_11
	{
		public UGCHudButton btn;

		internal void _003CBindAttribute_003Eb__15(Color value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_12
	{
		public UGCHudButton btn;

		internal void _003CBindAttribute_003Eb__16(int a)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_13
	{
		public UGCHudWidget empty;

		internal void _003CBindAttribute_003Eb__17(int a)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_14
	{
		public UIUGCHudWidgetAttributeOverflowController ctrl;

		public UGCHudLabel label;

		internal void _003CBindAttribute_003Eb__18(UIUGCHudWidgetAttributeOverflowController.OverflowData value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_2
	{
		public UGCHudImage image;

		internal void _003CBindAttribute_003Eb__6(UIBasicSprite.Flip flip)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_3
	{
		public UGCHudLabel label;

		internal void _003CBindAttribute_003Eb__7(NGUIText.Alignment value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_4
	{
		public UGCHudLabel label;

		internal void _003CBindAttribute_003Eb__8(int value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_5
	{
		public UGCHudLabel label;

		internal void _003CBindAttribute_003Eb__9(Color value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_6
	{
		public UGCHudLabel label;

		internal void _003CBindAttribute_003Eb__10(int a)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_7
	{
		public UGCHudLabel label;

		internal void _003CBindAttribute_003Eb__11(int value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_8
	{
		public UGCHudLabel label;

		internal void _003CBindAttribute_003Eb__12(string value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_9
	{
		public UGCHudButton btn;

		public _003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals2;

		internal void _003CBindAttribute_003Eb__13(string value)
		{
		}
	}

	private UIUGCHudWidgetInspectorView m_View;

	private UGCHudWidget m_CurrentWidget;

	private UIModelUGCHudEdit m_Model;

	private bool m_IsExpand;

	private UGCHudWidgetType m_LastWidgetType;

	private UIUGCHudWidgetAttributeTransformController m_TransformAttributeItem;

	private Dictionary<int, List<UIUGCHudWidgetAttributeBaseController>> m_AttributeItemsByType;

	private Dictionary<int, UIUGCHudWidgetAttributeBaseController> m_AttributeItems;

	private int m_AlphaMin;

	private int m_AlphaMax;

	private int m_AlphaStep;

	private int m_FontSizeMin;

	private int m_FontSizeMax;

	private int m_FontSizeStep;

	private int m_ContentCharLimit;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindWidget(UGCHudWidget widget)
	{
	}

	public override void Hide()
	{
	}

	public void HideUIDropdown()
	{
	}

	public void SetExpand(bool expand)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void StopTutorial()
	{
	}

	private void ShowPropertyGuide()
	{
	}

	private void OnComponentPropGuide(object[] data)
	{
	}

	private void RepositionTable()
	{
	}

	private void RepositionScrollView()
	{
	}

	private void HideAllAttributeItems()
	{
	}

	private void SetAttributeType(UGCHudWidgetAttributeType attributeType)
	{
	}

	private void InitAttributes(UGCHudWidget widget)
	{
	}

	private void OnSwitchBtnClick()
	{
	}

	private void OnEditBtnClick()
	{
	}

	private void OnWidgetSizeChanged()
	{
	}

	private void OnWidgetPositionChanged()
	{
	}

	private void OnWidgetRotationChanged()
	{
	}

	private void ShowName()
	{
	}

	private string GetString(UGCHudWidgetAttributeType attributeType, UGCHudWidgetAttributeEnum attributeEnum = UGCHudWidgetAttributeEnum.None)
	{
		return null;
	}

	private UIUGCHudWidgetAttributeBaseController GetOrCreateAttributeItem(UGCHudWidgetAttributeType attributeType, UGCHudWidgetAttributeEnum attributeEnum)
	{
		return null;
	}

	private UIUGCHudWidgetAttributeBaseController GetAttributeItem(UGCHudWidgetAttributeEnum attributeEnum)
	{
		return null;
	}

	private T GetAttributeItem<T>(UGCHudWidgetAttributeEnum attributeEnum) where T : UIUGCHudWidgetAttributeBaseController
	{
		return null;
	}

	private void BindAttribute(UGCHudWidgetAttributeEnum attributeEnum, UIUGCHudWidgetAttributeBaseController attributeItem, UGCHudWidget widget)
	{
	}

	private void _003COnEditBtnClick_003Eb__31_0(string value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
