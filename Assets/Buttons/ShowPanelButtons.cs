using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanelButtons : MonoBehaviour
{
   public string PanelId;
   private PanelManager _panelmanager;
   private void Start()
{
    _panelmanager = PanelManager.Instance;
}   public void DoShowPanel(){
        _panelmanager.showPanels(PanelId);
   }
}
