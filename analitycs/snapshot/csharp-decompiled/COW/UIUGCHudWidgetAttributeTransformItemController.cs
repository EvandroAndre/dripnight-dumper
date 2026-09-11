using System;
using GCommon;

namespace COW;

public class UIUGCHudWidgetAttributeTransformItemController : UIBaseController
{
	public enum TransformEnum
	{
		X,
		Y,
		Width,
		Height,
		Angle
	}

	private UIUGCHudWidgetAttributeTransformItemView m_View;

	private int m_CurrentValue;

	private TransformEnum m_TransformEnum;

	public Action onValueChanged;

	public int Value
	{
		get
		{
			return 0;
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

	public void SetTransformEnum(TransformEnum transformEnum)
	{
	}

	public void SetData(int cur)
	{
	}

	private void RefreshContent()
	{
	}

	private void OnMinusBtnClick()
	{
	}

	private void OnAddBtnClick()
	{
	}

	private void OnInputChanged()
	{
	}

	private void OnInputSubmit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
