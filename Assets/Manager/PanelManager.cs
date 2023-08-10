using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class PanelManager : Singleton<PanelManager>
{
    public List<PanelModel> Panels;
    private Queue<PanelInstanceModel> _queue = new Queue<PanelInstanceModel>();

    public void showPanels(string panelId){
        PanelModel panelmodel = Panels.FirstOrDefault(panel =>panel.PanelId== panelId);
        if(panelmodel!= null){
            var newInstancePanel = Instantiate(panelmodel.PanelPrefab,transform);
            _queue.Enqueue(new PanelInstanceModel{
                PanelId = panelId,
                PanelInstance = newInstancePanel
            });
        }

    }
}
