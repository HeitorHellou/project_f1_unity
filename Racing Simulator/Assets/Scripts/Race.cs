﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Race : MonoBehaviour
{
  public TextMeshProUGUI[] grid_corrida;

  private void Start()
  {
    grid_corrida[0].text = World.op_grid[0].Nome_piloto;
    grid_corrida[1].text = World.op_grid[1].Nome_piloto;
    grid_corrida[2].text = World.op_grid[2].Nome_piloto;
    grid_corrida[3].text = World.op_grid[3].Nome_piloto;
    grid_corrida[4].text = World.op_grid[4].Nome_piloto;
    grid_corrida[5].text = World.op_grid[5].Nome_piloto;
    grid_corrida[6].text = World.op_grid[6].Nome_piloto;
    grid_corrida[7].text = World.op_grid[7].Nome_piloto;
    grid_corrida[8].text = World.op_grid[8].Nome_piloto;
    grid_corrida[9].text = World.op_grid[9].Nome_piloto;
  }

  private void Update()
  {
    
  }
}