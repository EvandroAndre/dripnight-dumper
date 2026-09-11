using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBuffPopOverController : UIBaseController
{
	private enum ScreenQuadrant
	{
		TopLeft,
		TopRight,
		BottomLeft,
		BottomRight
	}

	private UIHudBuffPopOverView m_View;

	private List<UIHudPlayerDebuffDetailItem> m_DebuffDetailItems;

	private UIClickMask m_ClickMask;

	private BuffPopOverType m_BuffType;

	private const int MaxHeight = 300;

	private int m_SpeicalCount;

	private int m_ChildBuffCount;

	private int m_preContentHeight;

	private float m_MinEdgeDistance;

	private float m_ContainerSpacing;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void RefreshVisibility(bool move = false)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void ShowNormalBuff(List<ulong> list, Vector3 pos, BuffPopOverType type, bool up)
	{
	}

	public void ShowSpeicalBuffs(List<BuffShowTipsData> slist, List<ulong> list, List<ulong> parentBuffList, Vector3 pos, BuffPopOverType type, bool up)
	{
	}

	public void ShowDebuffs(Vector3 pos, BuffPopOverType type, bool up)
	{
	}

	private void UpdateSpecialBuffs(List<BuffShowTipsData> slist)
	{
	}

	private void UpdateChildBuffs(List<ulong> parentBuffList)
	{
	}

	public void AddMaskContainer(UIWidget container)
	{
	}

	public void OnObserverSwitch(object[] data)
	{
	}

	private void CreateDetailItems(int count)
	{
	}

	private void UpdateDetailItems(List<ulong> infos, ref int contentHeight)
	{
	}

	private void UpdateBuffs(List<ulong> infos)
	{
	}

	private void SetContent(int contentHeight, int count)
	{
	}

	public bool OnUpdateGunBuff(List<ulong> list)
	{
		return false;
	}

	public bool OnUpdateBuff(List<ulong> list, List<BuffShowTipsData> datas, List<ulong> parentBuffList)
	{
		return false;
	}

	public bool OnUpdateDebuff()
	{
		return false;
	}

	private void UpdateDebuffs()
	{
	}

	private void SetContainer(Vector3 pos, bool up)
	{
	}

	private void UpdateMaskContainer()
	{
	}

	public void TryChangePos(bool up)
	{
	}

	private ScreenQuadrant GetScreenQuadrant(Vector3 screenPos, Vector2 screenCenter)
	{
		return ScreenQuadrant.TopLeft;
	}

	private Vector3 CalculatePopupOffset(ScreenQuadrant quadrant, float popupWidth, float popupHeight)
	{
		return default(Vector3);
	}

	private Vector3 ClampToScreenBounds(Vector3 localPos, float popupWidth, float popupHeight)
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshVisibility(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
