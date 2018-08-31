using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teFileOperation
{

  public delegate void InvalidPathEventHandler(teFileOperationBase sender, InvalidPathEventArgs e);

  public class teFileOperationBase : IteFileOperation
  {

    public event InvalidPathEventHandler InvalidPath;
    
    public static  string filePath = "";
    private readonly string folderTeFile = "//..//teFile";

    public teFileOperationBase() 
    {


    }

    protected virtual void OnInvaildPath(InvalidPathEventArgs e)
    {
      if (InvalidPath != null)
      {
        InvalidPath(this, e);
      }
      else
        throw e.Error;
    }

    public static void teFileOperationBase_InvalidPath(teFileOperationBase sender, InvalidPathEventArgs e)
    {
      //string fehlerPath = "Der Pfad ist ungültig";
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

      catch (Exception ex)
      {
        // MessageBox.Show(String.Format("Beim überprüfen der Struktur vom Verzeichnis ist ein Fehler aufgetreten.{0}Meldung: {1}",Environment.NewLine, ex.Message));

        InvalidPathException exPath = new InvalidPathException("Fehler");
        exPath.Data.Add("Time", DateTime.Now);

        OnInvaildPath(new InvalidPathEventArgs("", "File", ex));
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


        InvalidPathException exPath = new InvalidPathException("Fehler");
        exPath.Data.Add("Time", DateTime.Now);

        OnInvaildPath(new InvalidPathEventArgs("", "File", exPath));

      
      return saveSuccessful;
    }

    public virtual bool readFile()
    {
      bool readSuccessful = false;


      return readSuccessful;
    }
  }

  [Serializable]
  public class InvalidPathException : Exception
  {

    public InvalidPathException() { }
    public InvalidPathException(string message) : base(message) { }
    public InvalidPathException(string message, Exception inner) : base(message, inner) { }
    protected InvalidPathException(SerializationInfo info, StreamingContext context) : base(info, context) { }


  }

  public class InvalidPathEventArgs : EventArgs
  {
    private string _InvalidPath;
    private string _PropertyName = "";

    private Exception _Error;
    public Exception Error
    {
      get { return _Error; }
    }

    public string InvalidPath
    {
      get
      {
        return _InvalidPath;
      }
    }

    public InvalidPathEventArgs(string invalidPath, string propertyName, Exception error)
    {
      _InvalidPath = invalidPath;
      _Error = error;
      if (propertyName == "" || propertyName == null)
        _PropertyName = "[unknown]";
      else
        _PropertyName = propertyName;
    }

  }

  interface IteFileOperation
  {
    void getFilePath();
    bool loadFile();
    bool saveFile();
  }

}
