using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBlockEditColorSetterWndController : UIPopupWindowController
{
	private enum EWheelsType
	{
		Classic,
		Beach
	}

	private sealed class _003CSetPosition_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBlockEditColorSetterWndController _003C_003E4__this;

		public Vector3 Pos;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPosition_003Ed__41(int _003C_003E1__state)
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

	private UIHudBlockEditColorSetterWndView m_View;

	public ColorChangedEvent onValueChanged;

	public Action onClosed;

	public Action OnColorSetOnce;

	private Color mCurrentColor;

	private float m_OriginalAlpha;

	private int mWheelType;

	private string[] mColorList;

	private int mCurWheelsIndex;

	private List<UIHudBlockEditColorSetterWheelsItem> mCachedWheelsColorList;

	protected List<PopMenuData> m_PopMenuDataList;

	private UIPopMenuSmallControler m_WheelsMenuCtrl;

	private Dictionary<int, string> mWheelsPopMap;

	private Dictionary<int, string> mWheelsColor;

	private float mHue;

	private float mSaturation;

	private float mBrightness;

	private Vector2 SVTextureSize;

	private const float m_HeightSpace = 40f;

	private UIRoot m_UIRoot;

	private int margineDis;

	public Color CurrentColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float OriginalAlpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float H
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public GameObject GetTutorialPopupContent()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnToggleTab(UIToggleButton selectBtn)
	{
	}

	public void SetCurrentColor(Color color)
	{
	}

	private void GenerateWheels()
	{
	}

	private void OnClickWheelsColor(int index)
	{
	}

	private void InitPopMenu()
	{
	}

	private void GenerateWheelsMenuData()
	{
	}

	private void OnWheelsSelected(object obj)
	{
	}

	private void RefreshWheels()
	{
	}

	private void ResetWheelsColorSelect()
	{
	}

	public void SetPos(Vector3 pos)
	{
	}

	private IEnumerator SetPosition(Vector3 Pos)
	{
		return null;
	}

	private void OnSVTextureDrag(GameObject go, Vector2 delta)
	{
	}

	private void OnSVTexturePress(GameObject go, bool state)
	{
	}

	private void OnSVTextureDragOrPress()
	{
	}

	private void OnHSVSliderBar()
	{
	}

	private void OnHSVSliderBarEndChange()
	{
	}

	private void OnColorChanged()
	{
	}

	private void GenerateAlphaTexture()
	{
	}

	private void OnAlphaSliderBar()
	{
	}

	private void OnAlphaSliderBarEndChange()
	{
	}

	private void OnAlphaInputSubmit()
	{
	}

	private void GenerateHueBar()
	{
	}

	private void GenerateSVTexture()
	{
	}

	private void OnColorInputSubmit()
	{
	}

	private void UpdateBoardPoint()
	{
	}

	private void UpdateColorLabel()
	{
	}

	private void UpdateAlpha()
	{
	}

	private void UpdateBG()
	{
	}

	public int GetTutorialWheelPresetCount()
	{
		return 0;
	}

	public UIWidget GetTutorialWheelPresetWidget(int index)
	{
		return null;
	}

	public string GetTutorialWheelPresetHex(int index)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
