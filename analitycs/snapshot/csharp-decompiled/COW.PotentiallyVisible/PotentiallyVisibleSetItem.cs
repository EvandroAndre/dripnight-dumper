using System.Collections.Generic;
using UnityEngine;

namespace COW.PotentiallyVisible;

public class PotentiallyVisibleSetItem : MonoBehaviour
{
	public ushort RootIndex;

	public MapItemSize size;

	public List<ushort> ownerCellIdList;

	public MapItemType occlusionType;

	private bool setvisible;

	private bool visible;

	private GameObject go;

	private bool active;

	private Renderer[] renders;

	private IPVSItemActive itemActive;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void InitActive()
	{
	}

	public bool IsPVSItemActive()
	{
		return false;
	}

	public void SetPVSItemActive(IPVSItemActive item)
	{
	}

	private bool IsStaticItems()
	{
		return false;
	}

	private void InitRenders()
	{
	}

	private void SetRendersActive(bool bVisible)
	{
	}

	public int GetRendersCount()
	{
		return 0;
	}

	public void SetActive(bool value)
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public bool NeedRefresh()
	{
		return false;
	}

	public bool GetRefreshVisible()
	{
		return false;
	}

	public void SetRefreshVisible(bool value)
	{
	}

	public void RefreshVisible()
	{
	}

	public void SetVisible(bool value)
	{
	}

	public bool IsVisible()
	{
		return false;
	}
}
