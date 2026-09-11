using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW.Gameplay.UGC;

public class UIHudResourceShopItemController : UIEasyListItemController
{
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public UIHudResourceShopItemController _003C_003E4__this;

		public ulong resourceId;

		internal void _003COnStateBtnClicked_003Eb__0()
		{
		}

		internal void _003COnStateBtnClicked_003Eb__1()
		{
		}
	}

	private UIHudResourceShopItemView m_View;

	private UGCResourceShopItem m_Data;

	private UGCResourceShopMetaData m_MetaData;

	private SceneEditResourceShopManager m_Manager;

	private UIModelSceneEdit m_ModelSceneEdit;

	private EUGCResourceShopTab m_MainTab;

	private int m_MainCategroy;

	private int m_SubCategory;

	private string m_SearchValue;

	private int m_RecommendTypeId;

	private int m_RecommendEventId;

	private HNDHJGJILHC m_Game;

	private float RequestCoolingStartTime;

	private int m_TextureOriWidth;

	private int m_TextureOriHeight;

	private const uint STATE_BG_COLOR1 = uint.MaxValue;

	private const uint STATE_LABEL_COLOR1 = 3520188927u;

	private const uint STATE_BG_COLOR2 = 4294967206u;

	private const uint STATE_LABEL_COLOR2 = 2880154623u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetItemIndex(int index)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void UpdateShopStatus()
	{
	}

	private void UpdateStateBtn()
	{
	}

	private void OnDetailBtnClick()
	{
	}

	public void OnExposure(HashSet<string> exposedKeys)
	{
	}

	private void TryLogPurchase()
	{
	}

	private void OnStatusBtnClicked()
	{
	}

	private void OnStateBtnClicked()
	{
	}

	private void UpdateState(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
