using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teFileOperation
{
  public class teFileOperationBase : IteFileOperation
  {

    protected static string filePath = "";
    private readonly string folderTeFile = "//teFile";

    public teFileOperationBase() 
    {

    }

    public virtual void getFilePath()
    {
      
      string currentDir = Environment.CurrentDirectory;

      filePath += currentDir + folderTeFile;

      if (!Directory.Exists(filePath))
      {
        Directory.CreateDirectory(filePath);
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
  }

  interface IteFileOperation
  {
    void getFilePath();
    bool loadFile();
    bool saveFile();
  }

}
