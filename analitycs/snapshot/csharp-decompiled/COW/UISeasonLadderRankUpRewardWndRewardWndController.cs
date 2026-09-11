using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UISeasonLadderRankUpRewardWndRewardWndController : CommonRewardWindowStyleBaseController
{
	public new CommonRewardWnd_BGStyle_SeasonLadderRankUPView m_View;

	private ELadderRankUpMatchType m_LadderRankUpMatchType;

	private ResourceID m_BigIconRes;

	private bool m_HasFirstRankReward;

	private string m_CurRankName;

	private uint m_CurRank;

	private bool showKey;

	private UIModelMall m_ModelMall;

	private GameObject effect;

	private string GUIDEBTNSPRITENAME;

	private string NORMALBTNSPRITENAME;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override string GetGuideBtnSpriteName()
	{
		return null;
	}

	protected override string GetNormalBtnSpriteName()
	{
		return null;
	}

	protected override UIAtlas GetGuideBtnSpriteAtlas()
	{
		return null;
	}

	protected override UIAtlas GetNormalBtnSpriteAtlas()
	{
		return null;
	}

	public void SetUIData(ELadderRankUpMatchType ladderRankUpMatchType, string rankName, ResourceID iconRes, uint rank, bool hsaFirstRankReward)
	{
	}

	public override Vector3 GetExtraItemPos()
	{
		return default(Vector3);
	}

	public override void GetRewardGridPosAndPivot(out Vector3 pos, out UIWidget.Pivot? pivot)
	{
		pos = default(Vector3);
		pivot = null;
	}

	private bool isReachRankLimitByRankType(ExchangeStoreItemDesc item)
	{
		return false;
	}

	private void RefreshUIView()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public string _003C_003EiFixBaseProxy_GetGuideBtnSpriteName()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetNormalBtnSpriteName()
	{
		return null;
	}

	public UIAtlas _003C_003EiFixBaseProxy_GetGuideBtnSpriteAtlas()
	{
		return null;
	}

	public UIAtlas _003C_003EiFixBaseProxy_GetNormalBtnSpriteAtlas()
	{
		return null;
	}

	public Vector3 _003C_003EiFixBaseProxy_GetExtraItemPos()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_GetRewardGridPosAndPivot(out Vector3 P0, out UIWidget.Pivot? P1)
	{
		P0 = default(Vector3);
		P1 = null;
	}
}
