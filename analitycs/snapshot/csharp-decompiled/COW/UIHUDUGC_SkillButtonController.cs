using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_SkillButtonController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_SkillButtonView m_View;

	private UGCSkillButtonHudRepItem m_LogicComponent;

	private UGCEntityRepItem m_BaseRepItem;

	private Dictionary<UIWidget, Color> m_Colors;

	private string m_Name;

	private float m_CDTime;

	private float m_CDDurationTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void Update()
	{
	}

	private void OnClickButton()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnNameChanged(string cur)
	{
	}

	private void OnIconSpriteChanged(string cur)
	{
	}

	private void OnIconColorChanged(int cur)
	{
	}

	private void OnSizeChanged(int cur)
	{
	}

	private void OnLocalPositionChanged(Vector3 cur)
	{
	}

	private void OnCountChanged(int cur)
	{
	}

	private void OnCDStartTimeChanged(int cur)
	{
	}

	private void OnCDDurationTimeChanged(int cur)
	{
	}

	private void OnGreyChanged(bool cur)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
