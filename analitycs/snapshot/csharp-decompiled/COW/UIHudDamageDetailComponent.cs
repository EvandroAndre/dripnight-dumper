using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudDamageDetailComponent : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public VisualInstanceHolder holder;

		internal void _003CRecycleAsyncIconDeferred_003Eb__0()
		{
		}
	}

	public UISprite DamageTypeIcon;

	public UISprite SpecialDamageIcon;

	private Vector2 m_CachedDamageOffset;

	private int m_AnchorLeftOffset;

	private int m_AnchorRightOffset;

	private ResourceID m_LastShowDamageIcon;

	private VisualInstanceHolder m_AsyncIconHolder;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void RecycleAsyncIconDeferred()
	{
	}

	private void RecycleAsyncIcon()
	{
	}

	public void SetInfo(int weaponDataID)
	{
	}

	public void SetDamageIcon(string iconName)
	{
	}

	public void SetDamageIconColor(Color color)
	{
	}

	private void _003CSetDamageIcon_003Eb__12_0(GameObject instance)
	{
	}
}
