using System;
using UnityEngine;

namespace COW;

public class UITipsButton : MonoBehaviour, ITipsDelegate
{
	public UIButton m_Button;

	public string m_TipsType;

	public GameObject m_TipsObject;

	public UILabel m_TipsNumLabel;

	public Action m_OnTipsVisibilityChanged;

	public ETipsType m_Type;

	private void Awake()
	{
	}

	public void SetTipsType(ETipsType type)
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	private void SetTipNumber(int num)
	{
	}

	private void ClearTipsWhenClick()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetOnTipsVisibilityChanged(Action func)
	{
	}

	public void ResetTipsVisibilityChanged()
	{
	}
}
