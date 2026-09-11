using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class TeammateGameObject
{
	public GameObject teammate;

	public GameObject id;

	public GameObject direction;

	public UIWidget directionSprite;

	public UISprite directionSpriteArrow;

	public UIWidget directionArea;

	public GameObject knockdown;

	public GameObject dead;

	public MiniMapVehicleHorse vehicle;

	public GameObject quickChatEffect;

	public GameObject idIndexLabel;

	public UISprite inmapShowSpr;

	public int TeamIndex;

	public GameObject teamRallyIcon;

	public GameObject teamMateIDContainer;

	private TweenAlpha Firing_Tween;

	private ETeammateState m_CurrentState;

	public TeammateGameObject(GameObject _teammate)
	{
	}

	private void SetTeamIDVisble(bool visible)
	{
	}

	public ETeammateState GetState()
	{
		return ETeammateState.eNone;
	}

	public void SetState(ETeammateState nextState, List<object> argList = null, uint playerID = 0u)
	{
	}

	public void PlayQuickChatEffect()
	{
	}

	public void ShowTeamRallyIcon(bool show)
	{
	}
}
