using COW.GamePlay;
using UnityEngine;
using proto;

namespace COW;

public class UIBigmapFFWSFlagTeammateView : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public uint id;

		internal bool _003CSetLoadout_003Eb__0(Item x)
		{
			return false;
		}
	}

	public UILabel NameLable;

	public UISprite IconSpr;

	private int _003CTeamIndex_003Ek__BackingField;

	private bool hasSetted;

	public int TeamIndex
	{
		get
		{
			return _003CTeamIndex_003Ek__BackingField;
		}
		internal set
		{
			_003CTeamIndex_003Ek__BackingField = value;
		}
	}

	internal void SetViewData(MatchTeam.KMGBNNHDOHF p)
	{
	}

	private void ShowLoadOut(Player player)
	{
	}

	private bool SetLoadout(uint id)
	{
		return false;
	}
}
