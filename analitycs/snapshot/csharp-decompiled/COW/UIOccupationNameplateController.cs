using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIOccupationNameplateController : UIBaseController
{
	private UIOccupationNameplateView m_View;

	private NameplateViewData m_Data;

	private List<UILabel> m_TitleLabel;

	private List<UILabel> m_ValueLabel;

	private bool m_IsExtend;

	private const int SHRINK_DEPTH = 2;

	private const int EXTEND_DEPTH = 3;

	private bool _003CHasPosConflict_003Ek__BackingField;

	public bool IsExtend => false;

	public bool HasPosConflict
	{
		get
		{
			return _003CHasPosConflict_003Ek__BackingField;
		}
		set
		{
			_003CHasPosConflict_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(NameplateViewData data, bool needReverseBG, Vector3 extendPos)
	{
	}

	private void ReverseBGSprite()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void ClickShrinkBtnByID(uint id)
	{
	}

	private void OnShrinkBtnClick()
	{
	}

	public void ShowExtendStyle()
	{
	}

	private void OnExtendBtnClick()
	{
	}

	public void OnNameplatesCilcked(uint id)
	{
	}

	public void PlayShrinkAnim()
	{
	}

	public Vector3 GetExtendPos()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
