using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

public class UIUGCHudWidgetAttributeOverflowController : UIUGCHudWidgetAttributeController<UIUGCHudWidgetAttributeOverflowController.OverflowData>
{
	private enum OverflowEnum
	{
		Shrink,
		Clamp,
		Ellipsis,
		Freely
	}

	public class OverflowData : IEquatable<OverflowData>
	{
		public int attributeValue;

		public static OverflowData Create(int overflow, bool ellipsis)
		{
			return null;
		}

		public bool Equals(OverflowData other)
		{
			return false;
		}

		public static int GetAttributeValue(int overflow, bool ellipsis)
		{
			return 0;
		}
	}

	private UIUGCHudWidgetAttributeOverflowView m_View;

	private List<string> m_DropdownOptions;

	public override OverflowData AttributeData
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

	protected override void OnUIInit()
	{
	}

	public override void InitAttribute(OverflowData data)
	{
	}

	private void OnDropdownValueChanged(int value)
	{
	}

	public void SetLabelOverflow(int attribute, UGCHudLabel label)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
