using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teFileOperation
{
  public class teXML : teFileOperationBase
  {
    private static teXML _instance;
    public static teXML Instance
    {
      get
      {
        if (_instance == null)
          _instance = new teXML();
        return _instance;
      }
    }

    private teXML() { }


  }
}
