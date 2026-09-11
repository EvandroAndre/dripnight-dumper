namespace COW.GamePlay;

public interface NODKNGMKFIP
{
	uint GetHintType();

	float GetHintPriority();

	bool IsHintShowing();

	void OnHintShow();

	void OnHintHide();
}
