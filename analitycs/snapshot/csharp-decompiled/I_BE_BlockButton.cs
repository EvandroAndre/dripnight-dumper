using UnityEngine;

public interface I_BE_BlockButton
{
	Transform Transform { get; }

	UIWidget Widget { get; }

	UIButton Btn { get; }

	BoxCollider Collider { get; }

	void UpdateDepth(int startDepth = 1);
}
