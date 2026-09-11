using GCommon;
using UnityEngine;

namespace COW;

public class UICreateRoomMapItem : MonoBehaviour
{
	public UISprite m_MapImg;

	public UINetworkTexture m_CDNTexutre;

	public UIToggleButton m_MapToggle;

	public GameObject m_LockBG;

	public UILabel m_MapNameTxt;

	public UISprite m_DownloadingIcon;

	public UINewDownloadInfoController m_Downloader;

	private uint m_MapID;

	private uint m_GameMode;

	private string m_MapName;

	public SelectMapItemDelegate fnSelectMapItem;

	public uint MapID => 0u;

	public uint GameMode => 0u;

	public string MapName => null;

	public void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetData(uint mapID, uint gameMode)
	{
	}

	private void Update()
	{
	}

	public void ClearData()
	{
	}

	public void OnMapToggleSelect()
	{
	}

	public void TryDownLoadMapRes()
	{
	}
}
