﻿using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
  Team team; // Player chosen team
  Pilot pilot; // Player chosen pilot

  private void Awake()
  {
    SetUpSingleton();
  }

  // Keep only one Game Session
  private void SetUpSingleton()
  {
    int numberGameSessions = FindObjectsOfType<GameSession>().Length;
    if (numberGameSessions > 1)
    {
      Destroy(gameObject);
    }
    else
    {
      DontDestroyOnLoad(gameObject);
    }
  }

  // Setting the player team
  public void SetPlayerTeam(int i)
  {
    team = new Team(World.op_teams[i].Id, World.op_teams[i].Name, World.op_teams[i].LogoString, World.op_teams[i].CarString);
  }

  // Setting the player pilot
  public void SetPlayerPilot(int i)
  {
    pilot = new Pilot(World.op_pilots[i].Id, World.op_pilots[i].Name, World.op_pilots[i].Country, World.op_pilots[i].Age, World.op_pilots[i].Over);
  }
}
