using System;
using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW;

public class UIHUDHGTeammateReviveItem : MonoBehaviour
{
	public GameObject SelectOnRoot;

	public UIButton SelectBtn;

	public UILabel NickNameLabel;

	public UISprite IndexSprite;

	public UILabel IndexLabel;

	public UILabel AutoReviveLeftTimeLabel;

	public List<Color> IndexColorList;

	private uint m_EndTimeMs;

	private bool m_IsSelected;

	private UITimeLabelHelper m_TimeHelper;

	private BHGGAEEHJCO m_PlayerID;

	private Action<BHGGAEEHJCO, bool> _OnSelectStateChangeCallBack;

	private bool IsSelected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint EndTimeMs => 0u;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void InitSelectCallBack(Action<BHGGAEEHJCO, bool> callBack)
	{
	}

	public void BindPlayer(BHGGAEEHJCO playerId, uint reviveLeftTimeMS)
	{
	}

	public void UnBindPlayer()
	{
	}

	private void OnItemClick()
	{
	}

	private void Update()
	{
	}
}
