using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
#if UNITY_STANDALONE||UNITY_EDITOR
using System.Diagnostics;
#endif

public static class PdfViewer {

#if UNITY_WEBGL && !UNITY_EDITOR
    public static void OpenPdfByReleativePath(string path)
    {
        WebGL.OpenPdfByUrl(Application.streamingAssetsPath +"/PDFFiles/"+ path);
    }
#elif UNITY_STANDALONE || UNITY_EDITOR

    private static string exePath;
    static PdfViewer()
    {
        exePath = Application.streamingAssetsPath + "/pdfReader.exe";
    }
    public static void OpenPdfByReleativePath(string path)
    {
        Process pc = new Process();
        pc.StartInfo.UseShellExecute = false;
        pc.StartInfo.FileName = exePath;
        pc.StartInfo.CreateNoWindow = true;
        pc.StartInfo.Arguments = Application.streamingAssetsPath + "/PDFFiles/" + path;
        pc.EnableRaisingEvents = true;
        //pc.Exited += new EventHandler(myProcess_Exited);
        pc.Start();
    }
#endif
}
