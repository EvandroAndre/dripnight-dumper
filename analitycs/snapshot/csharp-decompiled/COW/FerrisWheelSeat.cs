using COW.GamePlay;
using UnityEngine;

namespace COW;

public class FerrisWheelSeat : MonoBehaviour
{
	public BHGGAEEHJCO CurHoldPlayer;

	public uint Index;

	public bool CanGetOn()
	{
		return false;
	}

	public void SetPlayer(BHGGAEEHJCO p)
	{
	}
}
