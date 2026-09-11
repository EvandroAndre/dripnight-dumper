namespace message;

public enum INBOLAPNGHA : uint
{
	EAutoPathBombState_Initing,
	EAutoPathBombState_Moving,
	EAutoPathBombState_Stay,
	EAutoPathBombState_EnemyDetected,
	EAutoPathBombState_Pursue,
	EAutoPathBombState_DestroyWhenExplode,
	EAutoPathBombState_DestroyByDamage,
	EAutoPathBombState_DestroyWhenTimeout,
	EAutoPathBombState_FollowTarget
}
