using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class TrainingWeaponTip : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public KeyValuePair<int, int> info;

		internal bool _003CShow_003Eb__0(WeaponScoreName v)
		{
			return false;
		}
	}

	public UITable attrTable;

	public UISprite tipBg;

	public UILabel weaponName;

	public GameObject tipItem;

	private Queue<GameObject> m_items;

	private Queue<GameObject> m_itemCaches;

	private int m_defaultHeight;

	private void Awake()
	{
	}

	public void Show(string name, Dictionary<int, int> adjustmentInfos)
	{
	}

	public void Hide()
	{
	}
}
