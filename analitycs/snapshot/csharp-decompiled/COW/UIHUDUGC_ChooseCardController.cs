using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_ChooseCardController : UIHUDUGC_InternalHudController
{
	private class ButtonView : MonoBehaviour
	{
		public UIButton button;

		public UILabel label;
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public Transform trans;

		public UIHUDUGC_ChooseCardController _003C_003E4__this;

		internal void _003COnButtonNamesChanged_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public Transform trans;

		public UIHUDUGC_ChooseCardController _003C_003E4__this;

		internal void _003COnButtonColorsChanged_003Eb__0()
		{
		}
	}

	private UIHUDUGC_ChooseCardView m_View;

	private UGCChooseCardHudRepItem m_Component;

	private UIHUDUGC_ChooseCardItemController m_SelectedItem;

	private float m_CountDownTimeS;

	private int m_LastCountDownTimeS;

	private const int MAX_FIXS_COUNT = 3;

	private List<UIHUDUGC_ChooseCardItemController.ItemData> m_ItemDataList;

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

	private string GetText(string key, object[] param)
	{
		return null;
	}

	private void OnClickSpaceBtn()
	{
	}

	private void OnClickButton(string buttonName)
	{
	}

	private void OnClickItem(string itemName)
	{
	}

	private void RefreshItemList()
	{
	}

	private void CheckSelectedItem()
	{
	}

	private void OnSelectedItem(UIHUDUGC_ChooseCardItemController item)
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnCountDownKeyChanged(string cur)
	{
	}

	private void OnCountDownChanged(int cur)
	{
	}

	private void OnDescriptionKeyChanged(string cur)
	{
	}

	private void OnDescriptionParamsChanged(List<object> cur)
	{
	}

	private void OnItemBGSpritesChanged(List<object> cur)
	{
	}

	private void OnItemBGColorChanged(List<object> cur)
	{
	}

	private void OnItemIconSpritesChanged(List<object> cur)
	{
	}

	private void OnItemNamesChanged(List<object> cur)
	{
	}

	private void OnItemDescsChanged(List<object> cur)
	{
	}

	private void OnSelectItemIndexChanged(int cur)
	{
	}

	private void OnButtonNamesChanged(List<object> cur)
	{
	}

	private void OnButtonColorsChanged(List<object> cur)
	{
	}

	private void OnLocSwitchChanged(bool switchOn)
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
