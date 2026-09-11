using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudWaitingThumbUpController : UIBaseController
{
	private enum EVFXType
	{
		None,
		VFX1234,
		VFX2,
		VFX234,
		VFX3,
		VFX34,
		VFX4,
		VFX5
	}

	private int m_ThumbUpIndexBit;

	private int m_ThumbUpNum;

	private UIHudWaitingThumbUpView m_View;

	private uint m_HideDelayCall;

	private float HIDE_NORMAL_DELAYCALL;

	private float HIDE_LAST_DELAYCALL;

	private uint VOICE_ID;

	private bool m_ReachMax;

	private List<UISprite> m_ListTeamIndexIconList;

	private List<UILabel> m_ListTeamIndexTextList;

	private HashSet<int> m_HashSetVFX;

	private Dictionary<int, string> m_DicVFXTypeToResName;

	private Dictionary<int, Transform> m_DicVFXTypeToTransForm;

	private Dictionary<uint, int> m_DicAsyncResultTicketToVFXType;

	private float GetDelayHideTime => 0f;

	private bool CanShowWaitingThumb => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitUIData()
	{
	}

	private void OnThumbUpBtnClick()
	{
	}

	public void PushThumbUpPlayerData(int curThumbUpIndexBit)
	{
	}

	private void CreateVFX(EVFXType vfxType)
	{
	}

	private void OnVFXLoaded(uint ticket, bool succeeded, Object obj)
	{
	}

	private void _003CPushThumbUpPlayerData_003Eb__26_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
