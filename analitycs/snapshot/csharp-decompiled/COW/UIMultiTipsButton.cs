using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UIMultiTipsButton : MonoBehaviour, ITipsDelegate
{
	public UIButton m_Button;

	public GameObject m_TipsObject;

	public UILabel m_TipsNumLabel;

	public string[] m_TipsTypes;

	private List<int> m_Types;

	private Dictionary<int, int> m_TipNums;

	private bool m_IsClearing;

	private void Awake()
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
}
