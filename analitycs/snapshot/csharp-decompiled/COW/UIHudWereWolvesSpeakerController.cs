using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWereWolvesSpeakerController : UIBaseController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<BEIPMEAHGNP, bool> _003C_003E9__5_0;

		internal bool _003CSetData_003Eb__5_0(BEIPMEAHGNP voteInfo)
		{
			return false;
		}
	}

	private UIHudWereWolvesVoteSpeakerView m_View;

	private UIHudWereWolvesVoteController m_parent;

	private List<BHGGAEEHJCO> m_PlayerList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(UIHudWereWolvesVoteController parent)
	{
	}

	private int Cmp(BEIPMEAHGNP infoA, BEIPMEAHGNP infoB)
	{
		return 0;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnAllClick()
	{
	}

	private void OnBgClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
