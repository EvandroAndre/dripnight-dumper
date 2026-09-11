using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCTimeModule : IUGCModule
{
	private UGCRuntime ugcRuntime;

	private bool m_IsPaused;

	public void Init(object[] args)
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public void Destroy()
	{
	}

	public UGCTimeModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void PauseGame()
	{
	}

	public void ResumeGame()
	{
	}

	public bool IsPaused()
	{
		return false;
	}
}
