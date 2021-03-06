﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GDK.StateMachine;

namespace GDK.GameLibrary
{
	/// <summary>
	/// State for reporting all wins to the platform.
	/// </summary>
	public class StatePayWin : BaseState
	{
		/// <summary>
		/// Configure the state in the given state machine.
		/// </summary>
		/// <param name="stateMachine">The state machine.</param>
		public override void Configure (GameStateMachine stateMachine)
		{
			stateMachine.StateMachine.Configure ("StatePayWin")
                .OnEntry (OnEntry)
                .OnExit (OnExit)
                .Permit ("TriggerStateGameOver", "StateGameOver");
		}

		/// <summary>
		/// Entry method to the state.
		/// </summary>
		private void OnEntry ()
		{
			UnityEngine.Debug.Log ("OnEntry StatePayWin");
		}

		/// <summary>
		/// Exit method from the state.
		/// </summary>
		private void OnExit ()
		{
			UnityEngine.Debug.Log ("OnExit StatePayWin");
		}
	}
}
