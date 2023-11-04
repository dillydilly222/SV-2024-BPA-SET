using UnityEngine;

namespace LP.FDG.Interactables
{
    public class Interactable : MonoBehaviour
    {
        public bool isInteracting = false;
        public GameObject highlight = null;
        public virtual void Awake()
        {
            highlight.SetActive(false);
        }

        public virtual void OnInteractEnter()
        {
            ShowHiglight();
            isInteracting = true;
        }

        public virtual void OnInteractExit()
        {
            HideHiglight();
            isInteracting = false;
        }

        public virtual void ShowHiglight()
        {
            highlight.SetActive(true);
        }

        public virtual void HideHiglight()
        {
            highlight.SetActive(false);
        }

    }
}


