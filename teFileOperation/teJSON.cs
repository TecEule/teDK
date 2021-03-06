﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using te.TerminkalenderType;

namespace teFileOperation
{
  public class teJSON : teFileOperationBase
  {

    private string fileEndung = ".json";
    private string currentFilePath = "";

    private static teJSON _instance;
    public static teJSON Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new teJSON();
          _instance.getFilePath();       
        }
        return _instance;
      }
    }

    private teJSON()
    {
      

    }


    public override void getFilePath()
    {
      base.getFilePath();  
    }

    private bool existFile()
    {
      bool fileExist = false;

      currentFilePath = filePath + "//teJson" + fileEndung;

      if (File.Exists(currentFilePath))
      {
        fileExist = true;
      }

      if (!fileExist)
        MessageBox.Show("Datei nicht vorhanden.");

      return fileExist;
    }

 
    public override bool readFile()
    {
      bool success = false;

      success = existFile();

      if (success)
      {
        string content = File.ReadAllText(currentFilePath);
        MessageBox.Show(content);
      }

      return success;
    }

    public TerminkalenderItem getObject()
    {
      TerminkalenderItem item = null;



      return item;
    }

  }
}
