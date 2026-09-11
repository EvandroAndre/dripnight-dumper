using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UITipsNormalController : UIBaseController
{
	private class TipsNormalData
	{
		public GameObject m_TipsContainer;

		public UITipsButton m_TipsButton;

		public ETipsType m_TipsType;
	}

	private UITipsNormalView m_View;

	private Dictionary<uint, TipsNormalData> m_TipsDict;

	private Dictionary<uint, ResourceID> m_TipsResourceDict;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void AddTipsDict(TipsIconType iconType, GameObject obj, ResourceID resourceID)
	{
	}

	public void InitTip(TipsIconType iconType, ETipsType tipsType = ETipsType.None)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetTipActive(TipsIconType iconType, bool flag)
	{
	}

	public void OnTipsVisibilityChanged()
	{
	}

	public void ChangeNewIconSizeAndPos(int width, int height, Vector3 Trans)
	{
	}

	public void ChangeNewIconPos(Vector3 Trans)
	{
	}

	public void SetNewIconDepth(int depth)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
