using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te.TerminkalenderType
{
  
    public class TerminkalenderItem
    {

    public enum AufgabenTyp
    {
      Geburtstag = 0,
      Montage,
      Hausputz,
      ResteMuell,
      PapierMuell,
      Sonstiges,
    }

    public string Projetktitel { get; set; }
    public string Notizen { get; set; }
    public int Aufgabentyp { get; set; }
    public int Intervall { get; set; }
    public DateTime VonDatum { get; set; }
    public DateTime BisDatum { get; set; }
    

  }

    public class SaveType
  {
    public enum SaveItem
    {
      JSON = 0,
      XML,
      Excel,
    }
  }
}
