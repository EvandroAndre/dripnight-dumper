using System;

namespace COW;

public class LobbyEventBubbleData
{
	public LobbyEventType LobbyEventType;

	public Func<bool> CanShow;

	public Func<bool> EventShowInContainer;

	public Action ResetBubble;

	public bool IsShowing;
}
