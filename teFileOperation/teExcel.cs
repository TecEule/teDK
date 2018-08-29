using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teFileOperation
{
  public class teExcel : teFileOperationBase
  {
    private static teExcel _instance;
    public static teExcel Instance
    {
      get
      {
        if (_instance == null)
          _instance = new teExcel();
        return _instance;
      }
    }

    private teExcel() { }
    
  }
}
