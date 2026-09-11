using System.Collections.Generic;
using UnityEngine;

namespace COW.PotentiallyVisible;

public class PotentiallRootNodeSetting : MonoBehaviour
{
	public BoxCollider WolrdBoundsCollider;

	public ushort Index;

	public PotentiallyVisibleGroup visibleGroup;

	public string visibleGroupResourceID;

	public bool NeedLoadComposeData;

	public Bounds WolrdBounds;

	private Dictionary<ushort, List<PotentiallyVisibleSetItem>> potentiallyVisibleSetItems;

	private List<PotentiallyVisibleSetItem> notActivePotentiallyVisibleSetItems;

	public void Init()
	{
	}

	private void AddPvsItem(PotentiallyVisibleSetItem item)
	{
	}

	private void RemovePvsItem(PotentiallyVisibleSetItem item)
	{
	}

	public void InitPotentiallyVisibleSetItems()
	{
	}

	public void UnInit()
	{
	}

	public Dictionary<ushort, List<PotentiallyVisibleSetItem>> GetPotentiallyVisibleSetItems()
	{
		return null;
	}

	public List<PotentiallyVisibleSetItem> GetNotActivePotentiallyVisibleSetItems()
	{
		return null;
	}

	public void AddPoteniallyVisibleSetItem(PotentiallyVisibleSetItem item)
	{
	}

	public void RemovePoteniallyVisibleSetItem(PotentiallyVisibleSetItem item)
	{
	}
}
