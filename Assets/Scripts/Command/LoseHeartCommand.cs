using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseHeartCommand : Command
{
    public override void Execute()
    {
        GameCtrl.Instance.LoseHeart();
    }
}
