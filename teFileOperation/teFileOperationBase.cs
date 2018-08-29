using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teFileOperation
{
  public class teFileOperationBase : IteFileOperation
  {

    public static string filePath = "";
    private readonly string folderTeFile = "//..//teFile";

    public teFileOperationBase() 
    {

    }

    public virtual void getFilePath()
    {
      try
      {
        string currentDir = Environment.CurrentDirectory;

        filePath += currentDir + folderTeFile;

        if (!Directory.Exists(filePath))
        {
          Directory.CreateDirectory(filePath);
        }
      }
      catch(IOException ex)
      {
        MessageBox.Show(String.Format("Beim überprüfen der Struktur vom Verzeichnis ist ein Fehler aufgetreten.{0}Meldung: {1}",Environment.NewLine, ex.Message));
      }

    }
    public virtual bool loadFile()
    {
      bool loadSuccessful = false;

      return loadSuccessful;
    }

    public virtual bool saveFile()
    {
      bool saveSuccessful = false;

      return saveSuccessful;
    }

    public virtual bool readFile()
    {
      bool readSuccessful = false;



      return readSuccessful;
    }
  }

  interface IteFileOperation
  {
    void getFilePath();
    bool loadFile();
    bool saveFile();
  }

}
