using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudAvatarAttributeController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public GameObject vfx;

		internal void _003CPlayConfirmSelectFlyEffect_003Eb__0()
		{
		}
	}

	private UIHudAvatarAttributeView m_View;

	private uint LevelUpId;

	private Dictionary<uint, UIHudAvatarAttributeItemController> m_SelectNewIdToItemController;

	private float m_TotalTime;

	private float m_EndTime;

	private PMFDLKMCHKA phase;

	private UITimeLabelHelper m_TimeHelper;

	private List<UIHudAvatarAttributeItemController> m_AttributeItemsController;

	private int m_CanSelectCount;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected void ToggleConfiremBtnState(bool isEnable)
	{
	}

	public void SetView()
	{
	}

	private void ShowTime(object[] data)
	{
	}

	private void Update()
	{
	}

	private void OnItemSelect(object[] data)
	{
	}

	private void ProcessOnlyOneCanSelect(UIHudAvatarAttributeItemController trySelectItemController, uint randomNewId)
	{
	}

	private void ProcessMulCanSelect(UIHudAvatarAttributeItemController trySelectItemController, uint randomNewId)
	{
	}

	private void SetSelectCountLabel(int selectedCount = 0)
	{
	}

	private void OnBtnConfirmClick()
	{
	}

	private void PlayConfirmSelectFlyEffect(Vector3 startPos, Vector3 endPos)
	{
	}

	private void OnBtnShowAttributeBag()
	{
	}

	private void OnTryRefreshAttribute()
	{
	}

	private void ClearSelectInfo()
	{
	}

	private void OnRefreshAttribute(object[] data)
	{
	}

	private void SetItemView(UIHudAvatarAttributeItemController itemController, uint randomAttrId, List<uint> hasAttrIds, bool isNeedReplayAnim = false)
	{
	}

	private void SetRefreshShowData(IHMMAJHNFHP avatarAttribute)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
