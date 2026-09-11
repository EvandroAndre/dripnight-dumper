using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIClanBaseItemController : UIEasyListItemController
{
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public EClanOperation op;

		public ClanMember member_data;

		internal void _003COnPopMenuClick_003Eb__0()
		{
		}
	}

	protected UIButton BtnShowDeatil;

	protected UISprite SelectLine;

	protected UIWidget ClanItemInfoContainer;

	protected UISprite ClanPosition;

	protected UIButton BtnClanPosition;

	protected UILabel AccountState;

	protected UILabel InGameAccountState;

	protected UILabel InGameTime;

	protected Transform AccountInfoContainer;

	protected object m_Data;

	protected UIBaseProfileInfoController m_BaseProfile;

	protected string m_ClanPosition;

	protected uint COLOR_ONLINE;

	protected uint COLOR_OFFLINE;

	protected uint COLOR_INGAME;

	protected GameObject BGEven;

	protected GameObject BGOdd;

	protected override void OnUIInit()
	{
	}

	protected void OnBtnShowDetailClick()
	{
	}

	public override void OnItemBtnClick()
	{
	}

	private void OnPopMenuClick(object obj)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void OnClanPositionClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private float GetAlpha(EPresence.AccountPresence status)
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
