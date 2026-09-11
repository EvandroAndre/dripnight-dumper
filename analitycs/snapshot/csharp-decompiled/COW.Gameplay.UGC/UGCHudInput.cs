using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHudInput : UGCHudWidget
{
	public enum InputTransitionType
	{
		Color,
		Sprite
	}

	public enum InputWordWrap
	{
		Single,
		Multiple
	}

	private sealed class _003CRefreshColor_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UGCHudInput _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshColor_003Ed__79(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIInput m_Input;

	protected UILabel m_Label;

	private bool m_IsItalic;

	private bool m_IsBold;

	private UIWidget.Pivot m_LastPivot;

	private HorizontalAlignmentEnum m_LabelAlignmentHorizontal;

	private VerticalAlignmentEnum m_LabelAlignmentVertical;

	public UISprite m_Bg;

	private int m_InitBgHeight;

	private int m_InitInputHeight;

	private InputWordWrap m_WordWrap;

	private InputTransitionType m_TransitionType;

	private Color m_DefaultColor;

	private Color m_PressedColor;

	private Color m_DisabledColor;

	public string LocKey;

	private Color m_LabelColor;

	public int InitBgHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int InitInputHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public UIInput Input => null;

	public UILabel Label => null;

	public UISprite Bg => null;

	public Color LabelColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public bool IsItalic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsBold
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsUnderline
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public InputWordWrap WordWrap
	{
		get
		{
			return InputWordWrap.Single;
		}
		set
		{
		}
	}

	public InputTransitionType TransitionType
	{
		get
		{
			return InputTransitionType.Color;
		}
		set
		{
		}
	}

	public Color DefaultColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Color PressedColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Color DisabledColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public HorizontalAlignmentEnum LabelAlignmentHorizontal
	{
		get
		{
			return HorizontalAlignmentEnum.Left;
		}
		set
		{
		}
	}

	public VerticalAlignmentEnum LabelAlignmentVertical
	{
		get
		{
			return VerticalAlignmentEnum.Top;
		}
		set
		{
		}
	}

	public override UGCHudWidgetType GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	protected override void OnInternalEnable()
	{
	}

	protected override void OnInternalDisable()
	{
	}

	private void OnColorTypeInputFocus()
	{
	}

	private void OnColorTypeInputLostFocus()
	{
	}

	private void UpdateLabelAnchor()
	{
	}

	private void BeforeInputRotationChanged()
	{
	}

	private void OnInputRotationChanged()
	{
	}

	private void SetBoldAndItalic()
	{
	}

	public override void RemoveDragScrollView()
	{
	}

	public override void AddDragScrollView(UIScrollView scrollView)
	{
	}

	public override void SetParentHasChanged()
	{
	}

	public override void SetLayer(int layer)
	{
	}

	public override Vector2Int SetDepth(Vector2Int depth, int stepDepth)
	{
		return default(Vector2Int);
	}

	public void Refresh()
	{
	}

	private IEnumerator RefreshColor()
	{
		return null;
	}

	public override void RefreshSprite()
	{
	}

	public UGCHudWidgetType _003C_003EiFixBaseProxy_GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public void _003C_003EiFixBaseProxy_OnInternalEnable()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInternalDisable()
	{
	}

	public void _003C_003EiFixBaseProxy_RemoveDragScrollView()
	{
	}

	public void _003C_003EiFixBaseProxy_AddDragScrollView(UIScrollView P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_SetParentHasChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_SetLayer(int P0)
	{
	}

	public Vector2Int _003C_003EiFixBaseProxy_SetDepth(Vector2Int P0, int P1)
	{
		return default(Vector2Int);
	}

	public void _003C_003EiFixBaseProxy_RefreshSprite()
	{
	}
}
