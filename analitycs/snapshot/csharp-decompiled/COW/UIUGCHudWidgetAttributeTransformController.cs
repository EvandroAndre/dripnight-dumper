using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudWidgetAttributeTransformController : UIUGCHudWidgetAttributeController<UIUGCHudWidgetAttributeTransformController.TransformData>
{
	public struct TransformData : IEquatable<TransformData>
	{
		public int X;

		public int Y;

		public int Width;

		public int Height;

		public int Angle;

		public void SetX(int x)
		{
		}

		public void SetY(int y)
		{
		}

		public void SetWidth(int width)
		{
		}

		public void SetHeight(int height)
		{
		}

		public void SetAngle(int angle)
		{
		}

		public static TransformData Create(Vector2 localPosition, int width, int height, float angle)
		{
			return default(TransformData);
		}

		public bool Equals(TransformData other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return false;
		}

		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return 0;
		}
	}

	private UIUGCHudWidgetAttributeTransformView m_View;

	private UIUGCHudWidgetAttributeTransformItemController m_ItemX;

	private UIUGCHudWidgetAttributeTransformItemController m_ItemY;

	private UIUGCHudWidgetAttributeTransformItemController m_ItemWidth;

	private UIUGCHudWidgetAttributeTransformItemController m_ItemHeight;

	private UIUGCHudWidgetAttributeTransformItemController m_ItemAngle;

	private bool m_IsExtend;

	public override TransformData AttributeData
	{
		get
		{
			return default(TransformData);
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

	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return UIUGCHudWidgetAttributeEnum.Color;
	}

	public override void InitAttribute(TransformData data)
	{
	}

	public void InitAttributePosition(int x, int y)
	{
	}

	public void InitAttributeSize(int width, int height)
	{
	}

	public void InitAttributeAngle(int angle)
	{
	}

	private void InitTransformItems()
	{
	}

	private void OnXChanged()
	{
	}

	private void OnYChanged()
	{
	}

	private void OnWidthChanged()
	{
	}

	private void OnHeightChanged()
	{
	}

	private void OnAngleChanged()
	{
	}

	private void OnClickBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
