namespace ReactUI;

public sealed class UIVariableBindActive : UIVariableBindBool
{
	public enum TransitionModeEnum
	{
		Instant,
		Fade
	}

	private TransitionModeEnum transitionMode;

	private float transitionTime;

	protected override void OnValueChanged()
	{
	}
}
