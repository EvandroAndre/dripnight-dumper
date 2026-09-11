using System.Threading;
using UnityEngine;

namespace GCommon;

public class GameMemoryObserver : MonoBehaviour
{
	public static GameMemoryObserver instance;

	private bool needLogMemory;

	public float logAvailMemoryInterval;

	public float logAvailMemoryTimer;

	private int currentMemory;

	private int maxMemory;

	private int minMemory;

	private int swapMemory;

	private int swapFrequency;

	private int pssMemory;

	private string smapMemPath;

	private Thread smapMemoryThread;

	private bool smapMemoryThreadRunning;

	private AutoResetEvent smapThreadTriggerSignal;

	private const int SmapMemoryIntervalMs = 30000;

	private const string SwapPrefix = "Swap:";

	private const int SwapValueLength = 19;

	private const string PssPrefix = "Pss:";

	private const int PssValueLength = 20;

	private static readonly char[] memSwapCharBuffer;

	private static readonly char[] memPssCharBuffer;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LogAvailMemory()
	{
	}

	public int GetMinAvailMemory()
	{
		return 0;
	}

	public int GetMaxAvailMemory()
	{
		return 0;
	}

	public int GetSwapMemory()
	{
		return 0;
	}

	public int GetSwapFrequency()
	{
		return 0;
	}

	public int GetPssMemory()
	{
		return 0;
	}

	public void StartLogMemory()
	{
	}

	public void StopLogMemory()
	{
	}

	private void StartSmapMemory()
	{
	}

	private void StopSmapMemory()
	{
	}

	private int ConvertCharArrayToNumber(char[] charArray, int length)
	{
		return 0;
	}

	private void SmapMemory()
	{
	}

	private void SmapMemoryThreadLoop(object parameter)
	{
	}

	private void OnDestroy()
	{
	}
}
