using UnityEngine;
using System.Collections;

public static class GameEvents
{
	public static Signal GameConnectedSignal = new Signal();
}

public static class InputEvents
{
	public enum Events {
		GAME_STARTING,
		GAME_LOADED,
		GAME_END,
		SWIPE_LEFT,
		SWIPE_RIGHT,
		TILT,
		HOLD,
		TAP,
		COUNT
	}

	public static Signal[] Signals = new Signal[(int)Events.COUNT] {
		new Signal(),
		new Signal(),
		new Signal(),
		new Signal(),
		new Signal(),
		new Signal(),
		new Signal(),
		new Signal()
	};
}