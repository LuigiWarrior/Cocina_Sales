// Copyright © 2018 – Property of Tobii AB (publ) - All Rights Reserved

using UnityEngine;

namespace Tobii.XR.Examples
{
    /// <summary>
    /// Prints out messages.
    /// </summary>
    public class UIPrinter : MonoBehaviour
    {
        public void PrintButtonClicked(GameObject button)
        {
            Debug.Log(button.name + " has been clicked.");
        }

    }
}
