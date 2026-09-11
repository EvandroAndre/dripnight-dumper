using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHudProfileInfo : UGCHudWidget
{
	public UIEffectSprite m_Bg;

	public UIEffectSprite m_DefaultBg;

	public UIEffectSprite m_HeadSprite;

	public UIEffectSprite m_DefaultHeadSprite;

	public UISprite m_HeadFrame;

	public UISprite m_PinIcon;

	public Transform m_Node;

	public Transform m_Type1;

	public Transform m_Type2;

	public UILabel m_Name1;

	public UILabel m_Name2;

	public UISprite m_BRRank;

	public UISprite m_CSRank;

	private Vector3 m_Scale;

	private Vector2Int m_HeadBaseDepth;

	private Vector2Int m_BgBaseDepth;

	private bool m_ShowPin;

	private uint m_PinID;

	public Vector3 Scale
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public override void SetParentHasChanged()
	{
	}

	public override UGCHudWidgetType GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public override void SetLayer(int layer)
	{
	}

	public override Vector2Int SetDepth(Vector2Int depth, int stepDepth)
	{
		return default(Vector2Int);
	}

	public Vector2Int SetChildrenDepth(Transform parent, Vector2Int depth, int stepDepth, ref Vector2Int baseDepth)
	{
		return default(Vector2Int);
	}

	public void OnHeadIDChanged(string cur)
	{
	}

	public void OnBannerIDChanged(string cur)
	{
	}

	public void OnPinIDChanged(string cur)
	{
	}

	public void OnNickNameChanged(string cur)
	{
	}

	public void OnBRRankChanged(int rank, int peakrank)
	{
	}

	public void OnCSRankChanged(int rank, int peakrank)
	{
	}

	public void OnShowTypeChanged(int cur)
	{
	}

	public void OnShowPinChanged(bool cur)
	{
	}

	public void OnShowNameChanged(bool cur)
	{
	}

	public void OnShowRankChanged(int cur)
	{
	}

	private void RefreshPinIcon(bool show, uint id)
	{
	}

	public new void _003C_003EiFixBaseProxy_SetParentHasChanged()
	{
	}

	public UGCHudWidgetType _003C_003EiFixBaseProxy_GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public void _003C_003EiFixBaseProxy_SetLayer(int P0)
	{
	}

	public Vector2Int _003C_003EiFixBaseProxy_SetDepth(Vector2Int P0, int P1)
	{
		return default(Vector2Int);
	}
}
