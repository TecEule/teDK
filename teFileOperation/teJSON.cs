using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teFileOperation
{
  public class teJSON : teFileOperationBase
  {
    private static teJSON _instance;
    public static teJSON Instance
    {
      get
      {
        if (_instance == null)
          _instance = new teJSON();
        return _instance;
      }
    }

    private teJSON()
    {
      // new Test

    }





  }
}
