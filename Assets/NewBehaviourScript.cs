using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;


public class NewBehaviourScript : MonoBehaviour {
    public void OpenPdf()
    {
        PdfViewer.OpenPdfByReleativePath("test.pdf");

    }
}
